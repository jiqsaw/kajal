using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Kajal.Web.Startup))]
namespace Kajal.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
