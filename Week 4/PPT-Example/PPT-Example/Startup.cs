using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PPT_Example.Startup))]
namespace PPT_Example
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
