using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Habsons.Web.Startup))]
namespace Habsons.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
