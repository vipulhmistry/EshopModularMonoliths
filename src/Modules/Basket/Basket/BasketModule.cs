using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Basket
{
    public static class BasketModule
    {
        public static IServiceCollection AddBasketModule(this IServiceCollection services, IConfiguration configuration)
        {
            //Add services to the container;
            //services
            //  .AddApplicationServices()
            //  .AddInfrastructureSerices(configuration)
            //  .AddApiServices(configuration);
            return services;
        }

        public static IApplicationBuilder UseBasketModule(this IApplicationBuilder app)
        {
            //app
            //  .UseApplicationServices()
            //  .UseInfrastructureSerices(configuration)
            //  .UseApiServices(configuration);
            return app;
        }
    }
}
