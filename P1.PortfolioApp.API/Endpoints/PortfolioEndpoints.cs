using P1.PortfolioApp.Services.Interfaces;

namespace P1.PortfolioApp.API.Endpoints
{
    public static class PortfolioEndpoints
    {
        public static IEndpointRouteBuilder MapPortfolioEndpoints(
            this IEndpointRouteBuilder app)
        {
            app.MapGet(
                "/api/portfolios",
                async (
                    ISecclService service) =>
                {
                    var portfolios =
                        await service.GetPortfoliosAsync();

                    return Results.Ok(portfolios);
                });

            app.MapGet(
                "/api/portfolios/{clientId}",
                async (
                    string clientId,
                    ISecclService service) =>
                {
                    var portfolio =
                        await service.GetPortfolioAsync(clientId);

                    return Results.Ok(portfolio);
                });

            return app;
        }
    }
}
