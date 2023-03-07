using Microsoft.EntityFrameworkCore;
using webapi.DataModel;

namespace webapi.Controllers
{
    public class ClassContext :DbContext
    {
      public  DbSet <ClassTable> classTable { get; set; }

        public ClassContext(DbContextOptions<ClassContext> options ) : base (options)  { 
        
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseSqlServer("Data Source=DESKTOP-BGL6I78;Initial Catalog=DBschoolmanagementsystem;Trusted_Connection=SSPI;Encrypt=False;App=EntityFramework;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder
            .Entity<ClassTable>()
            .Property(d => d.ClassId)
            .ValueGeneratedOnAdd();

            modelBuilder
            .Entity<ClassTable>()
            .HasKey(d => d.ClassId);
        }

    }
}
