using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(AmazingMicroStore.ProductMicroservice.Service.Api.Startup))]

namespace AmazingMicroStore.ProductMicroservice.Service.Api
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
