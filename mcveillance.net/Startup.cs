using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(mcveillance.net.Startup))]
namespace mcveillance.net
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
