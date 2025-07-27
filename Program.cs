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
                FullName = "Guga Matchavariani",
                DateOfBirth = new DateTime(year:2000,month:04,day:06)
            },
            new Student()
            {
                FullName = "Nika Chkhartishvili",
                DateOfBirth = new DateTime(year:2001,month:04,day:06)
            }
        };


        public static List<Subject> subjects = new()
        {
            new Subject()
            {
                Name = "C#",
                Score = 8.0
            },
            new Subject()
            {
                Name = "Typescript",
                Score = 8.0
            },
            new Subject()
            {
                Name = "Angular",
                Score = 8.0
            }
        };


        public static List<StudentSubject> studentSubjects = new()
        {
            new StudentSubject()
            {
                StudentId = 1,
                SubjectId = 1,
            },
            new StudentSubject()
            {
                StudentId = 1,
                SubjectId = 2,
            },
            new StudentSubject()
            {
                StudentId = 1,
                SubjectId = 3,
            },
            new StudentSubject()
            {
                StudentId = 2,
                SubjectId = 2,
            },
            new StudentSubject()
            {
                StudentId = 3,
                SubjectId = 1,
            },
            new StudentSubject()
            {
                StudentId = 3,
                SubjectId = 3,
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
                await context.Subjects.AddRangeAsync(subjects);
                await context.StudentSubjects.AddRangeAsync(studentSubjects);
                await context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
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
