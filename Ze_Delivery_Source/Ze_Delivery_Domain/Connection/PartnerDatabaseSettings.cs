using Ze_Delivery_Domain.Interfaces;

namespace Ze_Delivery_Domain.Connection
{
    public class PartnerDatabaseSettings : IPartnerDatabaseSettings
    {
        public string CollectionName { get; set; }
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
    }
}
