using GestionLivres.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionLivres.DAL
{
    public class Bloggy
    {
        private BlogEntitesContext _dB = new BlogEntitesContext();

        #region Posts
        public List<Post> Post_getAll()
        {
            try
            {
                return _dB.Posts.ToList();
            }
            catch
            {
                throw;
            }
        }
        #endregion
    }
}
