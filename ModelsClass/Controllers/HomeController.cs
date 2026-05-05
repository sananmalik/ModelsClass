using Microsoft.AspNetCore.Mvc;
using ModelsClass.Models;
using System.Diagnostics;
using System.Collections.Generic;

namespace ModelsClass.Controllers
{
    public class HomeController : Controller
    {
       //private readonly StudentRepository _studentrepository;
        public IActionResult Index()
        {


            var  student = new List<ModelClass>
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
        //public HomeController(StudentRepository studentrepository)
        //{
        //    _studentrepository = new StudentRepository();
        //}
        //public List<ModelClass> GetStudents()
        //{
            
        //    return _studentrepository.GetStudents();
        //}
        //public ModelClass  GetStudentById(int id)
        //{
        //    return _studentrepository.GetStudentById(id);
        //}

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
