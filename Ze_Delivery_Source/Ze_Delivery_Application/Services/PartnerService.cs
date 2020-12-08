using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Ze_Delivery_Domain.Entities;
using Ze_Delivery_Domain.Interfaces;

namespace Ze_Delivery_Application.Services
{
    public class PartnerService : IPartnerService
    {
        private readonly IPartnerCollection _partnerCollection;

        public PartnerService(IPartnerCollection partnerCollection)
        {
            _partnerCollection = partnerCollection;
        }

        public List<Partner> Select() =>
           _partnerCollection.Select();

        public Partner Select(string id) =>
            _partnerCollection.Select(id);

        public void Insert(PDVs pdvs)
        {
            foreach (Partner partner in pdvs.pdvs)
                this.Insert(partner);
        }

        public void Insert(Partner partner)
        {
            bool existsId = _partnerCollection.ExistsId(partner.id);
            bool existsDocument = _partnerCollection.ExistsDocument(partner.document);

            if (existsId)
                throw new ValidationException("Código já cadastrado!");
            else if (existsId)
                throw new ValidationException("Documento já cadastrado!");
            else
                _partnerCollection.Insert(partner);
        }

        public void Update(string id, Partner partnerIn) =>
            _partnerCollection.Update(id, partnerIn);

        public void Delete(string id) =>
            _partnerCollection.Delete(id);
    }
}