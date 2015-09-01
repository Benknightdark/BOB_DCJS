using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Demo0805.Startup))]
namespace Demo0805
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            //ConfigureAuth(app);
        }
    }
}
