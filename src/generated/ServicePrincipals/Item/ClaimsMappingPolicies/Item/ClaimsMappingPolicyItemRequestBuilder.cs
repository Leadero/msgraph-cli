// <auto-generated/>
using ApiSdk.ServicePrincipals.Item.ClaimsMappingPolicies.Item.Ref;
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
namespace ApiSdk.ServicePrincipals.Item.ClaimsMappingPolicies.Item {
    /// <summary>
    /// Builds and executes requests for operations under \servicePrincipals\{servicePrincipal-id}\claimsMappingPolicies\{claimsMappingPolicy-id}
    /// </summary>
    public class ClaimsMappingPolicyItemRequestBuilder : BaseCliRequestBuilder {
        /// <summary>
        /// Provides operations to manage the collection of servicePrincipal entities.
        /// </summary>
        /// <returns>A <cref="Command"></returns>
        public Command BuildRefByIdNavCommand() {
            var command = new Command("ref-by-id");
            command.Description = "Provides operations to manage the collection of servicePrincipal entities.";
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
        /// Instantiates a new <see cref="ClaimsMappingPolicyItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        public ClaimsMappingPolicyItemRequestBuilder(Dictionary<string, object> pathParameters) : base("{+baseurl}/servicePrincipals/{servicePrincipal%2Did}/claimsMappingPolicies/{claimsMappingPolicy%2Did}", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new <see cref="ClaimsMappingPolicyItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public ClaimsMappingPolicyItemRequestBuilder(string rawUrl) : base("{+baseurl}/servicePrincipals/{servicePrincipal%2Did}/claimsMappingPolicies/{claimsMappingPolicy%2Did}", rawUrl) {
        }
    }
}
