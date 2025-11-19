using EFCORE.TRAINING.WITH.AI.EFCORE.Entity;
using Microsoft.EntityFrameworkCore;

namespace EFCORE.TRAINING.WITH.AI.EFCORE
{
    public class eKutuphaneWithAIDbContext:DbContext
    {
        public DbSet<Address> Addresses { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Library> Libraries { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Deposit> Deposits { get; set; }
        public DbSet<Author> Authors { get; set; }

    }
}
