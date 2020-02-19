using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Demogit.Startup))]
namespace Demogit
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
