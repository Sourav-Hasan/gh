using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Sourav.Startup))]
namespace Sourav
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
