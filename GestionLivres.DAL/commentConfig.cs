using GestionLivres.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionLivres.DAL
{
    public class commentConfig : EntityTypeConfiguration<Comment>
    {
        public commentConfig()
        {
            Property(c => c.CommentAuthor).IsRequired();
            Property(c => c.CommentBody).IsRequired();
        }
    }
}
