using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(myproject_NVIT.Startup))]
namespace myproject_NVIT
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
