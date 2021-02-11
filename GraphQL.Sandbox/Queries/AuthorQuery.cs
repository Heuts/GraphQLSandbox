using GraphQL.Sandbox.Services;
using GraphQL.Sandbox.Types;
using GraphQL.Types;

namespace GraphQL.Sandbox.Queries
{
    public class AuthorQuery : ObjectGraphType
    {
        public AuthorQuery(AuthorService authorService)
        {
            int id = 0;
            Field<ListGraphType<AuthorType>>(
            name: "authors", resolve: context =>
            {
                return authorService.GetAllAuthors();
            });
            Field<AuthorType>(
                name: "author",
                arguments: new QueryArguments(new
                QueryArgument<IntGraphType>
                { Name = "id" }),
                resolve: context =>
                {
                    id = context.GetArgument<int>("id");
                    return authorService.GetAuthorById(id);
                }
            );
            Field<ListGraphType<BlogPostType>>(
                name: "blogs",
                arguments: new QueryArguments(new
                QueryArgument<IntGraphType>
                { Name = "id" }),
                resolve: context =>
                {
                    return authorService.GetPostsByAuthor(id);
                }
            );
        }
    }
}
