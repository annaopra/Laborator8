using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(curs8.Startup))]
namespace curs8
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
