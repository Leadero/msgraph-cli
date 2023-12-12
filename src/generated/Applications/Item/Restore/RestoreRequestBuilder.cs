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
namespace ApiSdk.Applications.Item.Restore {
    /// <summary>
    /// Provides operations to call the restore method.
    /// </summary>
    public class RestoreRequestBuilder : BaseCliRequestBuilder {
        /// <summary>
        /// Restore a recently deleted application, group, servicePrincipal, administrative unit, or user object from deleted items. If an item was accidentally deleted, you can fully restore the item. However, security groups cannot be restored. Also, restoring an application doesn&apos;t restore the associated service principal automatically. You must call this API to explicitly restore the deleted service principal. A recently deleted item remains available for up to 30 days. After 30 days, the item is permanently deleted.
        /// Find more info here <see href="https://learn.microsoft.com/graph/api/directory-deleteditems-restore?view=graph-rest-1.0" />
        /// </summary>
        public Command BuildPostCommand() {
            var command = new Command("post");
            command.Description = "Restore a recently deleted application, group, servicePrincipal, administrative unit, or user object from deleted items. If an item was accidentally deleted, you can fully restore the item. However, security groups cannot be restored. Also, restoring an application doesn't restore the associated service principal automatically. You must call this API to explicitly restore the deleted service principal. A recently deleted item remains available for up to 30 days. After 30 days, the item is permanently deleted.\n\nFind more info here:\n  https://learn.microsoft.com/graph/api/directory-deleteditems-restore?view=graph-rest-1.0";
            var applicationIdOption = new Option<string>("--application-id", description: "The unique identifier of application") {
            };
            applicationIdOption.IsRequired = true;
            command.AddOption(applicationIdOption);
            var outputOption = new Option<FormatterType>("--output", () => FormatterType.JSON);
            command.AddOption(outputOption);
            var queryOption = new Option<string>("--query");
            command.AddOption(queryOption);
            command.SetHandler(async (invocationContext) => {
                var applicationId = invocationContext.ParseResult.GetValueForOption(applicationIdOption);
                var output = invocationContext.ParseResult.GetValueForOption(outputOption);
                var query = invocationContext.ParseResult.GetValueForOption(queryOption);
                IOutputFilter outputFilter = invocationContext.BindingContext.GetService(typeof(IOutputFilter)) as IOutputFilter ?? throw new ArgumentNullException("outputFilter");
                IOutputFormatterFactory outputFormatterFactory = invocationContext.BindingContext.GetService(typeof(IOutputFormatterFactory)) as IOutputFormatterFactory ?? throw new ArgumentNullException("outputFormatterFactory");
                var cancellationToken = invocationContext.GetCancellationToken();
                var reqAdapter = invocationContext.GetRequestAdapter();
                var requestInfo = ToPostRequestInformation(q => {
                });
                if (applicationId is not null) requestInfo.PathParameters.Add("application%2Did", applicationId);
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
        /// Instantiates a new RestoreRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        public RestoreRequestBuilder(Dictionary<string, object> pathParameters) : base("{+baseurl}/applications/{application%2Did}/restore", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new RestoreRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public RestoreRequestBuilder(string rawUrl) : base("{+baseurl}/applications/{application%2Did}/restore", rawUrl) {
        }
        /// <summary>
        /// Restore a recently deleted application, group, servicePrincipal, administrative unit, or user object from deleted items. If an item was accidentally deleted, you can fully restore the item. However, security groups cannot be restored. Also, restoring an application doesn&apos;t restore the associated service principal automatically. You must call this API to explicitly restore the deleted service principal. A recently deleted item remains available for up to 30 days. After 30 days, the item is permanently deleted.
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
