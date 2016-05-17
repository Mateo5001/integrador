using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TallerAppServices.Startup))]
namespace TallerAppServices
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
