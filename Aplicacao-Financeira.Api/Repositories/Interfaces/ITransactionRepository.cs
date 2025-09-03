using Aplicacao_Financeira.Api.Models;

namespace Aplicacao_Financeira.Api.Repositories.Interfaces;

public interface ITransactionRepository
{
    Task<IEnumerable<Transaction>> GetAllByUserId(string userId);
    Task<Transaction> GetByIdAsync(int id, string userId);
    Task<Transaction> GetByDateRangeAsync(string userId, DateTime startDate, DateTime endDate);
    Task<IEnumerable<Transaction>> GetByCategoryAsync(string userId, int categoryId);
}
