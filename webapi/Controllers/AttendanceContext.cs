using Microsoft.EntityFrameworkCore;
using webapi.DataModel;

namespace webapi.Controllers
{
    public class AttendanceContext:DbContext
    {
     public   DbSet<AttandanceTable> attandanceTable { get; set; }

        public AttendanceContext(DbContextOptions<AttendanceContext> options) : base(options) { 
        
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-BGL6I78;Initial Catalog=DBschoolmanagementsystem;Trusted_Connection=SSPI;Encrypt=False;App=EntityFramework;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder
            .Entity<AttandanceTable>()
            .Property(d => d.AttendanceId)
            .ValueGeneratedOnAdd();

            modelBuilder
            .Entity<AttandanceTable>()
            .HasKey(d => d.AttendanceId);
        }

    }
}
