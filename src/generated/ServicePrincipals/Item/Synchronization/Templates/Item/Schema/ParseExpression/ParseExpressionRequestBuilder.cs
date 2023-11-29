// <auto-generated/>
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
namespace ApiSdk.ServicePrincipals.Item.Synchronization.Templates.Item.Schema.ParseExpression {
    /// <summary>
    /// Provides operations to call the parseExpression method.
    /// </summary>
    public class ParseExpressionRequestBuilder : BaseCliRequestBuilder {
        /// <summary>
        /// Parse a given string expression into an attributeMappingSource object. For more information about expressions, see Writing Expressions for Attribute Mappings in Microsoft Entra ID.
        /// Find more info here <see href="https://learn.microsoft.com/graph/api/synchronization-synchronizationschema-parseexpression?view=graph-rest-1.0" />
        /// </summary>
        public Command BuildPostCommand() {
            var command = new Command("post");
            command.Description = "Parse a given string expression into an attributeMappingSource object. For more information about expressions, see Writing Expressions for Attribute Mappings in Microsoft Entra ID.\n\nFind more info here:\n  https://learn.microsoft.com/graph/api/synchronization-synchronizationschema-parseexpression?view=graph-rest-1.0";
            var servicePrincipalIdOption = new Option<string>("--service-principal-id", description: "The unique identifier of servicePrincipal") {
            };
            servicePrincipalIdOption.IsRequired = true;
            command.AddOption(servicePrincipalIdOption);
            var synchronizationTemplateIdOption = new Option<string>("--synchronization-template-id", description: "The unique identifier of synchronizationTemplate") {
            };
            synchronizationTemplateIdOption.IsRequired = true;
            command.AddOption(synchronizationTemplateIdOption);
            var bodyOption = new Option<string>("--body", description: "The request body") {
            };
            bodyOption.IsRequired = true;
            command.AddOption(bodyOption);
            var outputOption = new Option<FormatterType>("--output", () => FormatterType.JSON);
            command.AddOption(outputOption);
            var queryOption = new Option<string>("--query");
            command.AddOption(queryOption);
            command.SetHandler(async (invocationContext) => {
                var servicePrincipalId = invocationContext.ParseResult.GetValueForOption(servicePrincipalIdOption);
                var synchronizationTemplateId = invocationContext.ParseResult.GetValueForOption(synchronizationTemplateIdOption);
                var body = invocationContext.ParseResult.GetValueForOption(bodyOption) ?? string.Empty;
                var output = invocationContext.ParseResult.GetValueForOption(outputOption);
                var query = invocationContext.ParseResult.GetValueForOption(queryOption);
                IOutputFilter outputFilter = invocationContext.BindingContext.GetService(typeof(IOutputFilter)) as IOutputFilter ?? throw new ArgumentNullException("outputFilter");
                IOutputFormatterFactory outputFormatterFactory = invocationContext.BindingContext.GetService(typeof(IOutputFormatterFactory)) as IOutputFormatterFactory ?? throw new ArgumentNullException("outputFormatterFactory");
                var cancellationToken = invocationContext.GetCancellationToken();
                var reqAdapter = invocationContext.GetRequestAdapter();
                using var stream = new MemoryStream(Encoding.UTF8.GetBytes(body));
                var parseNode = ParseNodeFactoryRegistry.DefaultInstance.GetRootParseNode("application/json", stream);
                var model = parseNode.GetObjectValue<ParseExpressionPostRequestBody>(ParseExpressionPostRequestBody.CreateFromDiscriminatorValue);
                if (model is null) {
                    Console.Error.WriteLine("No model data to send.");
                    return;
                }
                var requestInfo = ToPostRequestInformation(model, q => {
                });
                if (servicePrincipalId is not null) requestInfo.PathParameters.Add("servicePrincipal%2Did", servicePrincipalId);
                if (synchronizationTemplateId is not null) requestInfo.PathParameters.Add("synchronizationTemplate%2Did", synchronizationTemplateId);
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
        /// Instantiates a new ParseExpressionRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        public ParseExpressionRequestBuilder(Dictionary<string, object> pathParameters) : base("{+baseurl}/servicePrincipals/{servicePrincipal%2Did}/synchronization/templates/{synchronizationTemplate%2Did}/schema/parseExpression", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new ParseExpressionRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public ParseExpressionRequestBuilder(string rawUrl) : base("{+baseurl}/servicePrincipals/{servicePrincipal%2Did}/synchronization/templates/{synchronizationTemplate%2Did}/schema/parseExpression", rawUrl) {
        }
        /// <summary>
        /// Parse a given string expression into an attributeMappingSource object. For more information about expressions, see Writing Expressions for Attribute Mappings in Microsoft Entra ID.
        /// </summary>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(ParseExpressionPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(ParseExpressionPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default) {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation(Method.POST, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
    }
}
