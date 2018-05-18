using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LibraryMgmtApp.Startup))]
namespace LibraryMgmtApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
