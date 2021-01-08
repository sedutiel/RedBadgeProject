using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(IdTapThatApp.Startup))]
namespace IdTapThatApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
