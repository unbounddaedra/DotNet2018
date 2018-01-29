using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ActualLab3Part1.Startup))]
namespace ActualLab3Part1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
