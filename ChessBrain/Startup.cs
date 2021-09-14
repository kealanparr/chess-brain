using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ChessBrain.Startup))]
namespace ChessBrain
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
