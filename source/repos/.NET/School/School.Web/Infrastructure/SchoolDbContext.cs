using School.Web.Models;
using Microsoft.EntityFrameworkCore;

namespace School.Web.Infrastructure;

public class SchoolDbContext : DbContext
{
    //You can use the private methods below to seed the database with dummy data
 
    public DbSet<Course> Courses { get; set; }
    public DbSet<Student> Students { get; set; }
    public DbSet<Enrollment> Enrollments { get; set; }

    public SchoolDbContext(DbContextOptions<SchoolDbContext> options) : base(options)
    {
        
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {

        var courses = GetCourses();
        var students = GetDummyStudents();
        var enrollments = GetDummyEnrollments(students, courses);



        modelBuilder.Entity<Course>().HasData(courses);
        modelBuilder.Entity<Student>().HasData(students);
        modelBuilder.Entity<Enrollment>().HasData(enrollments);
    }


    private IList<Course> GetCourses()
    {
        return new List<Course>
        {
            new Course { Id = Guid.NewGuid(), Title = "Chemistry", Credits = 3 },
            new Course { Id = Guid.NewGuid(), Title = "Calculus", Credits = 4 },
            new Course { Id = Guid.NewGuid(), Title = "Literature", Credits = 4 }
        };
    }
    
    private IList<Student> GetDummyStudents()
    {
        return new List<Student>
        {
            new Student
            {
                Id = Guid.NewGuid(), StartedOn = new DateTime(2023, 9, 1), FirstName = "John", LastName = "Doe"
            },
            new Student
            {
                Id = Guid.NewGuid(), StartedOn = new DateTime(2023, 8, 15), FirstName = "Jane", LastName = "Doe"
            }
        };
    }

    private IList<Enrollment> GetDummyEnrollments(IEnumerable<Student> students, IEnumerable<Course> courses)
    {
        var enrollments = new List<Enrollment>();
        Grade[] gradeValues = Enum.GetValues<Grade>();
        foreach (var student in students)
        {
            foreach (var course in courses)
            {
                int gradeIndex = Random.Shared.Next(gradeValues.Length);
                enrollments.Add(new Enrollment
                {
                    Id = Guid.NewGuid(),
                    StudentId = student.Id,
                    CourseId = course.Id,
                    Grade = gradeValues[gradeIndex]
                });
            }
        }
        return enrollments;
    }
}