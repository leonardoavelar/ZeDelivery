using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ze_Delivery_Domain.Connection;

namespace Ze_Delivery_Test.Domain.Connection
{
    [TestClass]
    public class PartnerDatabaseSettings_Test
    {
        
        [TestMethod]
        public void Instance()
        {
            PartnerDatabaseSettings partnerDatabaseSettings = new PartnerDatabaseSettings();

            partnerDatabaseSettings.CollectionName = "value1";
            partnerDatabaseSettings.ConnectionString = "value2";
            partnerDatabaseSettings.DatabaseName = "value3";


            Assert.AreEqual(partnerDatabaseSettings.CollectionName, "value1");
            Assert.AreEqual(partnerDatabaseSettings.ConnectionString, "value2");
            Assert.AreEqual(partnerDatabaseSettings.DatabaseName, "value3");
        }
}
}
