using BooksStoreupdated.Models;

namespace BooksStoreupdated.Repository
{
    public interface IBooksRepository
    {
        Task<List<BookModel>> GetAllBooksAsync();
    }
}
