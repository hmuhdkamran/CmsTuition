using Microsoft.EntityFrameworkCore;
using webapi.DataModel;

namespace webapi.Controllers
{
    public class SubjectContext :DbContext
    {
     public DbSet<SubjectTable> SubjectTable { get; set; }

    public SubjectContext(DbContextOptions<SubjectContext> options) : base(options) 
        { 
        
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseSqlServer(" Data Source=DESKTOP-BGL6I78;Initial Catalog=DBschoolmanagementsystem;Trusted_Connection=SSPI;Encrypt=False;App=EntityFramework;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder
            .Entity<SubjectTable>()
            .Property(d => d.SubjectId)
            .ValueGeneratedOnAdd();

            modelBuilder
            .Entity<SubjectTable>()
            .HasKey(d => d.SubjectId);
        }


    }
}
