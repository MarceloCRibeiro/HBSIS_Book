using Microsoft.EntityFrameworkCore;

namespace MvcBook.Models
{
    public class MvcBookContext : DbContext
    {
        public MvcBookContext (DbContextOptions<MvcBookContext> options)
            : base(options)
        {
        }

        public DbSet<MvcBook.Models.Book> Book { get; set; }
        
    }
}