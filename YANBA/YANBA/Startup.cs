using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(YANBA.Startup))]
namespace YANBA
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
