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
namespace ApiSdk.Workbooks.Item.Workbook.Worksheets.Item.Charts.Item.ImageWithWidthWithHeight {
    /// <summary>Builds and executes requests for operations under \workbooks\{driveItem-id}\workbook\worksheets\{workbookWorksheet-id}\charts\{workbookChart-id}\microsoft.graph.image(width={width},height={height})</summary>
    public class ImageWithWidthWithHeightRequestBuilder {
        /// <summary>Path parameters for the request</summary>
        private Dictionary<string, object> PathParameters { get; set; }
        /// <summary>The request adapter to use to execute the requests.</summary>
        private IRequestAdapter RequestAdapter { get; set; }
        /// <summary>Url template to use to build the URL for the current request builder</summary>
        private string UrlTemplate { get; set; }
        /// <summary>
        /// Invoke function image
        /// </summary>
        public Command BuildGetCommand() {
            var command = new Command("get");
            // Create options for all the parameters
            command.AddOption(new Option<string>("--driveitem-id", description: "key: id of driveItem"));
            command.AddOption(new Option<string>("--workbookworksheet-id", description: "key: id of workbookWorksheet"));
            command.AddOption(new Option<string>("--workbookchart-id", description: "key: id of workbookChart"));
            command.AddOption(new Option<int?>("--width", description: "Usage: width={width}"));
            command.AddOption(new Option<int?>("--height", description: "Usage: height={height}"));
            command.Handler = CommandHandler.Create<string, string, string, int?, int?>(async (driveItemId, workbookWorksheetId, workbookChartId, width, height) => {
                var requestInfo = CreateGetRequestInformation();
                if (!String.IsNullOrEmpty(driveItemId)) requestInfo.PathParameters.Add("driveItem_id", driveItemId);
                if (!String.IsNullOrEmpty(workbookWorksheetId)) requestInfo.PathParameters.Add("workbookWorksheet_id", workbookWorksheetId);
                if (!String.IsNullOrEmpty(workbookChartId)) requestInfo.PathParameters.Add("workbookChart_id", workbookChartId);
                requestInfo.PathParameters.Add("width", width);
                requestInfo.PathParameters.Add("height", height);
                var result = await RequestAdapter.SendPrimitiveAsync<string>(requestInfo);
                // Print request output. What if the request has no return?
                using var serializer = RequestAdapter.SerializationWriterFactory.GetSerializationWriter("application/json");
                serializer.WriteStringValue(null, result);
                using var content = serializer.GetSerializedContent();
                using var reader = new StreamReader(content);
                var strContent = await reader.ReadToEndAsync();
                Console.Write(strContent + "\n");
            });
            return command;
        }
        /// <summary>
        /// Instantiates a new ImageWithWidthWithHeightRequestBuilder and sets the default values.
        /// <param name="height">Usage: height={height}</param>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        /// <param name="width">Usage: width={width}</param>
        /// </summary>
        public ImageWithWidthWithHeightRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter, int? width = default, int? height = default) {
            _ = pathParameters ?? throw new ArgumentNullException(nameof(pathParameters));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            UrlTemplate = "{+baseurl}/workbooks/{driveItem_id}/workbook/worksheets/{workbookWorksheet_id}/charts/{workbookChart_id}/microsoft.graph.image(width={width},height={height})";
            var urlTplParams = new Dictionary<string, object>(pathParameters);
            urlTplParams.Add("width", width);
            urlTplParams.Add("height", height);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
        /// <summary>
        /// Invoke function image
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// </summary>
        public RequestInformation CreateGetRequestInformation(Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default) {
            var requestInfo = new RequestInformation {
                HttpMethod = HttpMethod.GET,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            h?.Invoke(requestInfo.Headers);
            requestInfo.AddRequestOptions(o?.ToArray());
            return requestInfo;
        }
        /// <summary>
        /// Invoke function image
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task<string> GetAsync(Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default, IResponseHandler responseHandler = default, CancellationToken cancellationToken = default) {
            var requestInfo = CreateGetRequestInformation(h, o);
            return await RequestAdapter.SendPrimitiveAsync<string>(requestInfo, responseHandler, cancellationToken);
        }
    }
}
