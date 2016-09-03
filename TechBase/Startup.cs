using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TechBase.Startup))]
namespace TechBase
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
