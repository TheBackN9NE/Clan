using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Clan_Website.Startup))]
namespace Clan_Website
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
