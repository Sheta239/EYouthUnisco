using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace EYouthUnisco.Domain.PaymobModels
{
    public class PaymentKeyResponse
    {
        [JsonProperty("token")]
        public string PaymentKey { get; init; } = default!;
    }
}
