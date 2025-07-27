using GugaMatchavariani_EF.Entities;
using Microsoft.EntityFrameworkCore;

namespace GugaMatchavariani_EF.Data
{
    public class ApplicationDbContext : DbContext
    {
        private const string connectionString = "Server=DESKTOP-SCSHELD\\SQLEXPRESS;Database=StudentsDb;Trusted_Connection=True;TrustServerCertificate=True";
        public DbSet<Student> Students { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<StudentSubject> StudentSubjects { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString);
        }
    }
}
