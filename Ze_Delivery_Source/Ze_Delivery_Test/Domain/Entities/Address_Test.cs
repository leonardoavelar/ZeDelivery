using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using Ze_Delivery_Domain.Entities;

namespace Ze_Delivery_Test.Domain.Entities
{
    [TestClass]
    public class Address_Test
    {
        [TestMethod]
        public void Instance()
        {
            string json = "{ \"type\": \"Point\", \"coordinates\": [-46.57421, -21.785741] }";

            Address address = JsonConvert.DeserializeObject<Address>(json);

            Assert.AreEqual(address.type, "Point");
            Assert.AreEqual(address.coordinates[0], -46.57421);
            Assert.AreEqual(address.coordinates[1], -21.785741);
        }
    }
}