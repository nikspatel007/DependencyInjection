using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DependencyInjection.Web.Startup))]
namespace DependencyInjection.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
