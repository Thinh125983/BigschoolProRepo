using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BigschoolPro.Startup))]
namespace BigschoolPro
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
