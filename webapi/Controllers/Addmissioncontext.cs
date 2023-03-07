using Microsoft.EntityFrameworkCore;
using webapi.DataModel;
using Microsoft.Extensions.Options;



namespace webapi.Controllers
{
    public class Addmissioncontext : DbContext
    {

        public DbSet<AddmissionTable> AddmissionTable { get; set; }

        public Addmissioncontext(DbContextOptions<Addmissioncontext> options) : base(options) { 
        
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(" Data Source=DESKTOP-BGL6I78;Initial Catalog=DBschoolmanagementsystem;Trusted_Connection=SSPI;Encrypt=False;App=EntityFramework; ");
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
             modelBuilder
             .Entity<AddmissionTable>()
             .Property(d => d.AddmissionId)
             .ValueGeneratedOnAdd();

            modelBuilder
            .Entity<AddmissionTable>()
            .HasKey(d => d.AddmissionId);
        }

    }
}
