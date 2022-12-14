using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SolutionExplorer_aspnet_mvc.Startup))]
namespace SolutionExplorer_aspnet_mvc
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
