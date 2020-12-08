using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Ze_Delivery_Domain.Entities
{
    public class Partner
    {
        [BsonId]
        [BsonRepresentation(BsonType.String)]
        [BsonElement("id")]
        public string id { get; set; }

        [BsonElement("tradingName")]
        public string tradingName { get; set; }

        [BsonElement("ownerName")]
        public string ownerName { get; set; }

        [BsonElement("document")] 
        public string document { get; set; }

        [BsonElement("coverageArea")]
        public CoverageArea coverageArea { get; set; }

        [BsonElement("address")]
        public Address address { get; set; }
    }
}