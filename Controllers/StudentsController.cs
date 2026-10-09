using Microsoft.AspNetCore.Mvc;
using StudentsMvcDemo.Models;

namespace StudentsMvcDemo.Controllers
{
    public class StudentsController : Controller
    {
        // In-memory list so no database is required for the demo
        private static readonly List<Student> Students = new()
        {
            new Student { Id = 7, RegNumber = "BSCCS/2025/40350", FullName = "Ariel Boutcher", Programme = "BSc Computer Science" },
            new Student { Id = 1, RegNumber = "BSCCS/2025/39591", FullName = "Abdi Mulki Issack", Programme = "BSc Computer Science" },
            new Student { Id = 2, RegNumber = "BSCCS/2025/40065", FullName = "Joshua Samuel", Programme = "BSc Computer Science" }
        };

        public IActionResult Index()
        {
            return View(Students);
        }

        // Handles GET /Students/Details/7
        public IActionResult Details(int id)
        {
            var student = Students.FirstOrDefault(s => s.Id == id);
            if (student == null)
            {
                return NotFound();
            }
            return View(student);
        }
    }
}
