using Microsoft.AspNetCore.Mvc;
using ModelsClass.Models;
using System.Diagnostics;

namespace ModelsClass.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            

            var student = new List<ModelClass>
            {
                new ModelClass
                {
                    Name = "Sanan Malik",
                    Degree = "BSCS",
                    University = "MNSUAM",
                    GraduationYear = 2028,
                    GraduationMonth = 6
                },
                 new ModelClass
                {
                    Name = "Naveed Malik",
                    Degree = "BSCS",
                    University = "MNSUAM",
                    GraduationYear = 2028,
                    GraduationMonth = 6
                },
                  new ModelClass
                {
                    Name = "Abdullah Malik",
                    Degree = "BSCS",
                    University = "MNSUAM",
                    GraduationYear = 2028,
                    GraduationMonth = 6
                }
            };

            ViewData["_students"] = student;
            return View();

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
