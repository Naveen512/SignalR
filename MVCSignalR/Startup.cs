using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCSignalR.Startup))]
namespace MVCSignalR
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
