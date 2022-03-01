﻿using ApiSdk;
using Azure.Identity;
using DevLab.JmesPath;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Graph.Cli.Core.Authentication;
using Microsoft.Graph.Cli.Core.Commands.Authentication;
using Microsoft.Graph.Cli.Core.Configuration;
using Microsoft.Graph.Cli.Core.IO;
using Microsoft.Graph.Cli.Core.Utils;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Authentication.Azure;
using Microsoft.Kiota.Cli.Commons.IO;
using Microsoft.Kiota.Http.HttpClientLibrary;
using Microsoft.Kiota.Http.HttpClientLibrary.Middleware;
using Microsoft.Kiota.Http.HttpClientLibrary.Middleware.Options;
using System.CommandLine;
using System.CommandLine.Builder;
using System.CommandLine.Hosting;
using System.CommandLine.Parsing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Reflection;
using System.Threading.Tasks;
using System.Collections.Generic;
using System;
using System.CommandLine.IO;

namespace Microsoft.Graph.Cli
{
    class Program
    {
        const string SdkVersionHeaderValueFormatString = "{0}-cli/{1}.{2}.{3}";

        static async Task<int> Main(string[] args)
        {
            // We don't have access to a built host yet. Get configuration settings using a configuration builder.
            // Required to set initial token credentials.
            var configBuilder = new ConfigurationBuilder();
            ConfigureAppConfiguration(configBuilder);
            var config = configBuilder.Build();

            var authSettings = config.GetSection(Constants.AuthenticationSection).Get<AuthenticationOptions>();
            var authServiceFactory = new AuthenticationServiceFactory(new PathUtility());
            var authStrategy = AuthenticationStrategy.DeviceCode;

            var credential = await authServiceFactory.GetTokenCredentialAsync(authStrategy, authSettings?.TenantId, authSettings?.ClientId);
            var authProvider = new AzureIdentityAuthenticationProvider(credential, new string[] {"graph.microsoft.com"});
            var defaultHandlers = KiotaClientFactory.CreateDefaultHandlers();

            var assemblyVersion = Assembly.GetExecutingAssembly().GetName().Version;
            var sdkVersionHeaderValue = string.Format(
                SdkVersionHeaderValueFormatString,
                "graph",
                assemblyVersion.Major,
                assemblyVersion.Minor,
                assemblyVersion.Build);

            var telemetryHandlerOption = new TelemetryHandlerOption {
                TelemetryConfigurator = (request) => {
                    request.Headers.Add("SdkVersion", sdkVersionHeaderValue);
                    return request;
                }
            };
            var telemetryHandler = new TelemetryHandler(telemetryHandlerOption);
            defaultHandlers.Add(telemetryHandler);
            var finalHandler = KiotaClientFactory.ChainHandlersCollectionAndGetFirstLink(KiotaClientFactory.GetDefaultHttpMessageHandler(), defaultHandlers.ToArray());

            using var httpClient = KiotaClientFactory.Create(finalHandler);
            var core = new HttpClientRequestAdapter(authProvider, httpClient: httpClient);
            var client = new GraphClient(core);

            var commands = new List<Command>();
            var loginCommand = new LoginCommand(authServiceFactory);
            commands.Add(loginCommand.Build());

            var logoutCommand = new LogoutCommand(new LogoutService());
            commands.Add(logoutCommand.Build());

            var builder = BuildCommandLine(client, commands).UseDefaults().UseHost(CreateHostBuilder);
            builder.AddMiddleware((invocation) => {
                var host = invocation.GetHost();
                var outputFilter = host.Services.GetRequiredService<IOutputFilter>();
                var outputFormatterFactory = host.Services.GetRequiredService<IOutputFormatterFactory>();
                invocation.BindingContext.AddService<IOutputFilter>(_ => outputFilter);
                invocation.BindingContext.AddService<IOutputFormatterFactory>(_ => outputFormatterFactory);
            });
            builder.UseExceptionHandler((ex, context) => {
                if (ex is AuthenticationRequiredException) {
                    Console.ResetColor();
                    Console.ForegroundColor = ConsoleColor.Red;
                    context.Console.Error.WriteLine("Token acquisition failed. Run mgc login command first to get an access token.");
                    Console.ResetColor();
                } else {
                    Console.ResetColor();
                    Console.ForegroundColor = ConsoleColor.Red;
                    context.Console.Error.WriteLine(ex.Message);
                    context.Console.Error.WriteLine(ex.StackTrace);
                    Console.ResetColor();
                }
            });

            var parser = builder.Build();

            return await parser.InvokeAsync(args);
        }

        static CommandLineBuilder BuildCommandLine(GraphClient client, IEnumerable<Command> commands)
        {
            var rootCommand = client.BuildRootCommand();
            rootCommand.Description = "Microsoft Graph CLI";

            foreach (var command in commands) {
                rootCommand.AddCommand(command);
            }

            return new CommandLineBuilder(rootCommand);
        }

        static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder().ConfigureHostConfiguration((configHost) => {
                configHost.SetBasePath(Directory.GetCurrentDirectory());
            }).ConfigureAppConfiguration((ctx, config) => {
                ConfigureAppConfiguration(config);
            }).ConfigureServices((ctx, services) => {
                var authSection = ctx.Configuration.GetSection(Constants.AuthenticationSection);
                services.Configure<AuthenticationOptions>(authSection);
                services.AddSingleton<IPathUtility, PathUtility>();
                services.AddSingleton<IOutputFilter, JmesPathOutputFilter>();
                services.AddSingleton<JmesPath>();
                services.AddSingleton<IOutputFormatterFactory, OutputFormatterFactory>();
            });
        
        static void ConfigureAppConfiguration(IConfigurationBuilder builder) {
            builder.Sources.Clear();
            builder.AddJsonFile("app-settings.json", optional: false);
            var dataDir = new PathUtility().GetApplicationDataDirectory();
            var userConfigPath = Path.Combine(dataDir, "settings.json");
            builder.AddJsonFile(userConfigPath, optional: true);
            builder.AddEnvironmentVariables(prefix: "MGC_");
        }
    }
}
