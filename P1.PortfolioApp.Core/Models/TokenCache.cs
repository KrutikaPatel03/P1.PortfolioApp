namespace P1.PortfolioApp.Core.Models
{
    public class TokenCache
    {
        public string Token { get; set; } = string.Empty;

        public DateTime ExpirationTime { get; set; }
    }
}
