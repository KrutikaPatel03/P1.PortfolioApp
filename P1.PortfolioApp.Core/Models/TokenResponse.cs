using System.Text.Json.Serialization;

namespace P1.PortfolioApp.Core.Models
{
    public class TokenResponse
    {
        [JsonPropertyName("data")]
        public AuthenticateData Data { get; set; } = new();
    }
    public class AuthenticateData
    {
        [JsonPropertyName("token")]
        public string Token { get; set; } = string.Empty;

        [JsonPropertyName("userName")]
        public string UserName { get; set; } = string.Empty;

        [JsonPropertyName("userType")]
        public string UserType { get; set; } = string.Empty;

        [JsonPropertyName("services")]
        public List<string> Services { get; set; } = [];
    }
}
