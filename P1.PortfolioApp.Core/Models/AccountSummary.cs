using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace P1.PortfolioApp.Core.Models
{
    public class AccountSummary
    {
        [JsonPropertyName("wrapper")]
        public string Wrapper { get; set; } = string.Empty;

        [JsonPropertyName("value")]
        public decimal Value { get; set; }

        [JsonPropertyName("cashBalance")]
        public decimal CashBalance { get; set; }
    }
}
