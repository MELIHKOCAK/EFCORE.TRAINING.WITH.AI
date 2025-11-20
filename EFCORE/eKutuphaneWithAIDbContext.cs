using EFCORE.TRAINING.WITH.AI.EFCORE.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Reflection;

namespace EFCORE.TRAINING.WITH.AI.EFCORE
{
    public class eKutuphaneWithAIDbContext : DbContext
    {
        public eKutuphaneWithAIDbContext()
        {

        }

        public DbSet<Address> Addresses { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Library> Libraries { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Deposit> Deposits { get; set; }
        public DbSet<Author> Authors { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var config = new ConfigurationBuilder()
            .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
            .Build();
            string conString = config.GetSection("ConnectionString:SqlServer").Value.ToString();
            optionsBuilder.UseSqlServer(conString);

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
