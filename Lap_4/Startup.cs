using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Lap_4.Startup))]
namespace Lap_4
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
