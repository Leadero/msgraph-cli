// <auto-generated/>
using ApiSdk.Education.Classes.Item.Assignments.Item.Categories.Item.Ref;
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
namespace ApiSdk.Education.Classes.Item.Assignments.Item.Categories.Item {
    /// <summary>
    /// Builds and executes requests for operations under \education\classes\{educationClass-id}\assignments\{educationAssignment-id}\categories\{educationCategory-id}
    /// </summary>
    public class EducationCategoryItemRequestBuilder : BaseCliRequestBuilder {
        /// <summary>
        /// Provides operations to manage the collection of educationRoot entities.
        /// </summary>
        /// <returns>A <cref="Command"></returns>
        public Command BuildRefByIdNavCommand() {
            var command = new Command("ref-by-id");
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
        /// Instantiates a new <see cref="EducationCategoryItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        public EducationCategoryItemRequestBuilder(Dictionary<string, object> pathParameters) : base("{+baseurl}/education/classes/{educationClass%2Did}/assignments/{educationAssignment%2Did}/categories/{educationCategory%2Did}", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new <see cref="EducationCategoryItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public EducationCategoryItemRequestBuilder(string rawUrl) : base("{+baseurl}/education/classes/{educationClass%2Did}/assignments/{educationAssignment%2Did}/categories/{educationCategory%2Did}", rawUrl) {
        }
    }
}
