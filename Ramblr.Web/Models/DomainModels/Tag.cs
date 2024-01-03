namespace Ramblr.Web.Models.DomainModels
{
    public class Tag
    {

        //one blog post can have multiple tags, and one tag can have multiple blog posts attached to it (many to many)


        //props
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string DisplayName { get; set; }

        //navigation property to tell the framework that a
        //tag can have multiple blog posts, this defines the relationship between blog posts and tags
        public ICollection<BlogPost> BlogPosts { get; set; }
    }
}
