using Anitext.Api.Models;

namespace Anitext.Api.Repositories;

public interface IQuoteRepository
{
    Task<IEnumerable<Quote>> GetAllAsync();
    Task<Quote?> GetByIdAsync(int id);
    Task<bool> CreateAsync(Quote quote);
    Task<bool> Update(Quote quote);
    Task<bool> Delete(int id);
}
