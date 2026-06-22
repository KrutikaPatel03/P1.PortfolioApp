using P1.PortfolioApp.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace P1.PortfolioApp.Services.Interfaces
{
    public interface ISecclService
    {
        Task<List<PortfolioSummary>> GetPortfoliosAsync();

        Task<PortfolioDetails> GetPortfolioAsync(
            string clientId);
    }
}
