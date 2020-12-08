using MongoDB.Bson.Serialization.Attributes;
using System.Collections.Generic;

namespace Ze_Delivery_Domain.Entities
{
    public class Address
    {
        [BsonElement("type")]
        public string type { get; set; }

        [BsonElement("coordinates")]
        public List<double> coordinates { get; set; }
    }
}