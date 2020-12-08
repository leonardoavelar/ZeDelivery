using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using Ze_Delivery_Domain.Entities;

namespace Ze_Delivery_Test.Domain.Entities
{
    [TestClass]
    public class CoverageArea_Test
    {
        [TestMethod]
        public void Instance()
        {
            string json = "{ \"type\": \"MultiPolygon\", \"coordinates\": [ [[[30, 20], [45, 40], [10, 40], [30, 20]]], [[[15, 5], [40, 10], [10, 20], [5, 10], [15, 5]]] ] }";

            CoverageArea coverageArea = JsonConvert.DeserializeObject<CoverageArea>(json);

            Assert.AreEqual(coverageArea.type, "MultiPolygon");
            Assert.AreEqual(coverageArea.coordinates[0][0][0][0], 30);
            Assert.AreEqual(coverageArea.coordinates[0][0][0][1], 20);
            Assert.AreEqual(coverageArea.coordinates[0][0][1][0], 45);
            Assert.AreEqual(coverageArea.coordinates[0][0][1][1], 40);
            Assert.AreEqual(coverageArea.coordinates[1][0][0][0], 15);
            Assert.AreEqual(coverageArea.coordinates[1][0][0][1], 5);
            Assert.AreEqual(coverageArea.coordinates[1][0][1][0], 40);
            Assert.AreEqual(coverageArea.coordinates[1][0][1][1], 10);
        }
    }
}
