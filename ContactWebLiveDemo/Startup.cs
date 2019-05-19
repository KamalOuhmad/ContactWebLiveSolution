using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ContactWebLiveDemo.Startup))]
namespace ContactWebLiveDemo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
