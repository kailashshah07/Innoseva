using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(innoseva.Startup))]
namespace innoseva
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
