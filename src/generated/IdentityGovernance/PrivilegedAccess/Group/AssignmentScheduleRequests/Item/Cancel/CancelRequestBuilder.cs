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
namespace ApiSdk.IdentityGovernance.PrivilegedAccess.Group.AssignmentScheduleRequests.Item.Cancel {
    /// <summary>
    /// Provides operations to call the cancel method.
    /// </summary>
    public class CancelRequestBuilder : BaseCliRequestBuilder {
        /// <summary>
        /// Cancel an access assignment request to a group whose membership and ownership are governed by PIM.
        /// Find more info here <see href="https://learn.microsoft.com/graph/api/privilegedaccessgroupassignmentschedulerequest-cancel?view=graph-rest-1.0" />
        /// </summary>
        public Command BuildPostCommand() {
            var command = new Command("post");
            command.Description = "Cancel an access assignment request to a group whose membership and ownership are governed by PIM.\n\nFind more info here:\n  https://learn.microsoft.com/graph/api/privilegedaccessgroupassignmentschedulerequest-cancel?view=graph-rest-1.0";
            var privilegedAccessGroupAssignmentScheduleRequestIdOption = new Option<string>("--privileged-access-group-assignment-schedule-request-id", description: "The unique identifier of privilegedAccessGroupAssignmentScheduleRequest") {
            };
            privilegedAccessGroupAssignmentScheduleRequestIdOption.IsRequired = true;
            command.AddOption(privilegedAccessGroupAssignmentScheduleRequestIdOption);
            command.SetHandler(async (invocationContext) => {
                var privilegedAccessGroupAssignmentScheduleRequestId = invocationContext.ParseResult.GetValueForOption(privilegedAccessGroupAssignmentScheduleRequestIdOption);
                var cancellationToken = invocationContext.GetCancellationToken();
                var reqAdapter = invocationContext.GetRequestAdapter();
                var requestInfo = ToPostRequestInformation(q => {
                });
                if (privilegedAccessGroupAssignmentScheduleRequestId is not null) requestInfo.PathParameters.Add("privilegedAccessGroupAssignmentScheduleRequest%2Did", privilegedAccessGroupAssignmentScheduleRequestId);
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
        /// Instantiates a new CancelRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        public CancelRequestBuilder(Dictionary<string, object> pathParameters) : base("{+baseurl}/identityGovernance/privilegedAccess/group/assignmentScheduleRequests/{privilegedAccessGroupAssignmentScheduleRequest%2Did}/cancel", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new CancelRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public CancelRequestBuilder(string rawUrl) : base("{+baseurl}/identityGovernance/privilegedAccess/group/assignmentScheduleRequests/{privilegedAccessGroupAssignmentScheduleRequest%2Did}/cancel", rawUrl) {
        }
        /// <summary>
        /// Cancel an access assignment request to a group whose membership and ownership are governed by PIM.
        /// </summary>
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
