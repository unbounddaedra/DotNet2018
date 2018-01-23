using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Lab3Part1.Startup))]
namespace Lab3Part1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
