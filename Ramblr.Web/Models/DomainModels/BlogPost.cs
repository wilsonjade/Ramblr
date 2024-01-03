namespace Ramblr.Web.Models.DomainModels
{
    public class BlogPost
    {
        //one blog post can have multiple tags, and one tag can have multiple blog posts attached to it (many to many)

        //props
        public Guid Id { get; set; } //guid is a unique identifier
        public string Heading { get; set; }
        public string PageTitle { get; set; }
        public string Content { get; set; }
        public string ShortDescription { get; set; }
        public string FeaturedImageUrl { get; set; }
        public string UrlHandle { get; set; }
        public DateTime PublishedDate { get; set; }
        public string Author { get; set; }
        public bool Visible { get; set; }

        //navigation property to tell the framework
        //that the blog posts can have multiple tags, this defines the relationship between blog posts and tags
        public ICollection<Tag> Tags { get; set; }


        //constructor 
    }
}
