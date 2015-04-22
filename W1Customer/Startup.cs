using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(W1Customer.Startup))]
namespace W1Customer
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
