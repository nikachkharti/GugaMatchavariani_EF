using GugaMatchavariani_EF.Data;
using GugaMatchavariani_EF.Entities;

namespace GugaMatchavariani_EF
{
    internal class Program
    {
        public static List<Student> students = new()
        {
            new Student()
            {
                FullName = "Giorgi Giorgadze",
                DateOfBirth = new DateTime(year:1995,month:04,day:06)
            },
            new Student()
            {
                FullName = "Giorgi Giorgadze",
                DateOfBirth = new DateTime(year:1995,month:04,day:06)
            },
            new Student()
            {
                FullName = "Giorgi Giorgadze",
                DateOfBirth = new DateTime(year:1995,month:04,day:06)
            }
        };

        static async Task Main(string[] args)
        {
            try
            {
                using var context = new ApplicationDbContext();
                bool dbCreated = context.Database.EnsureCreated();

                DatabaseCreateLog(dbCreated);

                await context.Students.AddRangeAsync(students);
                await context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


        }

        private static void DatabaseCreateLog(bool dbCreated)
        {
            if (dbCreated)
            {
                Console.WriteLine("Database created successfully");
            }
        }
    }
}
