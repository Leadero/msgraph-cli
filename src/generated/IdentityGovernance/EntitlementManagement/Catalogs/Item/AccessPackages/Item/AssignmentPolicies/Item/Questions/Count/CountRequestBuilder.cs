using ApiSdk.Models.ODataErrors;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Cli.Commons;
using Microsoft.Kiota.Cli.Commons.Extensions;
using Microsoft.Kiota.Cli.Commons.IO;
using System;
using System.Collections.Generic;
using System.CommandLine;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
namespace ApiSdk.IdentityGovernance.EntitlementManagement.Catalogs.Item.AccessPackages.Item.AssignmentPolicies.Item.Questions.Count {
    /// <summary>
    /// Provides operations to count the resources in the collection.
    /// </summary>
    public class CountRequestBuilder : BaseCliRequestBuilder {
        /// <summary>
        /// Get the number of the resource
        /// </summary>
        public Command BuildGetCommand() {
            var command = new Command("get");
            command.Description = "Get the number of the resource";
            var accessPackageCatalogIdOption = new Option<string>("--access-package-catalog-id", description: "The unique identifier of accessPackageCatalog") {
            };
            accessPackageCatalogIdOption.IsRequired = true;
            command.AddOption(accessPackageCatalogIdOption);
            var accessPackageIdOption = new Option<string>("--access-package-id", description: "The unique identifier of accessPackage") {
            };
            accessPackageIdOption.IsRequired = true;
            command.AddOption(accessPackageIdOption);
            var accessPackageAssignmentPolicyIdOption = new Option<string>("--access-package-assignment-policy-id", description: "The unique identifier of accessPackageAssignmentPolicy") {
            };
            accessPackageAssignmentPolicyIdOption.IsRequired = true;
            command.AddOption(accessPackageAssignmentPolicyIdOption);
            var searchOption = new Option<string>("--search", description: "Search items by search phrases") {
            };
            searchOption.IsRequired = false;
            command.AddOption(searchOption);
            var filterOption = new Option<string>("--filter", description: "Filter items by property values") {
            };
            filterOption.IsRequired = false;
            command.AddOption(filterOption);
            command.SetHandler(async (invocationContext) => {
                var accessPackageCatalogId = invocationContext.ParseResult.GetValueForOption(accessPackageCatalogIdOption);
                var accessPackageId = invocationContext.ParseResult.GetValueForOption(accessPackageIdOption);
                var accessPackageAssignmentPolicyId = invocationContext.ParseResult.GetValueForOption(accessPackageAssignmentPolicyIdOption);
                var search = invocationContext.ParseResult.GetValueForOption(searchOption);
                var filter = invocationContext.ParseResult.GetValueForOption(filterOption);
                IOutputFormatterFactory outputFormatterFactory = invocationContext.BindingContext.GetService(typeof(IOutputFormatterFactory)) as IOutputFormatterFactory ?? throw new ArgumentNullException("outputFormatterFactory");
                var cancellationToken = invocationContext.GetCancellationToken();
                var reqAdapter = invocationContext.GetRequestAdapter();
                var requestInfo = ToGetRequestInformation(q => {
                    if (!string.IsNullOrEmpty(search)) q.QueryParameters.Search = search;
                    if (!string.IsNullOrEmpty(filter)) q.QueryParameters.Filter = filter;
                });
                if (accessPackageCatalogId is not null) requestInfo.PathParameters.Add("accessPackageCatalog%2Did", accessPackageCatalogId);
                if (accessPackageId is not null) requestInfo.PathParameters.Add("accessPackage%2Did", accessPackageId);
                if (accessPackageAssignmentPolicyId is not null) requestInfo.PathParameters.Add("accessPackageAssignmentPolicy%2Did", accessPackageAssignmentPolicyId);
                var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                    {"4XX", ODataError.CreateFromDiscriminatorValue},
                    {"5XX", ODataError.CreateFromDiscriminatorValue},
                };
                var response = await reqAdapter.SendPrimitiveAsync<Stream>(requestInfo, errorMapping: errorMapping, cancellationToken: cancellationToken) ?? Stream.Null;
                var formatter = outputFormatterFactory.GetFormatter(FormatterType.TEXT);
                await formatter.WriteOutputAsync(response, null, cancellationToken);
            });
            return command;
        }
        /// <summary>
        /// Instantiates a new CountRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        public CountRequestBuilder(Dictionary<string, object> pathParameters) : base("{+baseurl}/identityGovernance/entitlementManagement/catalogs/{accessPackageCatalog%2Did}/accessPackages/{accessPackage%2Did}/assignmentPolicies/{accessPackageAssignmentPolicy%2Did}/questions/$count{?%24search,%24filter}", pathParameters) {
        }
        /// <summary>
        /// Get the number of the resource
        /// </summary>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<CountRequestBuilderGetQueryParameters>>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<CountRequestBuilderGetQueryParameters>> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation {
                HttpMethod = Method.GET,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            requestInfo.Headers.Add("Accept", "text/plain");
            if (requestConfiguration != null) {
                var requestConfig = new RequestConfiguration<CountRequestBuilderGetQueryParameters>();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddQueryParameters(requestConfig.QueryParameters);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// Get the number of the resource
        /// </summary>
        public class CountRequestBuilderGetQueryParameters {
            /// <summary>Filter items by property values</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("%24filter")]
            public string? Filter { get; set; }
#nullable restore
#else
            [QueryParameter("%24filter")]
            public string Filter { get; set; }
#endif
            /// <summary>Search items by search phrases</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("%24search")]
            public string? Search { get; set; }
#nullable restore
#else
            [QueryParameter("%24search")]
            public string Search { get; set; }
#endif
        }
    }
}