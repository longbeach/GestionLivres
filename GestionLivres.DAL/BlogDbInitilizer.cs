using GestionLivres.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionLivres.DAL
{
    public class BlogDbInitilizer : DropCreateDatabaseIfModelChanges<BlogEntitesContext>
    {
        protected override void Seed(BlogEntitesContext context)
        {
            var postseeds = new List<Post>
{
new Post{PostTitle = "Post Title 1",PostBody = "Seed Post Body 1"},
new Post{PostTitle = "Post Title 2",PostBody = "Seed post Body 2"},
new Post{PostTitle = "Post Title 3",PostBody = "Seed post Body 3"},
new Post{PostTitle = "Post Title 4",PostBody = "Seed post Body 4"},
new Post{PostTitle = "Post Title 5",PostBody = "Seed post Body 5"},
new Post{PostTitle = "Post Title 6",PostBody = "Seed post Body 6"},
new Post{PostTitle = "Post Title 7",PostBody = "Seed post Body 7"},
new Post{PostTitle = "Post Title 8",PostBody = "Seed post Body 8"}
};
            foreach (var p in postseeds)
                context.Posts.Add(p);
            context.SaveChanges();
        }
    }
}


