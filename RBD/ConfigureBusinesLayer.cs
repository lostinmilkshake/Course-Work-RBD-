using Microsoft.Extensions.DependencyInjection;
using RBD.BusinesLogic;
using RBD.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace RBD
{
    public static class ConfigureBusinesLayer
    {
        public static IServiceCollection AddBusinesLayer(this IServiceCollection services) => services
                .AddScoped<BusinesLogic.IGenericService<Material>, GenericService<Material>>()
                .AddScoped<BusinesLogic.IGenericService<MaterialCharacteristic>, GenericService<MaterialCharacteristic>>()
                .AddScoped<BusinesLogic.IGenericService<Types>, GenericService<Types>>()
                .AddScoped<BusinesLogic.IGenericService<Supplier>, GenericService<Supplier>>()
                .AddScoped<BusinesLogic.IGenericService<Warehouse>, GenericService<Warehouse>>();
    }
}
