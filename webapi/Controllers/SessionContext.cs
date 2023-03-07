using Microsoft.EntityFrameworkCore;
using webapi.DataModel;

namespace webapi.Controllers
{
    public class SessionContext: DbContext
    {
        public DbSet<SessionTable> SessionTable { get; set; }

        public SessionContext(DbContextOptions<SessionContext> options) : base(options) { 
        
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseSqlServer(" Data Source=DESKTOP-BGL6I78;Initial Catalog=DBschoolmanagementsystem;Trusted_Connection=SSPI;Encrypt=False;App=EntityFramework;");
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder
            .Entity<SessionTable>()
            .Property(d => d.SessionId)
            .ValueGeneratedOnAdd();

            modelBuilder
            .Entity<SessionTable>()
            .HasKey(d => d.SessionId);
        }

    }
}
