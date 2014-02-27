using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(keys.Startup))]
namespace keys
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
