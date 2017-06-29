using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PracticeASp.Startup))]
namespace PracticeASp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
