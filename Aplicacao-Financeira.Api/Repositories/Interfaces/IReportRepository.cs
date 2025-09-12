using Aplicacao_Financeira.Api.Models;

namespace Aplicacao_Financeira.Api.Repositories.Interfaces;

public interface IReportRepository
{
    Task<Report> GetMonthReportAsync(string userId, int month, int year);
    Task<IEnumerable<Report>> GetYearlyReportsAsync(string userId, int year);
    Task<Report> CreateOrUpdateMonthlyReportAsync(Report report);
}
