using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ResourceGuide.Startup))]
namespace ResourceGuide
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
