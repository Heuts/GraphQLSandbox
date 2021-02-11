using System;
using GraphQL.Sandbox.Queries;
using GraphQL.Sandbox.Services;
using GraphQL.Types;

namespace GraphQL.Sandbox.Controllers
{
    public class GraphQLSandboxSchema : Schema
    {
        public GraphQLSandboxSchema(AuthorService authorService, IServiceProvider provider) : base(provider)
        {
            Query = new AuthorQuery(authorService);
        }
    }
}
