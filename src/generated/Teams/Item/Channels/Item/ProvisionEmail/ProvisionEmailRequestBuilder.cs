using ApiSdk.Models.Microsoft.Graph;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.CommandLine;
using System.CommandLine.Invocation;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ApiSdk.Teams.Item.Channels.Item.ProvisionEmail {
    /// <summary>Builds and executes requests for operations under \teams\{team-id}\channels\{channel-id}\microsoft.graph.provisionEmail</summary>
    public class ProvisionEmailRequestBuilder {
        /// <summary>Path parameters for the request</summary>
        private Dictionary<string, object> PathParameters { get; set; }
        /// <summary>The request adapter to use to execute the requests.</summary>
        private IRequestAdapter RequestAdapter { get; set; }
        /// <summary>Url template to use to build the URL for the current request builder</summary>
        private string UrlTemplate { get; set; }
        /// <summary>
        /// Invoke action provisionEmail
        /// </summary>
        public Command BuildPostCommand() {
            var command = new Command("post");
            // Create options for all the parameters
            command.AddOption(new Option<string>("--team-id", description: "key: id of team"));
            command.AddOption(new Option<string>("--channel-id", description: "key: id of channel"));
            command.Handler = CommandHandler.Create<string, string>(async (teamId, channelId) => {
                var requestInfo = CreatePostRequestInformation();
                if (!String.IsNullOrEmpty(teamId)) requestInfo.PathParameters.Add("team_id", teamId);
                if (!String.IsNullOrEmpty(channelId)) requestInfo.PathParameters.Add("channel_id", channelId);
                var result = await RequestAdapter.SendAsync<ProvisionEmailResponse>(requestInfo);
                // Print request output. What if the request has no return?
                using var serializer = RequestAdapter.SerializationWriterFactory.GetSerializationWriter("application/json");
                serializer.WriteObjectValue(null, result);
                using var content = serializer.GetSerializedContent();
                using var reader = new StreamReader(content);
                var strContent = await reader.ReadToEndAsync();
                Console.Write(strContent + "\n");
            });
            return command;
        }
        /// <summary>
        /// Instantiates a new ProvisionEmailRequestBuilder and sets the default values.
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        /// </summary>
        public ProvisionEmailRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) {
            _ = pathParameters ?? throw new ArgumentNullException(nameof(pathParameters));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            UrlTemplate = "{+baseurl}/teams/{team_id}/channels/{channel_id}/microsoft.graph.provisionEmail";
            var urlTplParams = new Dictionary<string, object>(pathParameters);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
        /// <summary>
        /// Invoke action provisionEmail
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// </summary>
        public RequestInformation CreatePostRequestInformation(Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default) {
            var requestInfo = new RequestInformation {
                HttpMethod = HttpMethod.POST,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            h?.Invoke(requestInfo.Headers);
            requestInfo.AddRequestOptions(o?.ToArray());
            return requestInfo;
        }
        /// <summary>
        /// Invoke action provisionEmail
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task<ProvisionEmailResponse> PostAsync(Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default, IResponseHandler responseHandler = default, CancellationToken cancellationToken = default) {
            var requestInfo = CreatePostRequestInformation(h, o);
            return await RequestAdapter.SendAsync<ProvisionEmailResponse>(requestInfo, responseHandler, cancellationToken);
        }
        /// <summary>Union type wrapper for classes provisionChannelEmailResult</summary>
        public class ProvisionEmailResponse : IParsable {
            /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
            public IDictionary<string, object> AdditionalData { get; set; }
            /// <summary>Union type representation for type provisionChannelEmailResult</summary>
            public ProvisionChannelEmailResult ProvisionChannelEmailResult { get; set; }
            /// <summary>
            /// Instantiates a new provisionEmailResponse and sets the default values.
            /// </summary>
            public ProvisionEmailResponse() {
                AdditionalData = new Dictionary<string, object>();
            }
            /// <summary>
            /// The deserialization information for the current model
            /// </summary>
            public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
                return new Dictionary<string, Action<T, IParseNode>> {
                    {"provisionChannelEmailResult", (o,n) => { (o as ProvisionEmailResponse).ProvisionChannelEmailResult = n.GetObjectValue<ProvisionChannelEmailResult>(); } },
                };
            }
            /// <summary>
            /// Serializes information the current object
            /// <param name="writer">Serialization writer to use to serialize this model</param>
            /// </summary>
            public void Serialize(ISerializationWriter writer) {
                _ = writer ?? throw new ArgumentNullException(nameof(writer));
                writer.WriteObjectValue<ProvisionChannelEmailResult>("provisionChannelEmailResult", ProvisionChannelEmailResult);
                writer.WriteAdditionalData(AdditionalData);
            }
        }
    }
}
