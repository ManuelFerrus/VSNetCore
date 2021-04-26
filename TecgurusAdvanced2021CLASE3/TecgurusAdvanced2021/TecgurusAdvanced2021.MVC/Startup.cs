using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TecgurusAdvanced2021.MVC.Startup))]
namespace TecgurusAdvanced2021.MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
