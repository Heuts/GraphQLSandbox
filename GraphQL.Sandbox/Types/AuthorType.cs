using GraphQL.Sandbox.Models;
using GraphQL.Types;

namespace GraphQL.Sandbox.Types
{
    public class AuthorType : ObjectGraphType<Author>
    {
        public AuthorType()
        {
            Name = "Author";
            Field(a => a.Id).Description("The id of the author");
            Field(a => a.FirstName).Description("First name of the author");
            Field(a => a.LastName).Description("Last name of the author");
        }
    }
}
