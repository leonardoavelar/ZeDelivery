using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Ze_Delivery_Domain.Entities;
using Ze_Delivery_Domain.Interfaces;
using Ze_Delivery_Infra.Database;

namespace Ze_Delivery_Test.Infra.Database
{
    [TestClass]
    public class PartnerCollection_Test
    {
        private Mock<IMongoConnection<Partner>> _mongoConnection;
        private List<Partner> _partners;
        private Partner _partner;
        private PartnerCollection _partnerCollection;

        [TestInitialize]
        public void Iniatilize_Test() 
        {
            string json = string.Empty;

            json = "[ { \"id\": \"1\", \"tradingName\": \"Adega da Cerveja - Pinheiros\", \"ownerName\": \"Zé da Silva\", \"document\": \"15.562.297/0001-56\", \"coverageArea\": { \"type\": \"MultiPolygon\", \"coordinates\": [ [ [ [30, 20], [45, 40], [10, 40], [30, 20] ] ], [ [ [15, 5], [40, 10], [10, 20], [5, 10], [15, 5] ] ] ] }, \"address\": { \"type\": \"Point\", \"coordinates\": [-46.57421, -21.785741] } }, " +
                     "{ \"id\": \"2\", \"tradingName\": \"Adega da Cerveja - Pinheiros\", \"ownerName\": \"Zé da Silva\", \"document\": \"25.562.297/0001-56\", \"coverageArea\": { \"type\": \"MultiPolygon\", \"coordinates\": [ [ [ [30, 20], [45, 40], [10, 40], [30, 20] ] ], [ [ [15, 5], [40, 10], [10, 20], [5, 10], [15, 5] ] ] ] }, \"address\": { \"type\": \"Point\", \"coordinates\": [-46.57421, -21.785741] } } ]";

            _partners = JsonConvert.DeserializeObject<List<Partner>>(json);

            json = "{ \"id\": \"1\", \"tradingName\": \"Adega da Cerveja - Pinheiros\", \"ownerName\": \"Zé da Silva\", \"document\": \"15.562.297/0001-56\", \"coverageArea\": { \"type\": \"MultiPolygon\", \"coordinates\": [ [ [ [30, 20], [45, 40], [10, 40], [30, 20] ] ], [ [ [15, 5], [40, 10], [10, 20], [5, 10], [15, 5] ] ] ] }, \"address\": { \"type\": \"Point\", \"coordinates\": [-46.57421, -21.785741] } }";

            _partner = JsonConvert.DeserializeObject<Partner>(json);

            _mongoConnection = new Mock<IMongoConnection<Partner>>();

            _mongoConnection.Setup(x => x.SelectList(It.IsAny<Expression<Func<Partner, bool>>>())).Returns(_partners);
            _mongoConnection.Setup(x => x.Select(It.IsAny<Expression<Func<Partner, bool>>>())).Returns(_partner);
            _mongoConnection.Setup(x => x.Exists(It.IsAny<Expression<Func<Partner, bool>>>())).Returns(true);
            _mongoConnection.Setup(x => x.Insert(It.IsAny<Partner>()));
            _mongoConnection.Setup(x => x.Update(It.IsAny<Expression<Func<Partner, bool>>>(), It.IsAny<Partner>()));
            _mongoConnection.Setup(x => x.Delete(It.IsAny<Expression<Func<Partner, bool>>>()));

            _partnerCollection = new PartnerCollection(_mongoConnection.Object);
        }

        [TestMethod]
        public void SelectList_Test() 
        {
            List<Partner> partners = _partnerCollection.Select();

            Assert.AreEqual(_partners, partners);
            Assert.AreEqual(_partners.Count, 2); ;

            Assert.AreEqual(_partners[0].id, "1"); ;
            Assert.AreEqual(_partners[0].tradingName, "Adega da Cerveja - Pinheiros");
            Assert.AreEqual(_partners[0].ownerName, "Zé da Silva");
            Assert.AreEqual(_partners[0].document, "15.562.297/0001-56");

            Assert.AreEqual(_partners[1].id, "2"); ;
            Assert.AreEqual(_partners[1].tradingName, "Adega da Cerveja - Pinheiros");
            Assert.AreEqual(_partners[1].ownerName, "Zé da Silva");
            Assert.AreEqual(_partners[1].document, "25.562.297/0001-56");
        }

        [TestMethod]
        public void Select_Test()
        {
            Partner partner = _partnerCollection.Select("1");

            Assert.AreEqual(_partner, partner);
            Assert.AreEqual(_partner.id, "1");
            Assert.AreEqual(_partner.tradingName, "Adega da Cerveja - Pinheiros");
            Assert.AreEqual(_partner.ownerName, "Zé da Silva");
            Assert.AreEqual(_partner.document, "15.562.297/0001-56");
        }

        [TestMethod]
        public void ExistsId_Test()
        {
            bool exists = _partnerCollection.ExistsId("1");

            Assert.AreEqual(true, exists);
        }

        [TestMethod]
        public void ExistsDocument_Test() 
        {
            bool exists = _partnerCollection.ExistsDocument("15.562.297/0001-56");

            Assert.AreEqual(true, exists);
        }
    }
}
