using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ContactManagerExample.Startup))]
namespace ContactManagerExample
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
