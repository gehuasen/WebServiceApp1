using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebServiceApp1.Startup))]
namespace WebServiceApp1
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
