// <auto-generated/>
using ApiSdk.Models.ODataErrors;
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
namespace ApiSdk.DeviceManagement.Reports.GetConfigurationPolicyNonComplianceSummaryReport {
    /// <summary>
    /// Provides operations to call the getConfigurationPolicyNonComplianceSummaryReport method.
    /// </summary>
    public class GetConfigurationPolicyNonComplianceSummaryReportRequestBuilder : BaseCliRequestBuilder {
        /// <summary>
        /// Not yet documented
        /// Find more info here <see href="https://learn.microsoft.com/graph/api/intune-reporting-devicemanagementreports-getconfigurationpolicynoncompliancesummaryreport?view=graph-rest-1.0" />
        /// </summary>
        /// <returns>A <cref="Command"></returns>
        public Command BuildPostCommand() {
            var command = new Command("post");
            command.Description = "Not yet documented\n\nFind more info here:\n  https://learn.microsoft.com/graph/api/intune-reporting-devicemanagementreports-getconfigurationpolicynoncompliancesummaryreport?view=graph-rest-1.0";
            var bodyOption = new Option<string>("--body", description: "The request body") {
            };
            bodyOption.IsRequired = true;
            command.AddOption(bodyOption);
            var outputFileOption = new Option<FileInfo>("--output-file");
            command.AddOption(outputFileOption);
            command.SetHandler(async (invocationContext) => {
                var body = invocationContext.ParseResult.GetValueForOption(bodyOption) ?? string.Empty;
                var outputFile = invocationContext.ParseResult.GetValueForOption(outputFileOption);
                var cancellationToken = invocationContext.GetCancellationToken();
                var reqAdapter = invocationContext.GetRequestAdapter();
                using var stream = new MemoryStream(Encoding.UTF8.GetBytes(body));
                var parseNode = ParseNodeFactoryRegistry.DefaultInstance.GetRootParseNode("application/json", stream);
                var model = parseNode.GetObjectValue<GetConfigurationPolicyNonComplianceSummaryReportPostRequestBody>(GetConfigurationPolicyNonComplianceSummaryReportPostRequestBody.CreateFromDiscriminatorValue);
                if (model is null) {
                    Console.Error.WriteLine("No model data to send.");
                    return;
                }
                var requestInfo = ToPostRequestInformation(model, q => {
                });
                requestInfo.SetContentFromParsable(reqAdapter, "application/json", model);
                var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                    {"4XX", ODataError.CreateFromDiscriminatorValue},
                    {"5XX", ODataError.CreateFromDiscriminatorValue},
                };
                var response = await reqAdapter.SendPrimitiveAsync<Stream>(requestInfo, errorMapping: errorMapping, cancellationToken: cancellationToken) ?? Stream.Null;
                if (outputFile == null) {
                    using var reader = new StreamReader(response);
                    var strContent = reader.ReadToEnd();
                    Console.Write(strContent);
                }
                else {
                    using var writeStream = outputFile.OpenWrite();
                    await response.CopyToAsync(writeStream);
                    Console.WriteLine($"Content written to {outputFile.FullName}.");
                }
            });
            return command;
        }
        /// <summary>
        /// Instantiates a new <see cref="GetConfigurationPolicyNonComplianceSummaryReportRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        public GetConfigurationPolicyNonComplianceSummaryReportRequestBuilder(Dictionary<string, object> pathParameters) : base("{+baseurl}/deviceManagement/reports/getConfigurationPolicyNonComplianceSummaryReport", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new <see cref="GetConfigurationPolicyNonComplianceSummaryReportRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public GetConfigurationPolicyNonComplianceSummaryReportRequestBuilder(string rawUrl) : base("{+baseurl}/deviceManagement/reports/getConfigurationPolicyNonComplianceSummaryReport", rawUrl) {
        }
        /// <summary>
        /// Not yet documented
        /// </summary>
        /// <returns>A <cref="RequestInformation"></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(GetConfigurationPolicyNonComplianceSummaryReportPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(GetConfigurationPolicyNonComplianceSummaryReportPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default) {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation(Method.POST, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/octet-stream, application/json");
            return requestInfo;
        }
    }
}
