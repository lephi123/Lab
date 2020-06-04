using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Lephi_lab456.Startup))]
namespace Lephi_lab456
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
