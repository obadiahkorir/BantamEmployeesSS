using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BantamEmployeesSS.Startup))]
namespace BantamEmployeesSS
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
