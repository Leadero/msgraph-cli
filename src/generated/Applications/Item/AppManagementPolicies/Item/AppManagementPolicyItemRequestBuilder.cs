// <auto-generated/>
using ApiSdk.Applications.Item.AppManagementPolicies.Item.Ref;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Cli.Commons.IO;
using Microsoft.Kiota.Cli.Commons;
using System.Collections.Generic;
using System.CommandLine;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
namespace ApiSdk.Applications.Item.AppManagementPolicies.Item {
    /// <summary>
    /// Builds and executes requests for operations under \applications\{application-id}\appManagementPolicies\{appManagementPolicy-id}
    /// </summary>
    public class AppManagementPolicyItemRequestBuilder : BaseCliRequestBuilder {
        /// <summary>
        /// Provides operations to manage the collection of application entities.
        /// </summary>
        /// <returns>A <cref="Command"></returns>
        public Command BuildRefByIdNavCommand() {
            var command = new Command("ref-by-id");
            command.Description = "Provides operations to manage the collection of application entities.";
            var builder = new RefRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildDeleteCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Instantiates a new <see cref="AppManagementPolicyItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        public AppManagementPolicyItemRequestBuilder(Dictionary<string, object> pathParameters) : base("{+baseurl}/applications/{application%2Did}/appManagementPolicies/{appManagementPolicy%2Did}", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new <see cref="AppManagementPolicyItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public AppManagementPolicyItemRequestBuilder(string rawUrl) : base("{+baseurl}/applications/{application%2Did}/appManagementPolicies/{appManagementPolicy%2Did}", rawUrl) {
        }
    }
}
