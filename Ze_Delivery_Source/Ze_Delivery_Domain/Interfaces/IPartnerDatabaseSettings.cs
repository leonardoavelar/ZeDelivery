namespace Ze_Delivery_Domain.Interfaces
{
    public interface IPartnerDatabaseSettings
    {
        string CollectionName { get; set; }
        string ConnectionString { get; set; }
        string DatabaseName { get; set; }
    }
}
