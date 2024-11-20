using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ViewModelAspNetCore.Models;

namespace ViewModelAspNetCore.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            List<Student> students = new List<Student>()
            {
                new Student(){ Id=1,Name="Rutvik",Gender="Male",Standard=12 },
                new Student(){ Id=2,Name="Krupal",Gender="Male",Standard=11 },
            };

            List<Teacher> teachers = new List<Teacher>()
            {
                new Teacher(){ Id=1,Name="Rutvik",Qualification="MCA",Salary=28000 },
                new Teacher(){ Id=2,Name="Krupal",Qualification="MCA",Salary=28000 }
            };
            SchoolViewModel schoolViewModel = new SchoolViewModel()
            {
                Students = students,
                Teachers = teachers
            };
            return View(schoolViewModel);
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
