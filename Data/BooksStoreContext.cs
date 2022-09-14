using Microsoft.EntityFrameworkCore;

namespace BooksStoreupdated.Data
{
    public class BooksStoreContext : DbContext

    {
        public BooksStoreContext(DbContextOptions<BooksStoreContext> options)
        : base(options)

        {

        }
        // a table will be created in database having name Books it must be same as your class name you created table name == class name
        //in context class we have to tell we are using Books class so we have to pass it in DbSet
        public DbSet<Books> Books { get; set; }
        public DbSet <Authors> Authors{ get; set; }

        //code first approach creating database through code
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer("Server = ., Database=BooksStoreApi , integrated Security = true");
        //    base.OnConfiguring(optionsBuilder);
        //}
    }
}
