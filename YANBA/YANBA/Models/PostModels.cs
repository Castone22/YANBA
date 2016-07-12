using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace YANBA.Models
{
    public class Post
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime LastUpdated { get; set; }
        public string Author { get; set; }
        public string Content { get; set; }
    }

    public class PostDBContext : DbContext
    {
        public DbSet<Post> Posts { get; set; }
    }
}