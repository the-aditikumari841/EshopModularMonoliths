﻿using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Catalog;

public static class CatalogModule
{
    public static IServiceCollection AddCatalogModule(this IServiceCollection services,
        IConfiguration configuration)
    {
        //Add services to the container.
        //services
        //  .AddApplicationServices()
        //  .AddInfrastructureServices(configuration)
        //  .AddApiServices(configuration);

        return services;
    }
}
