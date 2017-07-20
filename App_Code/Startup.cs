using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ScoreAnalysis.Startup))]
namespace ScoreAnalysis
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
