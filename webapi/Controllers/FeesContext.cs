using Microsoft.EntityFrameworkCore;
using webapi.DataModel;

namespace webapi.Controllers
{
    public class FeesContext : DbContext
    {
     public DbSet<FeesTable> FeesTable { get; set; }

    public FeesContext(DbContextOptions<FeesContext> option) : base(option) {
        
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseSqlServer("Data Source=DESKTOP-BGL6I78;Initial Catalog=DBschoolmanagementsystem;Trusted_Connection=SSPI;Encrypt=False;App=EntityFramework;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder
          .Entity<FeesTable>()
          .Property(d => d.FeesId)
          .ValueGeneratedOnAdd();

            modelBuilder
            .Entity<FeesTable>()
            .HasKey(d => d.FeesId);
        }


    }
}
