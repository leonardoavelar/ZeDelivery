using System.Collections.Generic;
using Ze_Delivery_Domain.Entities;
using Ze_Delivery_Domain.Interfaces;

namespace Ze_Delivery_Infra.Database
{
    public class PartnerCollection : IPartnerCollection
    {
        private IMongoConnection<Partner> _mongoConnection;

        public PartnerCollection(IMongoConnection<Partner> mongoConnection)
        {
            _mongoConnection = mongoConnection;
        }

        public List<Partner> Select() =>
            _mongoConnection.SelectList(partner => true);

        public Partner Select(string id) =>
            _mongoConnection.Select(x => x.id == id);

        public bool ExistsId(string id) =>
            _mongoConnection.Exists(p => p.id == id);

        public bool ExistsDocument(string document) =>
            _mongoConnection.Exists(p => p.document == document);

        public void Insert(Partner partner) =>
            _mongoConnection.Insert(partner);

        public void Update(string id, Partner partnerIn) =>
            _mongoConnection.Update(p => p.id == id, partnerIn);

        public void Delete(string id) =>
            _mongoConnection.Delete(p => p.id == id);
    }
}
