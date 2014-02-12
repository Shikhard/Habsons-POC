using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CommonAppDemo.Startup))]
namespace CommonAppDemo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
