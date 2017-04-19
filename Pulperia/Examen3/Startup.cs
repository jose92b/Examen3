using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Examen3.Startup))]
namespace Examen3
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
