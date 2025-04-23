using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Dobavki.Data
{
    public class ApplicationDbContext : IdentityDbContext<User>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)            
        {
        }

        public DbSet<TypeProduct> TypeProducts { get; set; }

        public DbSet<Order> Orders { get; set; }

        public DbSet<Categorie> Categories { get; set; }

        public DbSet<Product> Products { get; set; }
    }
}
