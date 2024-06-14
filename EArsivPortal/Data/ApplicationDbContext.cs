using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using EArsivPortal.Models;
using YourNamespace.Models;

namespace EArsivPortal.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Belge> Belgeler { get; set; }
        public DbSet<FaturaTipi> FaturaTipleri { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<FaturaTipi>().HasData(
                new FaturaTipi { FaturaTipiID = 1, Tip = "Satış" },
                new FaturaTipi { FaturaTipiID = 2, Tip = "Genel İade" },
                new FaturaTipi { FaturaTipiID = 3, Tip = "İstisna" },
                new FaturaTipi { FaturaTipiID = 4, Tip = "Konaklama Vergisi" },
                new FaturaTipi { FaturaTipiID = 5, Tip = "Tevfikat" }
            );
        }
    }
}
