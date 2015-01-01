using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GestionLivres.Web.Startup))]
namespace GestionLivres.Web
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
