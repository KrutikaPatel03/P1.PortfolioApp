using Microsoft.Extensions.Options;
using P1.PortfolioApp.Core.Configuration;
using P1.PortfolioApp.Core.Models;
using P1.PortfolioApp.Services.Interfaces;
using System.Net.Http.Headers;
using System.Net.Http.Json;

namespace P1.PortfolioApp.Services
{
    public class SecclService : ISecclService
    {
        private readonly HttpClient _httpClient;
        private readonly SecclSettings _settings;
        private readonly TokenCache _tokenCache;
        public SecclService(
            HttpClient httpClient,
            IOptions<SecclSettings> options, TokenCache tokenCache)
        {
            _httpClient = httpClient;
            _settings = options.Value;
            _tokenCache = tokenCache;
        }

        private async Task<string> GetTokenAsync()
        {
            if (!string.IsNullOrWhiteSpace(_tokenCache.Token))
            {
                return _tokenCache.Token;
            }

            var request = new
            {
                firmId = _settings.FirmId,
                id = _settings.UserId,
                password = _settings.Password
            };

            var response = await _httpClient.PostAsJsonAsync(
                "authenticate",
                request);

            response.EnsureSuccessStatusCode();
            var responseBody = await response.Content.ReadAsStringAsync();

            var tokenResponse =
                await response.Content.ReadFromJsonAsync<TokenResponse>();

            _tokenCache.Token = tokenResponse!.Data.Token;

            return _tokenCache.Token;
        }

        public async Task<List<PortfolioSummary>> GetPortfoliosAsync()
        {
            var token = await GetTokenAsync();

            _httpClient.DefaultRequestHeaders.Authorization =
                new AuthenticationHeaderValue(
                    "Bearer",
                    token);

            var response =
                await _httpClient.GetFromJsonAsync<
                    PortfolioResponse>
                ($"/portfolio/{_settings.FirmId}");

            return response?.data?
                .Select(x => new PortfolioSummary
                {
                    ClientId = x.ClientId,
                    ClientName = x.ClientName,
                    Currency = x.Currency,
                    Accounts = x.Accounts,
                    CashBalance = x.CashBalance,
                    CurrentValue = x.CurrentValue
                })
                .ToList()
                ?? [];
        }

        public async Task<PortfolioDetails> GetPortfolioAsync(
            string clientId)
        {
            var token = await GetTokenAsync();

            _httpClient.DefaultRequestHeaders.Authorization =
                new AuthenticationHeaderValue(
                    "Bearer",
                    token);

            var response =
                await _httpClient.GetFromJsonAsync<
                    PortfolioDetailsResponse>
                ($"/portfolio/summary/{_settings.FirmId}/{clientId}");

            return response?.data?? new PortfolioDetails();
        }
    }
}
