using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(KillerAppAbdoAryanzad.Startup))]
namespace KillerAppAbdoAryanzad
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
