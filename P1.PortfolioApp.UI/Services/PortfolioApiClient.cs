using P1.PortfolioApp.Core.Models;

namespace P1.PortfolioApp.UI.Services
{
    public class PortfolioApiClient
    {
        private readonly HttpClient _httpClient;

        public PortfolioApiClient(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<PortfolioSummary>> GetPortfoliosAsync()
        {
            return await _httpClient
                .GetFromJsonAsync<List<PortfolioSummary>>(
                    "api/portfolios")
                ?? [];
        }

        public async Task<PortfolioDetails> GetPortfolioAsync(
            string clientId)
        {
            return await _httpClient
                .GetFromJsonAsync<PortfolioDetails>(
                    $"api/portfolios/{clientId}")
                ?? new PortfolioDetails();
        }
    }
}
