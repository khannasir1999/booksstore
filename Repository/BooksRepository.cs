using BooksStoreupdated.Data;
using BooksStoreupdated.Models;
using Microsoft.EntityFrameworkCore;

namespace BooksStoreupdated.Repository
{
    public class BooksRepository : IBooksRepository
    {
        private readonly BooksStoreContext _context;

        public BooksRepository(BooksStoreContext context)
        {
            _context = context;
        }
        public async Task<List<BookModel>>GetAllBooksAsync()
        {
            
            var records = await _context.Books.Select(x =>new BookModel(){
                id = x.id,
                title = x.title,
                name = x.name,
            }).ToListAsync();
            return records;
        }
    }
}
