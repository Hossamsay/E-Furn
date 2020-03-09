using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(E_Furn.Startup))]
namespace E_Furn
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
