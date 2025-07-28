using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Ordering
{
    public static class OrderingModule
    {
        public static IServiceCollection AddOrderingModule(this IServiceCollection services, IConfiguration configuration)
        {
            //Add services to the container;
            //services
            //  .AddApplicationServices()
            //  .AddInfrastructureSerices(configuration)
            //  .AddApiServices(configuration);
            return services;
        }
        public static IApplicationBuilder UseOrderingModule(this IApplicationBuilder app)
        {
            //app
            //  .UseApplicationServices()
            //  .UseInfrastructureSerices(configuration)
            //  .UseApiServices(configuration);
            return app;
        }
    }
}
