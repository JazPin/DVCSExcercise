using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DVCS_Excercise.Startup))]
namespace DVCS_Excercise
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
