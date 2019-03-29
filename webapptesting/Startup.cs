using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(webapptesting.Startup))]
namespace webapptesting
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
