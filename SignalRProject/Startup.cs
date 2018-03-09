using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SignalRProject.Startup))]
namespace SignalRProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
