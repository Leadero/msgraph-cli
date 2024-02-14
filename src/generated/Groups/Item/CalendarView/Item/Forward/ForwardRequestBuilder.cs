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
namespace ApiSdk.Groups.Item.CalendarView.Item.Forward {
    /// <summary>
    /// Provides operations to call the forward method.
    /// </summary>
    public class ForwardRequestBuilder : BaseCliRequestBuilder {
        /// <summary>
        /// This action allows the organizer or attendee of a meeting event to forward the meeting request to a new recipient.  If the meeting event is forwarded from an attendee&apos;s Microsoft 365 mailbox to another recipient, this action also sends a message to notify the organizer of the forwarding, and adds the recipient to the organizer&apos;s copy of the meeting event. This convenience is not available when forwarding from an Outlook.com account.
        /// Find more info here <see href="https://learn.microsoft.com/graph/api/event-forward?view=graph-rest-1.0" />
        /// </summary>
        /// <returns>A <cref="Command"></returns>
        public Command BuildPostCommand() {
            var command = new Command("post");
            command.Description = "This action allows the organizer or attendee of a meeting event to forward the meeting request to a new recipient.  If the meeting event is forwarded from an attendee's Microsoft 365 mailbox to another recipient, this action also sends a message to notify the organizer of the forwarding, and adds the recipient to the organizer's copy of the meeting event. This convenience is not available when forwarding from an Outlook.com account.\n\nFind more info here:\n  https://learn.microsoft.com/graph/api/event-forward?view=graph-rest-1.0";
            var groupIdOption = new Option<string>("--group-id", description: "The unique identifier of group") {
            };
            groupIdOption.IsRequired = true;
            command.AddOption(groupIdOption);
            var eventIdOption = new Option<string>("--event-id", description: "The unique identifier of event") {
            };
            eventIdOption.IsRequired = true;
            command.AddOption(eventIdOption);
            var bodyOption = new Option<string>("--body", description: "The request body") {
            };
            bodyOption.IsRequired = true;
            command.AddOption(bodyOption);
            command.SetHandler(async (invocationContext) => {
                var groupId = invocationContext.ParseResult.GetValueForOption(groupIdOption);
                var eventId = invocationContext.ParseResult.GetValueForOption(eventIdOption);
                var body = invocationContext.ParseResult.GetValueForOption(bodyOption) ?? string.Empty;
                var cancellationToken = invocationContext.GetCancellationToken();
                var reqAdapter = invocationContext.GetRequestAdapter();
                using var stream = new MemoryStream(Encoding.UTF8.GetBytes(body));
                var parseNode = ParseNodeFactoryRegistry.DefaultInstance.GetRootParseNode("application/json", stream);
                var model = parseNode.GetObjectValue<ForwardPostRequestBody>(ForwardPostRequestBody.CreateFromDiscriminatorValue);
                if (model is null) {
                    Console.Error.WriteLine("No model data to send.");
                    return;
                }
                var requestInfo = ToPostRequestInformation(model, q => {
                });
                if (groupId is not null) requestInfo.PathParameters.Add("group%2Did", groupId);
                if (eventId is not null) requestInfo.PathParameters.Add("event%2Did", eventId);
                requestInfo.SetContentFromParsable(reqAdapter, "application/json", model);
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
        /// Instantiates a new <see cref="ForwardRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        public ForwardRequestBuilder(Dictionary<string, object> pathParameters) : base("{+baseurl}/groups/{group%2Did}/calendarView/{event%2Did}/forward", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new <see cref="ForwardRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public ForwardRequestBuilder(string rawUrl) : base("{+baseurl}/groups/{group%2Did}/calendarView/{event%2Did}/forward", rawUrl) {
        }
        /// <summary>
        /// This action allows the organizer or attendee of a meeting event to forward the meeting request to a new recipient.  If the meeting event is forwarded from an attendee&apos;s Microsoft 365 mailbox to another recipient, this action also sends a message to notify the organizer of the forwarding, and adds the recipient to the organizer&apos;s copy of the meeting event. This convenience is not available when forwarding from an Outlook.com account.
        /// </summary>
        /// <returns>A <cref="RequestInformation"></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(ForwardPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(ForwardPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default) {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation(Method.POST, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
    }
}
