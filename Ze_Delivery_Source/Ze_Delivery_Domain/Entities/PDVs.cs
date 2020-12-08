using MongoDB.Bson.Serialization.Attributes;
using System.Collections.Generic;

namespace Ze_Delivery_Domain.Entities
{
    public class PDVs
    {
        [BsonElement("pdvs")]
        public List<Partner> pdvs { get; set; }
    }
}