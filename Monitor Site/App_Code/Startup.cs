using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Monitor_Site.Startup))]
namespace Monitor_Site
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
