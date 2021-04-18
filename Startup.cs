using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(C4DEnterpriseSys_ver1.Startup))]
namespace C4DEnterpriseSys_ver1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
