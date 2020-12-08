using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Ze_Delivery_Application.Services;
using Ze_Delivery_Domain.Connection;
using Ze_Delivery_Domain.Entities;
using Ze_Delivery_Domain.Interfaces;
using Ze_Delivery_Infra.Database;

namespace Ze_Delivery_DI
{
    public class DependencyInjection
    {
        private IServiceCollection _services;

        public DependencyInjection(IServiceCollection services)
        {
            _services = services;
        }

        public void ConfigureServices()
        {
            _services.AddSingleton<IMongoConnection<Partner>, MongoConnection<Partner>>();

            _services.AddSingleton<IPartnerCollection, PartnerCollection>();

            _services.AddSingleton<IPartnerDatabaseSettings>(sp =>
                sp.GetRequiredService<IOptions<PartnerDatabaseSettings>>().Value);
            
            _services.AddSingleton<IPartnerService, PartnerService>();
        }
    }
}
