using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TDD_01.Startup))]
namespace TDD_01
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
