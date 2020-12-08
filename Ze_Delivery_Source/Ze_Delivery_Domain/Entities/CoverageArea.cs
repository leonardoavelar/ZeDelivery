using MongoDB.Bson.Serialization.Attributes;
using System.Collections.Generic;

namespace Ze_Delivery_Domain.Entities
{
    public class CoverageArea
    {
        [BsonElement("type")]
        public string type { get; set; }

        [BsonElement("coordinates")]
        public List<List<List<List<double>>>> coordinates { get; set; }
    }
}