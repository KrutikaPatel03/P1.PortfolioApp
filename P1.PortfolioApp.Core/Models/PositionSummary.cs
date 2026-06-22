using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace P1.PortfolioApp.Core.Models
{
    public class PositionSummary
    {
        [JsonPropertyName("instrumentName")]
        public string InstrumentName { get; set; } = string.Empty;

        [JsonPropertyName("quantity")]
        public decimal Quantity { get; set; }

        [JsonPropertyName("value")]
        public decimal Value { get; set; }
    }
}
