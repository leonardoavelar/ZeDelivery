using System.Collections.Generic;
using Ze_Delivery_Domain.Entities;

namespace Ze_Delivery_Domain.Interfaces
{
    public interface IPartnerService
    {
        List<Partner> Select();
        Partner Select(string id);
        void Insert(PDVs pdvs);
        void Insert(Partner partner);
        void Update(string id, Partner partner);
        void Delete(string id);
    }
}