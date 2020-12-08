using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using Ze_Delivery_Domain.Entities;

namespace Ze_Delivery_Test.Domain.Entities
{
    [TestClass]
    public class PDVs_Test
    {
        [TestMethod]
        public void Instance()
        {
            string json = "{ \"pdvs\": [ " +
                            "{ \"id\": \"1\", \"tradingName\": \"Adega da Cerveja - Pinheiros\", \"ownerName\": \"Zé da Silva\", \"document\": \"15.562.297/0001-56\", \"coverageArea\": { \"type\": \"MultiPolygon\", \"coordinates\": [ [ [ [30, 20], [45, 40], [10, 40], [30, 20] ] ], [ [ [15, 5], [40, 10], [10, 20], [5, 10], [15, 5] ] ] ] }, \"address\": { \"type\": \"Point\", \"coordinates\": [-46.57421, -21.785741] } }, " +
                            "{ \"id\": \"2\", \"tradingName\": \"Adega da Cerveja - Pinheiros\", \"ownerName\": \"Zé da Silva\", \"document\": \"25.562.297/0001-56\", \"coverageArea\": { \"type\": \"MultiPolygon\", \"coordinates\": [ [ [ [30, 20], [45, 40], [10, 40], [30, 20] ] ], [ [ [15, 5], [40, 10], [10, 20], [5, 10], [15, 5] ] ] ] }, \"address\": { \"type\": \"Point\", \"coordinates\": [-46.57421, -21.785741] } } " +
                          " ] } ";

            PDVs pdvs = JsonConvert.DeserializeObject<PDVs>(json);

            Assert.AreEqual(pdvs.pdvs.Count, 2); ;

            Assert.AreEqual(pdvs.pdvs[0].id, "1"); ;
            Assert.AreEqual(pdvs.pdvs[0].tradingName, "Adega da Cerveja - Pinheiros");
            Assert.AreEqual(pdvs.pdvs[0].ownerName, "Zé da Silva");
            Assert.AreEqual(pdvs.pdvs[0].document, "15.562.297/0001-56");

            Assert.AreEqual(pdvs.pdvs[1].id, "2"); ;
            Assert.AreEqual(pdvs.pdvs[1].tradingName, "Adega da Cerveja - Pinheiros");
            Assert.AreEqual(pdvs.pdvs[1].ownerName, "Zé da Silva");
            Assert.AreEqual(pdvs.pdvs[1].document, "25.562.297/0001-56");
        }
    }
}