using Microsoft.EntityFrameworkCore;
using Avengers.Domain.Shops;

namespace Avengers.Infra.Data
{
    public class ApplicationDbContext : DbContext
    {

        public DbSet<Domain.Users> InfoUser { get; set; }
        public DbSet<Domain.Users> WalletUser { get; set; }
        public DbSet<Domain.Shops> InfoShop { get; set; }
        public DbSet<Domain.Shops> WalletShop { get; set; }
        
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            
        }

        protected override void ConfigureConventions(ModelConfigurationBuilder configuration)
        {
            configuration.Properties<string>()
                .HaveMaxLength(100);
        }
    }
}
