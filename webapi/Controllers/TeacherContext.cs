using Microsoft.EntityFrameworkCore;
using webapi.DataModel;

namespace webapi.Controllers
{
    public class TeacherContext : DbContext
    {
        public DbSet<TeacherTable> TeacherTable { get; set; }  

        public TeacherContext(DbContextOptions<TeacherContext> options):base(options) {
        

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-BGL6I78;Initial Catalog=DBschoolmanagementsystem;Trusted_Connection=SSPI;Encrypt=False;App=EntityFramework;");
           
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder
            .Entity<TeacherTable>()
            .Property(d => d.TeacherId)
            .ValueGeneratedOnAdd();

            modelBuilder
            .Entity<TeacherTable>()
            .HasKey(d => d.TeacherId);
        }
    }
}
