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
namespace ApiSdk.DeviceAppManagement.VppTokens.Item.SyncLicenses {
    /// <summary>
    /// Provides operations to call the syncLicenses method.
    /// </summary>
    public class SyncLicensesRequestBuilder : BaseCliRequestBuilder {
        /// <summary>
        /// Syncs licenses associated with a specific appleVolumePurchaseProgramToken
        /// Find more info here <see href="https://learn.microsoft.com/graph/api/intune-onboarding-vpptoken-synclicenses?view=graph-rest-1.0" />
        /// </summary>
        /// <returns>A <cref="Command"></returns>
        public Command BuildPostCommand() {
            var command = new Command("post");
            command.Description = "Syncs licenses associated with a specific appleVolumePurchaseProgramToken\n\nFind more info here:\n  https://learn.microsoft.com/graph/api/intune-onboarding-vpptoken-synclicenses?view=graph-rest-1.0";
            var vppTokenIdOption = new Option<string>("--vpp-token-id", description: "The unique identifier of vppToken") {
            };
            vppTokenIdOption.IsRequired = true;
            command.AddOption(vppTokenIdOption);
            var outputOption = new Option<FormatterType>("--output", () => FormatterType.JSON);
            command.AddOption(outputOption);
            var queryOption = new Option<string>("--query");
            command.AddOption(queryOption);
            command.SetHandler(async (invocationContext) => {
                var vppTokenId = invocationContext.ParseResult.GetValueForOption(vppTokenIdOption);
                var output = invocationContext.ParseResult.GetValueForOption(outputOption);
                var query = invocationContext.ParseResult.GetValueForOption(queryOption);
                IOutputFilter outputFilter = invocationContext.BindingContext.GetService(typeof(IOutputFilter)) as IOutputFilter ?? throw new ArgumentNullException("outputFilter");
                IOutputFormatterFactory outputFormatterFactory = invocationContext.BindingContext.GetService(typeof(IOutputFormatterFactory)) as IOutputFormatterFactory ?? throw new ArgumentNullException("outputFormatterFactory");
                var cancellationToken = invocationContext.GetCancellationToken();
                var reqAdapter = invocationContext.GetRequestAdapter();
                var requestInfo = ToPostRequestInformation(q => {
                });
                if (vppTokenId is not null) requestInfo.PathParameters.Add("vppToken%2Did", vppTokenId);
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
        /// Instantiates a new <see cref="SyncLicensesRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        public SyncLicensesRequestBuilder(Dictionary<string, object> pathParameters) : base("{+baseurl}/deviceAppManagement/vppTokens/{vppToken%2Did}/syncLicenses", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new <see cref="SyncLicensesRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public SyncLicensesRequestBuilder(string rawUrl) : base("{+baseurl}/deviceAppManagement/vppTokens/{vppToken%2Did}/syncLicenses", rawUrl) {
        }
        /// <summary>
        /// Syncs licenses associated with a specific appleVolumePurchaseProgramToken
        /// </summary>
        /// <returns>A <cref="RequestInformation"></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation(Method.POST, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
    }
}
