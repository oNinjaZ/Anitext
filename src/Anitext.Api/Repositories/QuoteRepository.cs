using Anitext.Api.Models;

namespace Anitext.Api.Repositories;

public class QuoteRepository : IQuoteRepository
{
    public Task<bool> CreateAsync(Quote quote)
    {
        throw new NotImplementedException();
    }

    public Task<bool> Delete(int id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Quote>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<Quote?> GetByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<bool> Update(Quote quote)
    {
        throw new NotImplementedException();
    }
}
