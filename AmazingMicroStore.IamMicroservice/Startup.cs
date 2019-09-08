using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AmazingMicroStore.IamMicroservice.Startup))]
namespace AmazingMicroStore.IamMicroservice
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
