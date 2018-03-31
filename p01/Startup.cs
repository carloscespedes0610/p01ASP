using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(p01.Startup))]
namespace p01
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
