using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Cinemateca.Startup))]
namespace Cinemateca
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
