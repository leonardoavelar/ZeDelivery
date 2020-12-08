using System.Collections.Generic;
using Ze_Delivery_Domain.Entities;

namespace Ze_Delivery_Domain.Interfaces
{
    public interface IPartnerCollection
    {
        List<Partner> Select();
        Partner Select(string id);
        bool ExistsId(string id);
        bool ExistsDocument(string document);
        void Insert(Partner partner);
        void Update(string id, Partner partnerIn);
        void Delete(string id);
    }
}