namespace P1.PortfolioApp.Core.Models
{
    public class ApiResult<T>
    {
        public bool Success { get; init; }

        public string Message { get; init; } = string.Empty;

        public T? Data { get; init; }
    }
}
