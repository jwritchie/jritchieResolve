using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(jritchieResolve.Startup))]
namespace jritchieResolve
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
