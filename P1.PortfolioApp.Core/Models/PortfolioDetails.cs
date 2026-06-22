using System.Text.Json.Serialization;

namespace P1.PortfolioApp.Core.Models
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class Account
    {
        public string id { get; set; }
        public string name { get; set; }
        public string accountType { get; set; }
        public string currency { get; set; }
        public string wrapperType { get; set; }
        public string nodeId { get; set; }
        public string nodeName { get; set; }
        public string assetAllocationId { get; set; }
        public string status { get; set; }
        public bool recurringPayment { get; set; }
        public WrapperDetail wrapperDetail { get; set; }
        public double currentValue { get; set; }
        public int openingValue { get; set; }
        public int openingStockValue { get; set; }
        public int openingCashValue { get; set; }
        public double bookValue { get; set; }
        public int transferBookValue { get; set; }
        public double nonTransferBookValue { get; set; }
        public double growth { get; set; }
        public double adjustedGrowth { get; set; }
        public double closingCashValue { get; set; }

        [JsonPropertyName("uninvestedCash")]
        public double CashBalance { get; set; }
        public double closingStockValue { get; set; }
        public double growthPercent { get; set; }
        public double adjustedGrowthPercent { get; set; }
        public int transferValue { get; set; }
        public double allocation { get; set; }
        public List<Client> clients { get; set; }
        public CgtData cgtData { get; set; }
        public List<Disclaimer> disclaimers { get; set; }
        public string clientId { get; set; }
        public List<PortfolioGroup> portfolioGroups { get; set; }
    }

    public class CgtData
    {
        public int? realisedProfitLoss { get; set; }
        public int? unrealisedProfitLoss { get; set; }
        public double closingGiaStockValue { get; set; }
    }

    public class Client
    {
        public string id { get; set; }
        public bool isLeadClient { get; set; }
    }

    public class PortfolioDetails
    {
        [JsonPropertyName("accounts")]
        public List<Account> Accounts { get; set; }
        public string firmId { get; set; } = string.Empty;
        [JsonPropertyName("id")]
        public string ClientId { get; set; } = string.Empty;

        [JsonPropertyName("name")]
        public string ClientName { get; set; } = string.Empty;
        public string firstName { get; set; }
        public string surname { get; set; }
        public string language { get; set; }
        [JsonPropertyName("currency")]
        public string Currency { get; set; }
        public List<string> nodeId { get; set; }
        public List<string> nodeName { get; set; }
        public string status { get; set; }
        public string clientType { get; set; }

        [JsonPropertyName("positions")]
        public List<Position> Positions { get; set; }
        public List<object> completeTransactions { get; set; }
        public double bookValue { get; set; }
        public double nonTransferBookValue { get; set; }
        public int transferBookValue { get; set; }
        public int openingValue { get; set; }
        [JsonPropertyName("currentValue")]
        public double CurrentValue { get; set; }
        [JsonPropertyName("uninvestedCash")]
        public double CashBalance { get; set; }
        public double closingCashValue { get; set; }
        public double growth { get; set; }
        public double growthPercent { get; set; }
        public double adjustedGrowth { get; set; }
        public double adjustedGrowthPercent { get; set; }
        public int transferValue { get; set; }
        public CgtData cgtData { get; set; }
        public double uncrystallisedValue { get; set; }
        public List<Disclaimer> disclaimers { get; set; }

        [JsonPropertyName("products")]
        public List<Product> Products { get; set; }
    }

    public class Disclaimer
    {
        public string type { get; set; }
        public string text { get; set; }
        public List<string> fields { get; set; }
        public Entity entity { get; set; }
    }

    public class Entity
    {
        public string type { get; set; }
        public List<string> ids { get; set; }
    }

    public class PortfolioGroup
    {
        public string groupIntent { get; set; }
        public string groupType { get; set; }
        public string id { get; set; }
        public string name { get; set; }
    }

    public class Position
    {
        public string positionType { get; set; }
        public string currency { get; set; }
        public double currentValue { get; set; }
        public int openingValue { get; set; }
        public double growth { get; set; }
        public double growthPercent { get; set; }
        public double adjustedGrowth { get; set; }
        public double adjustedGrowthPercent { get; set; }
        public double allocation { get; set; }
        public string isin { get; set; }
        public string assetId { get; set; }
        public string assetName { get; set; }
        public double? quantity { get; set; }
        public double? bookValue { get; set; }
        public CgtData cgtData { get; set; }
        public int? transferBookValue { get; set; }
        public double? nonTransferBookValue { get; set; }
        public int? proportionalTransferValue { get; set; }
        public double? currentPrice { get; set; }
        public DateTime? currentPriceDate { get; set; }
        public double? minimumTransferUnit { get; set; }
    }

    public class Product
    {
        public string clientProductId { get; set; }
        public string wrapperType { get; set; }
        public int remainingSubscriptionAmount { get; set; }
    }

    public class ProductDetail
    {
        public bool flexibleBenefitsAccessed { get; set; }
        public bool pensionOptOut { get; set; }
        public int lumpSumAllowanceUsedPreApril2024 { get; set; }
        public DateTime deemedLSACalculationDate { get; set; }
    }

    public class PortfolioDetailsResponse
    {
        public PortfolioDetails data { get; set; }
    }

    public class WrapperDetail
    {
        public string wrapperType { get; set; }
        public bool discretionary { get; set; }
        public bool advised { get; set; }
        public bool trust { get; set; }
        public string assetAllocationId { get; set; }
        public string clientProductId { get; set; }
        public string assetAllocationName { get; set; }
        public string schemeProductId { get; set; }
        public string productStatus { get; set; }
        public ProductDetail productDetail { get; set; }
        public string decisionMakerId { get; set; }
    }
}
