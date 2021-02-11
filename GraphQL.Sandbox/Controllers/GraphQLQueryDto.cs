
using Newtonsoft.Json.Linq;

namespace GraphQL.Sandbox.Controllers
{
    public class GraphQLQueryDto
    {
        public string OperationName { get; set; }
        public string NamedQuery { get; set; }
        public string Query { get; set; }
        public JObject Variables { get; set; }
    }
}
