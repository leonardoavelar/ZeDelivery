using Newtonsoft.Json;

namespace Ze_Delivery_Domain.Entities
{
    public class ErrorDetails
    {
        public int statusCode { get; set; }

        public string message { get; set; }

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}
