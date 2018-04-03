using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Technines_irangos_rezervacij.Startup))]
namespace Technines_irangos_rezervacij
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
