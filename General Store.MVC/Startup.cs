using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(General_Store.MVC.Startup))]
namespace General_Store.MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
