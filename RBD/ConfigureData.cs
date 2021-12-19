using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using RBD.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace RBD
{
    public static class ConfigureData
    {
        public static IServiceCollection AddData(this IServiceCollection services) => services
                .AddScoped<IGenericRepository<Material>, GenericRepository<Material>>()
                .AddScoped<IGenericRepository<MaterialCharacteristic>, GenericRepository<MaterialCharacteristic>>()
                .AddScoped<IGenericRepository<Types>, GenericRepository<Types>>()
                .AddScoped<IGenericRepository<Supplier>, GenericRepository<Supplier>>()
                .AddScoped<IGenericRepository<Warehouse>, GenericRepository<Warehouse>>()
                .AddScoped<DbContext, BuildingMaterialsContext>();
    }
}
