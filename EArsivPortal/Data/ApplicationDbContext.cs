using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using YourNamespace.Models;

namespace EArsivPortal.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Belgeler> Belgeler { get; set; }
        public DbSet<FaturaTipi> FaturaTipleri { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Belgeler>()
                .HasOne(b => b.FaturaTipi)
                .WithMany(ft => ft.Belge)
                .HasForeignKey(b => b.FaturaTipiID);
        }

    }
}
