using GestionLivres.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionLivres.DAL
{
    public  class postConfig : EntityTypeConfiguration<Post>
    {
        public postConfig()
        {
            Property(p => p.PostTitle).IsRequired().HasMaxLength(256);
            Property(p => p.PostBody).IsRequired();
        }
    }
}
