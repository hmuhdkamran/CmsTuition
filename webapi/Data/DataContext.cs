using Microsoft.EntityFrameworkCore;
using webapi.Data.DataModel;
using webapi.DataModel;

namespace webapi.Data
{
    public class DataContext : DbContext
    {
        public DbSet<AddmissionTable> AddmissionTable { get; set; }
        public DbSet<AttandanceTable> attandanceTable { get; set; }
        public DbSet<ClassTable> classTable { get; set; }
        public DbSet<ExamTable> ExamTable { get; set; }
        public DbSet<FeesTable> FeesTable { get; set; }
        public DbSet<ResultTable> ResultTable { get; set; }
        public DbSet<SessionTable> SessionTable { get; set; }
        public DbSet<StudentTable> StudentTable { get; set; }
        public DbSet<SubjectTable> SubjectTable { get; set; }
        public DbSet<TeacherTable> TeacherTable { get; set; }



        public DataContext(DbContextOptions<DataContext> options) : base(options)
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
             .Entity<AddmissionTable>()
             .Property(d => d.AddmissionId)
             .ValueGeneratedOnAdd();

             modelBuilder
             .Entity<AddmissionTable>()
             .HasKey(d => d.AddmissionId);

             modelBuilder
             .Entity<AttandanceTable>()
             .Property(d => d.AttendanceId)
             .ValueGeneratedOnAdd();

             modelBuilder
            .Entity<AttandanceTable>()
            .HasKey(d => d.AttendanceId);

             modelBuilder
            .Entity<ClassTable>()
            .Property(d => d.ClassId)
            .ValueGeneratedOnAdd();

             modelBuilder
            .Entity<ClassTable>()
            .HasKey(d => d.ClassId);

             modelBuilder
            .Entity<ExamTable>()
            .Property(d => d.ExamID)
            .ValueGeneratedOnAdd();

             modelBuilder
            .Entity<ExamTable>()
            .HasKey(d => d.ExamID);

             modelBuilder
            .Entity<FeesTable>()
            .Property(d => d.FeesId)
            .ValueGeneratedOnAdd();

             modelBuilder
            .Entity<FeesTable>()
            .HasKey(d => d.FeesId);

             modelBuilder
            .Entity<ResultTable>()
            .Property(d => d.ResultId)
            .ValueGeneratedOnAdd();

             modelBuilder
            .Entity<ResultTable>()
            .HasKey(d => d.ResultId);

             modelBuilder
            .Entity<SessionTable>()
            .Property(d => d.SessionId)
            .ValueGeneratedOnAdd();

             modelBuilder
            .Entity<SessionTable>()
            .HasKey(d => d.SessionId);

             modelBuilder
            .Entity<StudentTable>()
            .Property(d => d.StudentId)
            .ValueGeneratedOnAdd();

             modelBuilder
            .Entity<StudentTable>()
            .HasKey(d => d.StudentId);

             modelBuilder
            .Entity<SubjectTable>()
            .Property(d => d.SubjectId)
            .ValueGeneratedOnAdd();

             modelBuilder
            .Entity<SubjectTable>()
            .HasKey(d => d.SubjectId);

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
