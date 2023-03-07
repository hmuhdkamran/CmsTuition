using Microsoft.EntityFrameworkCore;
using webapi.DataModel;

namespace webapi.Controllers
{
    public class ExamContext:DbContext
    {
        public DbSet<ExamTable> ExamTable { get; set; }

        public ExamContext(DbContextOptions<ExamContext> options):  base(options) {
        
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-BGL6I78;Initial Catalog=DBschoolmanagementsystem;Trusted_Connection=SSPI;Encrypt=False;App=EntityFramework;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder
            .Entity<ExamTable>()
            .Property(d => d.ExamID)
            .ValueGeneratedOnAdd();

            modelBuilder
            .Entity<ExamTable>()
            .HasKey(d => d.ExamID);
        }


    }
}
