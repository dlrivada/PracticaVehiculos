using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ClienteWebVehiculos.Startup))]
namespace ClienteWebVehiculos
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
