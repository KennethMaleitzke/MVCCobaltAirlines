using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCCobaltAirlines.Startup))]
namespace MVCCobaltAirlines
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
