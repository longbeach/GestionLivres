using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GestionLivres.Web
{
    public partial class DisplayPosts : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void DisplayPost_Click(object sender, EventArgs e)
        {
            BloggyBL _bL = new BloggyBL();
            postsresult.DataSource = _bL.Post_getAll();
            postsresult.DataBind();
        }    
    }
}