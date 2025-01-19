using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(IT_PROJECT.Startup))]
namespace IT_PROJECT
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
