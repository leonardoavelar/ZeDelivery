using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using Ze_Delivery_Domain.Entities;

namespace Ze_Delivery_Test.Domain.Entities
{
    [TestClass]
    public class Partner_Test
    {
        [TestMethod]
        public void Instance()
        {
            string json = "{ \"id\": \"1\", \"tradingName\": \"Adega da Cerveja - Pinheiros\", \"ownerName\": \"Zé da Silva\", \"document\": \"15.562.297/0001-56\", \"coverageArea\": { \"type\": \"MultiPolygon\", \"coordinates\": [ [ [ [30, 20], [45, 40], [10, 40], [30, 20] ] ], [ [ [15, 5], [40, 10], [10, 20], [5, 10], [15, 5] ] ] ] }, \"address\": { \"type\": \"Point\", \"coordinates\": [-46.57421, -21.785741] } }";

            Partner partner = JsonConvert.DeserializeObject<Partner>(json);

            Assert.AreEqual(partner.id, "1");
            Assert.AreEqual(partner.tradingName, "Adega da Cerveja - Pinheiros");
            Assert.AreEqual(partner.ownerName, "Zé da Silva");
            Assert.AreEqual(partner.document, "15.562.297/0001-56");
        }
    }
}