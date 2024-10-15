using Microsoft.AspNetCore.Mvc;
using School.Web.Infrastructure;
using School.Web.Models;
using System.Diagnostics;

namespace School.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IEnrollmentRepository _enrollmentRepository;

        public HomeController(ILogger<HomeController> logger, IEnrollmentRepository enrollmentRepository)
        {
            _logger = logger;
            _enrollmentRepository = enrollmentRepository;
        }

        public IActionResult Index()
        {
            //TODO: set the view model to be a list of enrollments with student and course
            IEnumerable<Enrollment> enrollments = _enrollmentRepository.GetAllGradedEnrollmentsWithStudentAndCourse();
            return View(enrollments);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
