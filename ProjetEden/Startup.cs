using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ProjetEden.Startup))]
namespace ProjetEden
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
