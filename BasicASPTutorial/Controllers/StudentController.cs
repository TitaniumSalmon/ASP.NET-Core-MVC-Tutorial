using BasicASPTutorial.Models;
using Microsoft.AspNetCore.Mvc;

namespace BasicASPTutorial.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            Student s1 = new Student();
            s1.Id = 1;
            s1.Name = "John Nexon";
            s1.Score = 100;

            Student s2 = new Student();
            s2.Id = 2;
            s2.Name = "John Cena";
            s2.Score = 49;

            Student s3 = new Student();
            s3.Id = 3;
            s3.Name = "Jong Sena";
            s3.Score = 50;

            List<Student> students = new List<Student>();
            students.Add(s1);
            students.Add(s2);
            students.Add(s3);
            return View(students); 
        }

        //GET METHOD
        public IActionResult Create()
        {
            return View();
        }
    }
}
