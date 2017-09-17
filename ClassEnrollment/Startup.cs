using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ClassEnrollment.Startup))]
namespace ClassEnrollment
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
