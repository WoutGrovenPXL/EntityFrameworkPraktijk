using School.Web.Models;

namespace School.Web.Infrastructure;

public class SchoolDbContext
{
    //You can use the private methods below to seed the database with dummy data
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