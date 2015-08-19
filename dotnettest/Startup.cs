using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(dotnettest.Startup))]
namespace dotnettest
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
