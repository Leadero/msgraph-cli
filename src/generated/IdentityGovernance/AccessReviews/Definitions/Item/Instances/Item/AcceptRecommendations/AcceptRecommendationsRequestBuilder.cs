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
namespace ApiSdk.IdentityGovernance.AccessReviews.Definitions.Item.Instances.Item.AcceptRecommendations {
    /// <summary>
    /// Provides operations to call the acceptRecommendations method.
    /// </summary>
    public class AcceptRecommendationsRequestBuilder : BaseCliRequestBuilder {
        /// <summary>
        /// Allows the acceptance of recommendations on all accessReviewInstanceDecisionItem objects that haven&apos;t been reviewed on an accessReviewInstance object for which the calling user is a reviewer.
        /// Find more info here <see href="https://learn.microsoft.com/graph/api/accessreviewinstance-acceptrecommendations?view=graph-rest-1.0" />
        /// </summary>
        /// <returns>A <cref="Command"></returns>
        public Command BuildPostCommand() {
            var command = new Command("post");
            command.Description = "Allows the acceptance of recommendations on all accessReviewInstanceDecisionItem objects that haven't been reviewed on an accessReviewInstance object for which the calling user is a reviewer.\n\nFind more info here:\n  https://learn.microsoft.com/graph/api/accessreviewinstance-acceptrecommendations?view=graph-rest-1.0";
            var accessReviewScheduleDefinitionIdOption = new Option<string>("--access-review-schedule-definition-id", description: "The unique identifier of accessReviewScheduleDefinition") {
            };
            accessReviewScheduleDefinitionIdOption.IsRequired = true;
            command.AddOption(accessReviewScheduleDefinitionIdOption);
            var accessReviewInstanceIdOption = new Option<string>("--access-review-instance-id", description: "The unique identifier of accessReviewInstance") {
            };
            accessReviewInstanceIdOption.IsRequired = true;
            command.AddOption(accessReviewInstanceIdOption);
            command.SetHandler(async (invocationContext) => {
                var accessReviewScheduleDefinitionId = invocationContext.ParseResult.GetValueForOption(accessReviewScheduleDefinitionIdOption);
                var accessReviewInstanceId = invocationContext.ParseResult.GetValueForOption(accessReviewInstanceIdOption);
                var cancellationToken = invocationContext.GetCancellationToken();
                var reqAdapter = invocationContext.GetRequestAdapter();
                var requestInfo = ToPostRequestInformation(q => {
                });
                if (accessReviewScheduleDefinitionId is not null) requestInfo.PathParameters.Add("accessReviewScheduleDefinition%2Did", accessReviewScheduleDefinitionId);
                if (accessReviewInstanceId is not null) requestInfo.PathParameters.Add("accessReviewInstance%2Did", accessReviewInstanceId);
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
        /// Instantiates a new <see cref="AcceptRecommendationsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        public AcceptRecommendationsRequestBuilder(Dictionary<string, object> pathParameters) : base("{+baseurl}/identityGovernance/accessReviews/definitions/{accessReviewScheduleDefinition%2Did}/instances/{accessReviewInstance%2Did}/acceptRecommendations", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new <see cref="AcceptRecommendationsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public AcceptRecommendationsRequestBuilder(string rawUrl) : base("{+baseurl}/identityGovernance/accessReviews/definitions/{accessReviewScheduleDefinition%2Did}/instances/{accessReviewInstance%2Did}/acceptRecommendations", rawUrl) {
        }
        /// <summary>
        /// Allows the acceptance of recommendations on all accessReviewInstanceDecisionItem objects that haven&apos;t been reviewed on an accessReviewInstance object for which the calling user is a reviewer.
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
