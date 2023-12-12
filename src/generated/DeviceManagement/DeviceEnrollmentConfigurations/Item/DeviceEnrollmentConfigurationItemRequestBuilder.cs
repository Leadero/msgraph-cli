// <auto-generated/>
using ApiSdk.DeviceManagement.DeviceEnrollmentConfigurations.Item.Assign;
using ApiSdk.DeviceManagement.DeviceEnrollmentConfigurations.Item.Assignments;
using ApiSdk.DeviceManagement.DeviceEnrollmentConfigurations.Item.SetPriority;
using ApiSdk.Models.ODataErrors;
using ApiSdk.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Cli.Commons.Extensions;
using Microsoft.Kiota.Cli.Commons.IO;
using Microsoft.Kiota.Cli.Commons;
using System.Collections.Generic;
using System.CommandLine;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace ApiSdk.DeviceManagement.DeviceEnrollmentConfigurations.Item {
    /// <summary>
    /// Provides operations to manage the deviceEnrollmentConfigurations property of the microsoft.graph.deviceManagement entity.
    /// </summary>
    public class DeviceEnrollmentConfigurationItemRequestBuilder : BaseCliRequestBuilder {
        /// <summary>
        /// Provides operations to manage the assignments property of the microsoft.graph.deviceEnrollmentConfiguration entity.
        /// </summary>
        public Command BuildAssignmentsNavCommand() {
            var command = new Command("assignments");
            command.Description = "Provides operations to manage the assignments property of the microsoft.graph.deviceEnrollmentConfiguration entity.";
            var builder = new AssignmentsRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            var nonExecCommands = new List<Command>();
            nonExecCommands.Add(builder.BuildCountNavCommand());
            execCommands.Add(builder.BuildCreateCommand());
            execCommands.Add(builder.BuildListCommand());
            var cmds = builder.BuildCommand();
            execCommands.AddRange(cmds.Item1);
            nonExecCommands.AddRange(cmds.Item2);
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            foreach (var cmd in nonExecCommands.OrderBy(static c => c.Name, StringComparer.Ordinal))
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to call the assign method.
        /// </summary>
        public Command BuildAssignNavCommand() {
            var command = new Command("assign");
            command.Description = "Provides operations to call the assign method.";
            var builder = new AssignRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildPostCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Deletes a deviceEnrollmentLimitConfiguration.
        /// Find more info here <see href="https://learn.microsoft.com/graph/api/intune-onboarding-deviceenrollmentlimitconfiguration-delete?view=graph-rest-1.0" />
        /// </summary>
        public Command BuildDeleteCommand() {
            var command = new Command("delete");
            command.Description = "Deletes a deviceEnrollmentLimitConfiguration.\n\nFind more info here:\n  https://learn.microsoft.com/graph/api/intune-onboarding-deviceenrollmentlimitconfiguration-delete?view=graph-rest-1.0";
            var deviceEnrollmentConfigurationIdOption = new Option<string>("--device-enrollment-configuration-id", description: "The unique identifier of deviceEnrollmentConfiguration") {
            };
            deviceEnrollmentConfigurationIdOption.IsRequired = true;
            command.AddOption(deviceEnrollmentConfigurationIdOption);
            var ifMatchOption = new Option<string[]>("--if-match", description: "ETag") {
                Arity = ArgumentArity.ZeroOrMore
            };
            ifMatchOption.IsRequired = false;
            command.AddOption(ifMatchOption);
            command.SetHandler(async (invocationContext) => {
                var deviceEnrollmentConfigurationId = invocationContext.ParseResult.GetValueForOption(deviceEnrollmentConfigurationIdOption);
                var ifMatch = invocationContext.ParseResult.GetValueForOption(ifMatchOption);
                var cancellationToken = invocationContext.GetCancellationToken();
                var reqAdapter = invocationContext.GetRequestAdapter();
                var requestInfo = ToDeleteRequestInformation(q => {
                });
                if (deviceEnrollmentConfigurationId is not null) requestInfo.PathParameters.Add("deviceEnrollmentConfiguration%2Did", deviceEnrollmentConfigurationId);
                if (ifMatch is not null) requestInfo.Headers.Add("If-Match", ifMatch);
                var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                    {"4XX", ODataError.CreateFromDiscriminatorValue},
                    {"5XX", ODataError.CreateFromDiscriminatorValue},
                };
                await reqAdapter.SendNoContentAsync(requestInfo, errorMapping: errorMapping, cancellationToken: cancellationToken);
                Console.WriteLine("Success");
            });
            return command;
        }
        /// <summary>
        /// Read properties and relationships of the deviceEnrollmentPlatformRestrictionsConfiguration object.
        /// Find more info here <see href="https://learn.microsoft.com/graph/api/intune-onboarding-deviceenrollmentplatformrestrictionsconfiguration-get?view=graph-rest-1.0" />
        /// </summary>
        public Command BuildGetCommand() {
            var command = new Command("get");
            command.Description = "Read properties and relationships of the deviceEnrollmentPlatformRestrictionsConfiguration object.\n\nFind more info here:\n  https://learn.microsoft.com/graph/api/intune-onboarding-deviceenrollmentplatformrestrictionsconfiguration-get?view=graph-rest-1.0";
            var deviceEnrollmentConfigurationIdOption = new Option<string>("--device-enrollment-configuration-id", description: "The unique identifier of deviceEnrollmentConfiguration") {
            };
            deviceEnrollmentConfigurationIdOption.IsRequired = true;
            command.AddOption(deviceEnrollmentConfigurationIdOption);
            var selectOption = new Option<string[]>("--select", description: "Select properties to be returned") {
                Arity = ArgumentArity.ZeroOrMore
            };
            selectOption.IsRequired = false;
            command.AddOption(selectOption);
            var expandOption = new Option<string[]>("--expand", description: "Expand related entities") {
                Arity = ArgumentArity.ZeroOrMore
            };
            expandOption.IsRequired = false;
            command.AddOption(expandOption);
            var outputOption = new Option<FormatterType>("--output", () => FormatterType.JSON);
            command.AddOption(outputOption);
            var queryOption = new Option<string>("--query");
            command.AddOption(queryOption);
            command.SetHandler(async (invocationContext) => {
                var deviceEnrollmentConfigurationId = invocationContext.ParseResult.GetValueForOption(deviceEnrollmentConfigurationIdOption);
                var select = invocationContext.ParseResult.GetValueForOption(selectOption);
                var expand = invocationContext.ParseResult.GetValueForOption(expandOption);
                var output = invocationContext.ParseResult.GetValueForOption(outputOption);
                var query = invocationContext.ParseResult.GetValueForOption(queryOption);
                IOutputFilter outputFilter = invocationContext.BindingContext.GetService(typeof(IOutputFilter)) as IOutputFilter ?? throw new ArgumentNullException("outputFilter");
                IOutputFormatterFactory outputFormatterFactory = invocationContext.BindingContext.GetService(typeof(IOutputFormatterFactory)) as IOutputFormatterFactory ?? throw new ArgumentNullException("outputFormatterFactory");
                var cancellationToken = invocationContext.GetCancellationToken();
                var reqAdapter = invocationContext.GetRequestAdapter();
                var requestInfo = ToGetRequestInformation(q => {
                    q.QueryParameters.Select = select;
                    q.QueryParameters.Expand = expand;
                });
                if (deviceEnrollmentConfigurationId is not null) requestInfo.PathParameters.Add("deviceEnrollmentConfiguration%2Did", deviceEnrollmentConfigurationId);
                var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                    {"4XX", ODataError.CreateFromDiscriminatorValue},
                    {"5XX", ODataError.CreateFromDiscriminatorValue},
                };
                var response = await reqAdapter.SendPrimitiveAsync<Stream>(requestInfo, errorMapping: errorMapping, cancellationToken: cancellationToken) ?? Stream.Null;
                response = (response != Stream.Null) ? await outputFilter.FilterOutputAsync(response, query, cancellationToken) : response;
                var formatter = outputFormatterFactory.GetFormatter(output);
                await formatter.WriteOutputAsync(response, cancellationToken);
            });
            return command;
        }
        /// <summary>
        /// Update the properties of a deviceEnrollmentWindowsHelloForBusinessConfiguration object.
        /// Find more info here <see href="https://learn.microsoft.com/graph/api/intune-onboarding-deviceenrollmentwindowshelloforbusinessconfiguration-update?view=graph-rest-1.0" />
        /// </summary>
        public Command BuildPatchCommand() {
            var command = new Command("patch");
            command.Description = "Update the properties of a deviceEnrollmentWindowsHelloForBusinessConfiguration object.\n\nFind more info here:\n  https://learn.microsoft.com/graph/api/intune-onboarding-deviceenrollmentwindowshelloforbusinessconfiguration-update?view=graph-rest-1.0";
            var deviceEnrollmentConfigurationIdOption = new Option<string>("--device-enrollment-configuration-id", description: "The unique identifier of deviceEnrollmentConfiguration") {
            };
            deviceEnrollmentConfigurationIdOption.IsRequired = true;
            command.AddOption(deviceEnrollmentConfigurationIdOption);
            var bodyOption = new Option<string>("--body", description: "The request body") {
            };
            bodyOption.IsRequired = true;
            command.AddOption(bodyOption);
            var outputOption = new Option<FormatterType>("--output", () => FormatterType.JSON);
            command.AddOption(outputOption);
            var queryOption = new Option<string>("--query");
            command.AddOption(queryOption);
            command.SetHandler(async (invocationContext) => {
                var deviceEnrollmentConfigurationId = invocationContext.ParseResult.GetValueForOption(deviceEnrollmentConfigurationIdOption);
                var body = invocationContext.ParseResult.GetValueForOption(bodyOption) ?? string.Empty;
                var output = invocationContext.ParseResult.GetValueForOption(outputOption);
                var query = invocationContext.ParseResult.GetValueForOption(queryOption);
                IOutputFilter outputFilter = invocationContext.BindingContext.GetService(typeof(IOutputFilter)) as IOutputFilter ?? throw new ArgumentNullException("outputFilter");
                IOutputFormatterFactory outputFormatterFactory = invocationContext.BindingContext.GetService(typeof(IOutputFormatterFactory)) as IOutputFormatterFactory ?? throw new ArgumentNullException("outputFormatterFactory");
                var cancellationToken = invocationContext.GetCancellationToken();
                var reqAdapter = invocationContext.GetRequestAdapter();
                using var stream = new MemoryStream(Encoding.UTF8.GetBytes(body));
                var parseNode = ParseNodeFactoryRegistry.DefaultInstance.GetRootParseNode("application/json", stream);
                var model = parseNode.GetObjectValue<DeviceEnrollmentConfiguration>(DeviceEnrollmentConfiguration.CreateFromDiscriminatorValue);
                if (model is null) {
                    Console.Error.WriteLine("No model data to send.");
                    return;
                }
                var requestInfo = ToPatchRequestInformation(model, q => {
                });
                if (deviceEnrollmentConfigurationId is not null) requestInfo.PathParameters.Add("deviceEnrollmentConfiguration%2Did", deviceEnrollmentConfigurationId);
                requestInfo.SetContentFromParsable(reqAdapter, "application/json", model);
                var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                    {"4XX", ODataError.CreateFromDiscriminatorValue},
                    {"5XX", ODataError.CreateFromDiscriminatorValue},
                };
                var response = await reqAdapter.SendPrimitiveAsync<Stream>(requestInfo, errorMapping: errorMapping, cancellationToken: cancellationToken) ?? Stream.Null;
                response = (response != Stream.Null) ? await outputFilter.FilterOutputAsync(response, query, cancellationToken) : response;
                var formatter = outputFormatterFactory.GetFormatter(output);
                await formatter.WriteOutputAsync(response, cancellationToken);
            });
            return command;
        }
        /// <summary>
        /// Provides operations to call the setPriority method.
        /// </summary>
        public Command BuildSetPriorityNavCommand() {
            var command = new Command("set-priority");
            command.Description = "Provides operations to call the setPriority method.";
            var builder = new SetPriorityRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildPostCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Instantiates a new DeviceEnrollmentConfigurationItemRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        public DeviceEnrollmentConfigurationItemRequestBuilder(Dictionary<string, object> pathParameters) : base("{+baseurl}/deviceManagement/deviceEnrollmentConfigurations/{deviceEnrollmentConfiguration%2Did}{?%24select,%24expand}", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new DeviceEnrollmentConfigurationItemRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public DeviceEnrollmentConfigurationItemRequestBuilder(string rawUrl) : base("{+baseurl}/deviceManagement/deviceEnrollmentConfigurations/{deviceEnrollmentConfiguration%2Did}{?%24select,%24expand}", rawUrl) {
        }
        /// <summary>
        /// Deletes a deviceEnrollmentLimitConfiguration.
        /// </summary>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToDeleteRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToDeleteRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation(Method.DELETE, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Read properties and relationships of the deviceEnrollmentPlatformRestrictionsConfiguration object.
        /// </summary>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<DeviceEnrollmentConfigurationItemRequestBuilderGetQueryParameters>>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<DeviceEnrollmentConfigurationItemRequestBuilderGetQueryParameters>> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Update the properties of a deviceEnrollmentWindowsHelloForBusinessConfiguration object.
        /// </summary>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPatchRequestInformation(DeviceEnrollmentConfiguration body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToPatchRequestInformation(DeviceEnrollmentConfiguration body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default) {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation(Method.PATCH, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Read properties and relationships of the deviceEnrollmentPlatformRestrictionsConfiguration object.
        /// </summary>
        public class DeviceEnrollmentConfigurationItemRequestBuilderGetQueryParameters {
            /// <summary>Expand related entities</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("%24expand")]
            public string[]? Expand { get; set; }
#nullable restore
#else
            [QueryParameter("%24expand")]
            public string[] Expand { get; set; }
#endif
            /// <summary>Select properties to be returned</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("%24select")]
            public string[]? Select { get; set; }
#nullable restore
#else
            [QueryParameter("%24select")]
            public string[] Select { get; set; }
#endif
        }
    }
}
