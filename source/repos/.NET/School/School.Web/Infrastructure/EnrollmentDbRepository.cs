using Microsoft.EntityFrameworkCore;
using School.Web.Models;

namespace School.Web.Infrastructure;

public class EnrollmentDbRepository : IEnrollmentRepository
{
    private readonly SchoolDbContext _schoolDbContext;


    public EnrollmentDbRepository(SchoolDbContext schoolDbContext)
    {
        _schoolDbContext = schoolDbContext;
    }

    public IReadOnlyCollection<Enrollment> GetAllGradedEnrollmentsWithStudentAndCourse()
    {

        return _schoolDbContext.Enrollments
            .Include(e => e.Student)
            .Include(e => e.Course)
            .Where(e => e.Grade != null && e.Course != null && e.Student != null)
            .OrderBy(e => e.Student.LastName)
            .OrderBy(e => e.Student.FirstName)
            .ToList();
    }
}