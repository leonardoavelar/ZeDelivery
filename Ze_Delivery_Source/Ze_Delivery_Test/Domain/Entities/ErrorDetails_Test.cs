using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ze_Delivery_Domain.Entities;

namespace Ze_Delivery_Test.Domain.Entities
{
    [TestClass]
    public class ErrorDetails_Test
    {
        [TestMethod]
        public void Instance()
        {
            ErrorDetails errorDetails = new ErrorDetails();
            errorDetails.statusCode = 200;
            errorDetails.message = "Teste";

            string json = "{\"statusCode\":200,\"message\":\"Teste\"}";

            Assert.AreEqual(errorDetails.statusCode, 200);
            Assert.AreEqual(errorDetails.message, "Teste");
            Assert.AreEqual(errorDetails.ToString(), json);
        }
    }
}