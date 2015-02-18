using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(week5_person_app.Startup))]
namespace week5_person_app
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
