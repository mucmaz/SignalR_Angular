using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(Sing_Ang.MVC_UI.App_Start.Startup))]

namespace Sing_Ang.MVC_UI.App_Start
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.MapSignalR();
        }
    }
}
