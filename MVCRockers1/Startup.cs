using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCRockers1.Startup))]
namespace MVCRockers1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
