using GraphQL.Sandbox.Models;
using GraphQL.Types;

namespace GraphQL.Sandbox.Types
{
    public class BlogPostType : ObjectGraphType<BlogPost>
    {
        public BlogPostType()
        {
            Name = "BlogPost";
            Field(b => b.Id, type: typeof(IdGraphType)).Description("The id of the blog post");
            Field(b => b.Title).Description("The title of the blog post");
            Field(b => b.Content).Description("The content of the blog post");
        }
    }
}
