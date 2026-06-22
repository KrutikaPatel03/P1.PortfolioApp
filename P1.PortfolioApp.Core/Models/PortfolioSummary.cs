using System.Text.Json.Serialization;

namespace P1.PortfolioApp.Core.Models
{
    public class Meta
    {
        public int count { get; set; }
    }

    public class PortfolioResponse
    {
        public List<PortfolioSummary> data { get; set; }
        public Meta meta { get; set; }
    }

    public class PortfolioSummary
    {
        public string firmId { get; set; } = string.Empty;

        [JsonPropertyName("id")]
        public string ClientId { get; set; } = string.Empty;

        [JsonPropertyName("name")]
        public string ClientName { get; set; } = string.Empty;

        [JsonPropertyName("currency")]
        public string Currency { get; set; } = string.Empty;

        [JsonPropertyName("currentValue")]
        public decimal CurrentValue { get; set; }

        [JsonPropertyName("uninvestedCash")]
        public decimal CashBalance { get; set; }

        [JsonPropertyName("accounts")]
        public int Accounts { get; set; }
    }
}
