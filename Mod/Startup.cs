using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Mod.Startup))]
namespace Mod
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
