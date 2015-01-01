using GestionLivres.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionLivres.DAL
{
    public class BlogEntitesContext : DbContext
    {
        public DbSet<Post> Posts { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<PostMeta> PostMetas { get; set; }
        public DbSet<Tag> Tags { get; set; }
       
        
         protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new postConfig());
            modelBuilder.Configurations.Add(new commentConfig());
        }
         
    }
}
