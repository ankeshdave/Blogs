using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BootswatchDemo.Startup))]
namespace BootswatchDemo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
