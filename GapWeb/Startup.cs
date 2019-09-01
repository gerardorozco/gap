using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GapWeb.Startup))]
namespace GapWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
