using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Week1InClassAssignment2.Startup))]
namespace Week1InClassAssignment2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
