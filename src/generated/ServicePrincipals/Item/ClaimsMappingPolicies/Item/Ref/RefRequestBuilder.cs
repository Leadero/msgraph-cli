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
namespace ApiSdk.ServicePrincipals.Item.ClaimsMappingPolicies.Item.Ref {
    /// <summary>
    /// Provides operations to manage the collection of servicePrincipal entities.
    /// </summary>
    public class RefRequestBuilder : BaseCliRequestBuilder {
        /// <summary>
        /// Remove a claimsMappingPolicy from a servicePrincipal.
        /// Find more info here <see href="https://learn.microsoft.com/graph/api/serviceprincipal-delete-claimsmappingpolicies?view=graph-rest-1.0" />
        /// </summary>
        /// <returns>A <cref="Command"></returns>
        public Command BuildDeleteCommand() {
            var command = new Command("delete");
            command.Description = "Remove a claimsMappingPolicy from a servicePrincipal.\n\nFind more info here:\n  https://learn.microsoft.com/graph/api/serviceprincipal-delete-claimsmappingpolicies?view=graph-rest-1.0";
            var servicePrincipalIdOption = new Option<string>("--service-principal-id", description: "The unique identifier of servicePrincipal") {
            };
            servicePrincipalIdOption.IsRequired = true;
            command.AddOption(servicePrincipalIdOption);
            var claimsMappingPolicyIdOption = new Option<string>("--claims-mapping-policy-id", description: "The unique identifier of claimsMappingPolicy") {
            };
            claimsMappingPolicyIdOption.IsRequired = true;
            command.AddOption(claimsMappingPolicyIdOption);
            var ifMatchOption = new Option<string[]>("--if-match", description: "ETag") {
                Arity = ArgumentArity.ZeroOrMore
            };
            ifMatchOption.IsRequired = false;
            command.AddOption(ifMatchOption);
            command.SetHandler(async (invocationContext) => {
                var servicePrincipalId = invocationContext.ParseResult.GetValueForOption(servicePrincipalIdOption);
                var claimsMappingPolicyId = invocationContext.ParseResult.GetValueForOption(claimsMappingPolicyIdOption);
                var ifMatch = invocationContext.ParseResult.GetValueForOption(ifMatchOption);
                var cancellationToken = invocationContext.GetCancellationToken();
                var reqAdapter = invocationContext.GetRequestAdapter();
                var requestInfo = ToDeleteRequestInformation(q => {
                });
                if (servicePrincipalId is not null) requestInfo.PathParameters.Add("servicePrincipal%2Did", servicePrincipalId);
                if (claimsMappingPolicyId is not null) requestInfo.PathParameters.Add("claimsMappingPolicy%2Did", claimsMappingPolicyId);
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
        /// Instantiates a new <see cref="RefRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        public RefRequestBuilder(Dictionary<string, object> pathParameters) : base("{+baseurl}/servicePrincipals/{servicePrincipal%2Did}/claimsMappingPolicies/{claimsMappingPolicy%2Did}/$ref", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new <see cref="RefRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public RefRequestBuilder(string rawUrl) : base("{+baseurl}/servicePrincipals/{servicePrincipal%2Did}/claimsMappingPolicies/{claimsMappingPolicy%2Did}/$ref", rawUrl) {
        }
        /// <summary>
        /// Remove a claimsMappingPolicy from a servicePrincipal.
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
            var requestInfo = new RequestInformation(Method.DELETE, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
    }
}
