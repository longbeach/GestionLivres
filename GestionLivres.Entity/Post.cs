using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionLivres.Entities
{
    public class Post
    {

        public int PostId { get; set; }
        public string PostTitle { get; set; }
        public string PostBody { get; set; }
        public virtual PostMeta PostMeta { get; set; }
        public virtual ICollection<Tag> Tags { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
    }
}

