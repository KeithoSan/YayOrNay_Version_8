using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(YayOrNay.Startup))]
namespace YayOrNay
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
