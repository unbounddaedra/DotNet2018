using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(InClassWeek1Assignment1.Startup))]
namespace InClassWeek1Assignment1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
