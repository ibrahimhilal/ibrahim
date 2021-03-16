using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(fırst_WebProject.Startup))]
namespace fırst_WebProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
