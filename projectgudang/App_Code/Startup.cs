using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(projectgudang.Startup))]
namespace projectgudang
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
