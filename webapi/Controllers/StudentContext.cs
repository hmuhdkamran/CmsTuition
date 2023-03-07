using Microsoft.EntityFrameworkCore;
using webapi.DataModel;

namespace webapi.Controllers
{
    public class StudentContext :DbContext
    {
     public DbSet<StudentTable> StudentTable { get; set; }
    
     public StudentContext(DbContextOptions<StudentContext> options):base (options) { 
        
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseSqlServer("Data Source=DESKTOP-BGL6I78;Initial Catalog=DBschoolmanagementsystem;Trusted_Connection=SSPI;Encrypt=False;App=EntityFramework;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder
         .Entity<StudentTable>()
         .Property(d => d.StudentId)
         .ValueGeneratedOnAdd();

            modelBuilder
            .Entity<StudentTable>()
            .HasKey(d => d.StudentId);
        }

    }
}
