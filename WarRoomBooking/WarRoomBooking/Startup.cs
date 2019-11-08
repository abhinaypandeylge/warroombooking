using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WarRoomBooking.Startup))]
namespace WarRoomBooking
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
