using ApiSdk.Education.Classes.Item.Teachers.Item.Ref;
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
namespace ApiSdk.Education.Classes.Item.Teachers.Item {
    /// <summary>
    /// Builds and executes requests for operations under \education\classes\{educationClass-id}\teachers\{educationUser-id}
    /// </summary>
    public class EducationUserItemRequestBuilder : BaseCliRequestBuilder {
        /// <summary>
        /// Provides operations to manage the collection of educationRoot entities.
        /// </summary>
        public Command BuildRefNavCommand() {
            var command = new Command("ref");
            command.Description = "Provides operations to manage the collection of educationRoot entities.";
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
        /// Instantiates a new EducationUserItemRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        public EducationUserItemRequestBuilder(Dictionary<string, object> pathParameters) : base("{+baseurl}/education/classes/{educationClass%2Did}/teachers/{educationUser%2Did}", pathParameters) {
        }
    }
}
