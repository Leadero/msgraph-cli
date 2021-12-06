using ApiSdk.Models.Microsoft.Graph;
using ApiSdk.Workbooks.Item.Workbook.Tables.Item.Columns.Item.Filter.Apply;
using ApiSdk.Workbooks.Item.Workbook.Tables.Item.Columns.Item.Filter.ApplyBottomItemsFilter;
using ApiSdk.Workbooks.Item.Workbook.Tables.Item.Columns.Item.Filter.ApplyBottomPercentFilter;
using ApiSdk.Workbooks.Item.Workbook.Tables.Item.Columns.Item.Filter.ApplyCellColorFilter;
using ApiSdk.Workbooks.Item.Workbook.Tables.Item.Columns.Item.Filter.ApplyCustomFilter;
using ApiSdk.Workbooks.Item.Workbook.Tables.Item.Columns.Item.Filter.ApplyDynamicFilter;
using ApiSdk.Workbooks.Item.Workbook.Tables.Item.Columns.Item.Filter.ApplyFontColorFilter;
using ApiSdk.Workbooks.Item.Workbook.Tables.Item.Columns.Item.Filter.ApplyIconFilter;
using ApiSdk.Workbooks.Item.Workbook.Tables.Item.Columns.Item.Filter.ApplyTopItemsFilter;
using ApiSdk.Workbooks.Item.Workbook.Tables.Item.Columns.Item.Filter.ApplyTopPercentFilter;
using ApiSdk.Workbooks.Item.Workbook.Tables.Item.Columns.Item.Filter.ApplyValuesFilter;
using ApiSdk.Workbooks.Item.Workbook.Tables.Item.Columns.Item.Filter.Clear;
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
namespace ApiSdk.Workbooks.Item.Workbook.Tables.Item.Columns.Item.Filter {
    /// <summary>Builds and executes requests for operations under \workbooks\{driveItem-id}\workbook\tables\{workbookTable-id}\columns\{workbookTableColumn-id}\filter</summary>
    public class FilterRequestBuilder {
        /// <summary>Path parameters for the request</summary>
        private Dictionary<string, object> PathParameters { get; set; }
        /// <summary>The request adapter to use to execute the requests.</summary>
        private IRequestAdapter RequestAdapter { get; set; }
        /// <summary>Url template to use to build the URL for the current request builder</summary>
        private string UrlTemplate { get; set; }
        public Command BuildApplyBottomItemsFilterCommand() {
            var command = new Command("apply-bottom-items-filter");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Tables.Item.Columns.Item.Filter.ApplyBottomItemsFilter.ApplyBottomItemsFilterRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildApplyBottomPercentFilterCommand() {
            var command = new Command("apply-bottom-percent-filter");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Tables.Item.Columns.Item.Filter.ApplyBottomPercentFilter.ApplyBottomPercentFilterRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildApplyCellColorFilterCommand() {
            var command = new Command("apply-cell-color-filter");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Tables.Item.Columns.Item.Filter.ApplyCellColorFilter.ApplyCellColorFilterRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildApplyCommand() {
            var command = new Command("apply");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Tables.Item.Columns.Item.Filter.Apply.ApplyRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildApplyCustomFilterCommand() {
            var command = new Command("apply-custom-filter");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Tables.Item.Columns.Item.Filter.ApplyCustomFilter.ApplyCustomFilterRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildApplyDynamicFilterCommand() {
            var command = new Command("apply-dynamic-filter");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Tables.Item.Columns.Item.Filter.ApplyDynamicFilter.ApplyDynamicFilterRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildApplyFontColorFilterCommand() {
            var command = new Command("apply-font-color-filter");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Tables.Item.Columns.Item.Filter.ApplyFontColorFilter.ApplyFontColorFilterRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildApplyIconFilterCommand() {
            var command = new Command("apply-icon-filter");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Tables.Item.Columns.Item.Filter.ApplyIconFilter.ApplyIconFilterRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildApplyTopItemsFilterCommand() {
            var command = new Command("apply-top-items-filter");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Tables.Item.Columns.Item.Filter.ApplyTopItemsFilter.ApplyTopItemsFilterRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildApplyTopPercentFilterCommand() {
            var command = new Command("apply-top-percent-filter");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Tables.Item.Columns.Item.Filter.ApplyTopPercentFilter.ApplyTopPercentFilterRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildApplyValuesFilterCommand() {
            var command = new Command("apply-values-filter");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Tables.Item.Columns.Item.Filter.ApplyValuesFilter.ApplyValuesFilterRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildClearCommand() {
            var command = new Command("clear");
            var builder = new ApiSdk.Workbooks.Item.Workbook.Tables.Item.Columns.Item.Filter.Clear.ClearRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        /// <summary>
        /// Retrieve the filter applied to the column. Read-only.
        /// </summary>
        public Command BuildDeleteCommand() {
            var command = new Command("delete");
            // Create options for all the parameters
            command.AddOption(new Option<string>("--driveitem-id", description: "key: id of driveItem"));
            command.AddOption(new Option<string>("--workbooktable-id", description: "key: id of workbookTable"));
            command.AddOption(new Option<string>("--workbooktablecolumn-id", description: "key: id of workbookTableColumn"));
            command.Handler = CommandHandler.Create<string, string, string>(async (driveItemId, workbookTableId, workbookTableColumnId) => {
                var requestInfo = CreateDeleteRequestInformation();
                if (!String.IsNullOrEmpty(driveItemId)) requestInfo.PathParameters.Add("driveItem_id", driveItemId);
                if (!String.IsNullOrEmpty(workbookTableId)) requestInfo.PathParameters.Add("workbookTable_id", workbookTableId);
                if (!String.IsNullOrEmpty(workbookTableColumnId)) requestInfo.PathParameters.Add("workbookTableColumn_id", workbookTableColumnId);
                await RequestAdapter.SendNoContentAsync(requestInfo);
                // Print request output. What if the request has no return?
                Console.WriteLine("Success");
            });
            return command;
        }
        /// <summary>
        /// Retrieve the filter applied to the column. Read-only.
        /// </summary>
        public Command BuildGetCommand() {
            var command = new Command("get");
            // Create options for all the parameters
            command.AddOption(new Option<string>("--driveitem-id", description: "key: id of driveItem"));
            command.AddOption(new Option<string>("--workbooktable-id", description: "key: id of workbookTable"));
            command.AddOption(new Option<string>("--workbooktablecolumn-id", description: "key: id of workbookTableColumn"));
            command.AddOption(new Option<object>("--select", description: "Select properties to be returned"));
            command.AddOption(new Option<object>("--expand", description: "Expand related entities"));
            command.Handler = CommandHandler.Create<string, string, string, object, object>(async (driveItemId, workbookTableId, workbookTableColumnId, select, expand) => {
                var requestInfo = CreateGetRequestInformation();
                if (!String.IsNullOrEmpty(driveItemId)) requestInfo.PathParameters.Add("driveItem_id", driveItemId);
                if (!String.IsNullOrEmpty(workbookTableId)) requestInfo.PathParameters.Add("workbookTable_id", workbookTableId);
                if (!String.IsNullOrEmpty(workbookTableColumnId)) requestInfo.PathParameters.Add("workbookTableColumn_id", workbookTableColumnId);
                requestInfo.QueryParameters.Add("select", select);
                requestInfo.QueryParameters.Add("expand", expand);
                var result = await RequestAdapter.SendAsync<WorkbookFilter>(requestInfo);
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
        /// Retrieve the filter applied to the column. Read-only.
        /// </summary>
        public Command BuildPatchCommand() {
            var command = new Command("patch");
            // Create options for all the parameters
            command.AddOption(new Option<string>("--driveitem-id", description: "key: id of driveItem"));
            command.AddOption(new Option<string>("--workbooktable-id", description: "key: id of workbookTable"));
            command.AddOption(new Option<string>("--workbooktablecolumn-id", description: "key: id of workbookTableColumn"));
            command.AddOption(new Option<string>("--body"));
            command.Handler = CommandHandler.Create<string, string, string, string>(async (driveItemId, workbookTableId, workbookTableColumnId, body) => {
                using var stream = new MemoryStream(Encoding.UTF8.GetBytes(body));
                var parseNode = ParseNodeFactoryRegistry.DefaultInstance.GetRootParseNode("application/json", stream);
                var model = parseNode.GetObjectValue<WorkbookFilter>();
                var requestInfo = CreatePatchRequestInformation(model);
                if (!String.IsNullOrEmpty(driveItemId)) requestInfo.PathParameters.Add("driveItem_id", driveItemId);
                if (!String.IsNullOrEmpty(workbookTableId)) requestInfo.PathParameters.Add("workbookTable_id", workbookTableId);
                if (!String.IsNullOrEmpty(workbookTableColumnId)) requestInfo.PathParameters.Add("workbookTableColumn_id", workbookTableColumnId);
                await RequestAdapter.SendNoContentAsync(requestInfo);
                // Print request output. What if the request has no return?
                Console.WriteLine("Success");
            });
            return command;
        }
        /// <summary>
        /// Instantiates a new FilterRequestBuilder and sets the default values.
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        /// </summary>
        public FilterRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) {
            _ = pathParameters ?? throw new ArgumentNullException(nameof(pathParameters));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            UrlTemplate = "{+baseurl}/workbooks/{driveItem_id}/workbook/tables/{workbookTable_id}/columns/{workbookTableColumn_id}/filter{?select,expand}";
            var urlTplParams = new Dictionary<string, object>(pathParameters);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
        /// <summary>
        /// Retrieve the filter applied to the column. Read-only.
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// </summary>
        public RequestInformation CreateDeleteRequestInformation(Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default) {
            var requestInfo = new RequestInformation {
                HttpMethod = HttpMethod.DELETE,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            h?.Invoke(requestInfo.Headers);
            requestInfo.AddRequestOptions(o?.ToArray());
            return requestInfo;
        }
        /// <summary>
        /// Retrieve the filter applied to the column. Read-only.
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// <param name="q">Request query parameters</param>
        /// </summary>
        public RequestInformation CreateGetRequestInformation(Action<GetQueryParameters> q = default, Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default) {
            var requestInfo = new RequestInformation {
                HttpMethod = HttpMethod.GET,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            if (q != null) {
                var qParams = new GetQueryParameters();
                q.Invoke(qParams);
                qParams.AddQueryParameters(requestInfo.QueryParameters);
            }
            h?.Invoke(requestInfo.Headers);
            requestInfo.AddRequestOptions(o?.ToArray());
            return requestInfo;
        }
        /// <summary>
        /// Retrieve the filter applied to the column. Read-only.
        /// <param name="body"></param>
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// </summary>
        public RequestInformation CreatePatchRequestInformation(WorkbookFilter body, Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default) {
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation {
                HttpMethod = HttpMethod.PATCH,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            requestInfo.SetContentFromParsable(RequestAdapter, "application/json", body);
            h?.Invoke(requestInfo.Headers);
            requestInfo.AddRequestOptions(o?.ToArray());
            return requestInfo;
        }
        /// <summary>
        /// Retrieve the filter applied to the column. Read-only.
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task DeleteAsync(Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default, IResponseHandler responseHandler = default, CancellationToken cancellationToken = default) {
            var requestInfo = CreateDeleteRequestInformation(h, o);
            await RequestAdapter.SendNoContentAsync(requestInfo, responseHandler, cancellationToken);
        }
        /// <summary>
        /// Retrieve the filter applied to the column. Read-only.
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// <param name="q">Request query parameters</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task<WorkbookFilter> GetAsync(Action<GetQueryParameters> q = default, Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default, IResponseHandler responseHandler = default, CancellationToken cancellationToken = default) {
            var requestInfo = CreateGetRequestInformation(q, h, o);
            return await RequestAdapter.SendAsync<WorkbookFilter>(requestInfo, responseHandler, cancellationToken);
        }
        /// <summary>
        /// Retrieve the filter applied to the column. Read-only.
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="h">Request headers</param>
        /// <param name="model"></param>
        /// <param name="o">Request options</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task PatchAsync(WorkbookFilter model, Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default, IResponseHandler responseHandler = default, CancellationToken cancellationToken = default) {
            _ = model ?? throw new ArgumentNullException(nameof(model));
            var requestInfo = CreatePatchRequestInformation(model, h, o);
            await RequestAdapter.SendNoContentAsync(requestInfo, responseHandler, cancellationToken);
        }
        /// <summary>Retrieve the filter applied to the column. Read-only.</summary>
        public class GetQueryParameters : QueryParametersBase {
            /// <summary>Expand related entities</summary>
            public string[] Expand { get; set; }
            /// <summary>Select properties to be returned</summary>
            public string[] Select { get; set; }
        }
    }
}
