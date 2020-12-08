using MongoDB.Bson.Serialization.Attributes;
using System.Collections.Generic;

namespace Ze_Delivery_Domain.Entities
{
    public class ListPartners
    {
        [BsonElement("")]
        public List<Partner> partners { get; set; }
    }
}
