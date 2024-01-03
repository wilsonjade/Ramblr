using Microsoft.EntityFrameworkCore;
using Ramblr.Web.Models.DomainModels;

namespace Ramblr.Web.Data
{
    public class RamblrDbContext : DbContext
    {
        //constructor, shortcut (ctrl .) used on RamblrDbContext class name above, select create constructor with options
        public RamblrDbContext(DbContextOptions options) : base(options)
        {
        }


        //props
        public DbSet<BlogPost> BlogPosts { get; set; }
        public DbSet<Tag> Tags { get; set; }

    }
}
