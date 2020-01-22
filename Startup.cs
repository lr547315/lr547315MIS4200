using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(lr547315MIS4200.Startup))]
namespace lr547315MIS4200
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
