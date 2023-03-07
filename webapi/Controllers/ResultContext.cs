using Microsoft.EntityFrameworkCore;
using webapi.DataModel;

namespace webapi.Controllers
{
    public class ResultContext:DbContext
    {
        public DbSet<ResultTable> ResultTable { get; set; }

        public ResultContext(DbContextOptions<ResultContext> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-BGL6I78;Initial Catalog=DBschoolmanagementsystem;Trusted_Connection=SSPI;Encrypt=False;App=EntityFramework;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder
            .Entity<ResultTable>()
            .Property(d => d.ResultId)
            .ValueGeneratedOnAdd();

            modelBuilder
            .Entity<ResultTable>()
            .HasKey(d => d.ResultId);
        }
    }
}
