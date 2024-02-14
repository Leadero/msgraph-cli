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
namespace ApiSdk.DeviceManagement.MobileThreatDefenseConnectors.Item {
    /// <summary>
    /// Provides operations to manage the mobileThreatDefenseConnectors property of the microsoft.graph.deviceManagement entity.
    /// </summary>
    public class MobileThreatDefenseConnectorItemRequestBuilder : BaseCliRequestBuilder {
        /// <summary>
        /// Deletes a mobileThreatDefenseConnector.
        /// Find more info here <see href="https://learn.microsoft.com/graph/api/intune-onboarding-mobilethreatdefenseconnector-delete?view=graph-rest-1.0" />
        /// </summary>
        /// <returns>A <cref="Command"></returns>
        public Command BuildDeleteCommand() {
            var command = new Command("delete");
            command.Description = "Deletes a mobileThreatDefenseConnector.\n\nFind more info here:\n  https://learn.microsoft.com/graph/api/intune-onboarding-mobilethreatdefenseconnector-delete?view=graph-rest-1.0";
            var mobileThreatDefenseConnectorIdOption = new Option<string>("--mobile-threat-defense-connector-id", description: "The unique identifier of mobileThreatDefenseConnector") {
            };
            mobileThreatDefenseConnectorIdOption.IsRequired = true;
            command.AddOption(mobileThreatDefenseConnectorIdOption);
            var ifMatchOption = new Option<string[]>("--if-match", description: "ETag") {
                Arity = ArgumentArity.ZeroOrMore
            };
            ifMatchOption.IsRequired = false;
            command.AddOption(ifMatchOption);
            command.SetHandler(async (invocationContext) => {
                var mobileThreatDefenseConnectorId = invocationContext.ParseResult.GetValueForOption(mobileThreatDefenseConnectorIdOption);
                var ifMatch = invocationContext.ParseResult.GetValueForOption(ifMatchOption);
                var cancellationToken = invocationContext.GetCancellationToken();
                var reqAdapter = invocationContext.GetRequestAdapter();
                var requestInfo = ToDeleteRequestInformation(q => {
                });
                if (mobileThreatDefenseConnectorId is not null) requestInfo.PathParameters.Add("mobileThreatDefenseConnector%2Did", mobileThreatDefenseConnectorId);
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
        /// Read properties and relationships of the mobileThreatDefenseConnector object.
        /// Find more info here <see href="https://learn.microsoft.com/graph/api/intune-onboarding-mobilethreatdefenseconnector-get?view=graph-rest-1.0" />
        /// </summary>
        /// <returns>A <cref="Command"></returns>
        public Command BuildGetCommand() {
            var command = new Command("get");
            command.Description = "Read properties and relationships of the mobileThreatDefenseConnector object.\n\nFind more info here:\n  https://learn.microsoft.com/graph/api/intune-onboarding-mobilethreatdefenseconnector-get?view=graph-rest-1.0";
            var mobileThreatDefenseConnectorIdOption = new Option<string>("--mobile-threat-defense-connector-id", description: "The unique identifier of mobileThreatDefenseConnector") {
            };
            mobileThreatDefenseConnectorIdOption.IsRequired = true;
            command.AddOption(mobileThreatDefenseConnectorIdOption);
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
                var mobileThreatDefenseConnectorId = invocationContext.ParseResult.GetValueForOption(mobileThreatDefenseConnectorIdOption);
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
                if (mobileThreatDefenseConnectorId is not null) requestInfo.PathParameters.Add("mobileThreatDefenseConnector%2Did", mobileThreatDefenseConnectorId);
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
        /// Update the properties of a mobileThreatDefenseConnector object.
        /// Find more info here <see href="https://learn.microsoft.com/graph/api/intune-onboarding-mobilethreatdefenseconnector-update?view=graph-rest-1.0" />
        /// </summary>
        /// <returns>A <cref="Command"></returns>
        public Command BuildPatchCommand() {
            var command = new Command("patch");
            command.Description = "Update the properties of a mobileThreatDefenseConnector object.\n\nFind more info here:\n  https://learn.microsoft.com/graph/api/intune-onboarding-mobilethreatdefenseconnector-update?view=graph-rest-1.0";
            var mobileThreatDefenseConnectorIdOption = new Option<string>("--mobile-threat-defense-connector-id", description: "The unique identifier of mobileThreatDefenseConnector") {
            };
            mobileThreatDefenseConnectorIdOption.IsRequired = true;
            command.AddOption(mobileThreatDefenseConnectorIdOption);
            var bodyOption = new Option<string>("--body", description: "The request body") {
            };
            bodyOption.IsRequired = true;
            command.AddOption(bodyOption);
            var outputOption = new Option<FormatterType>("--output", () => FormatterType.JSON);
            command.AddOption(outputOption);
            var queryOption = new Option<string>("--query");
            command.AddOption(queryOption);
            command.SetHandler(async (invocationContext) => {
                var mobileThreatDefenseConnectorId = invocationContext.ParseResult.GetValueForOption(mobileThreatDefenseConnectorIdOption);
                var body = invocationContext.ParseResult.GetValueForOption(bodyOption) ?? string.Empty;
                var output = invocationContext.ParseResult.GetValueForOption(outputOption);
                var query = invocationContext.ParseResult.GetValueForOption(queryOption);
                IOutputFilter outputFilter = invocationContext.BindingContext.GetService(typeof(IOutputFilter)) as IOutputFilter ?? throw new ArgumentNullException("outputFilter");
                IOutputFormatterFactory outputFormatterFactory = invocationContext.BindingContext.GetService(typeof(IOutputFormatterFactory)) as IOutputFormatterFactory ?? throw new ArgumentNullException("outputFormatterFactory");
                var cancellationToken = invocationContext.GetCancellationToken();
                var reqAdapter = invocationContext.GetRequestAdapter();
                using var stream = new MemoryStream(Encoding.UTF8.GetBytes(body));
                var parseNode = ParseNodeFactoryRegistry.DefaultInstance.GetRootParseNode("application/json", stream);
                var model = parseNode.GetObjectValue<MobileThreatDefenseConnector>(MobileThreatDefenseConnector.CreateFromDiscriminatorValue);
                if (model is null) {
                    Console.Error.WriteLine("No model data to send.");
                    return;
                }
                var requestInfo = ToPatchRequestInformation(model, q => {
                });
                if (mobileThreatDefenseConnectorId is not null) requestInfo.PathParameters.Add("mobileThreatDefenseConnector%2Did", mobileThreatDefenseConnectorId);
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
        /// Instantiates a new <see cref="MobileThreatDefenseConnectorItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        public MobileThreatDefenseConnectorItemRequestBuilder(Dictionary<string, object> pathParameters) : base("{+baseurl}/deviceManagement/mobileThreatDefenseConnectors/{mobileThreatDefenseConnector%2Did}{?%24expand,%24select}", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new <see cref="MobileThreatDefenseConnectorItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public MobileThreatDefenseConnectorItemRequestBuilder(string rawUrl) : base("{+baseurl}/deviceManagement/mobileThreatDefenseConnectors/{mobileThreatDefenseConnector%2Did}{?%24expand,%24select}", rawUrl) {
        }
        /// <summary>
        /// Deletes a mobileThreatDefenseConnector.
        /// </summary>
        /// <returns>A <cref="RequestInformation"></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToDeleteRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToDeleteRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation(Method.DELETE, "{+baseurl}/deviceManagement/mobileThreatDefenseConnectors/{mobileThreatDefenseConnector%2Did}", PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Read properties and relationships of the mobileThreatDefenseConnector object.
        /// </summary>
        /// <returns>A <cref="RequestInformation"></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<MobileThreatDefenseConnectorItemRequestBuilderGetQueryParameters>>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<MobileThreatDefenseConnectorItemRequestBuilderGetQueryParameters>> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Update the properties of a mobileThreatDefenseConnector object.
        /// </summary>
        /// <returns>A <cref="RequestInformation"></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPatchRequestInformation(MobileThreatDefenseConnector body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToPatchRequestInformation(MobileThreatDefenseConnector body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default) {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation(Method.PATCH, "{+baseurl}/deviceManagement/mobileThreatDefenseConnectors/{mobileThreatDefenseConnector%2Did}", PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Read properties and relationships of the mobileThreatDefenseConnector object.
        /// </summary>
        public class MobileThreatDefenseConnectorItemRequestBuilderGetQueryParameters {
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
