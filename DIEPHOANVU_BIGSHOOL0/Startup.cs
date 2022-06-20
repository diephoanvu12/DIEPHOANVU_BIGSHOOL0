using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DIEPHOANVU_BIGSHOOL0.Startup))]
namespace DIEPHOANVU_BIGSHOOL0
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
