using GestionLivres.DAL;
using GestionLivres.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionLivres
{
   public class BloggyBL
    {
        private Bloggy _dL = new Bloggy();

        #region Posts
        public List<Post> Post_getAll()
        {
            try
            {
                return _dL.Post_getAll();
            }
            catch
            {
                throw;
            }
        }
        #endregion
    }
}
