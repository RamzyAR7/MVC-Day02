using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MVC_Day02.DbContexts;
using MVC_Day02.Models;
using MVC_Day02.Services;

namespace MVC_Day02.Controllers
{
    public class StudentController : Controller
    {
        private readonly ILogger<StudentController> _logger;
        StudentsServices obj = new StudentsServices();
        public StudentController(ILogger<StudentController> logger)
        {
            _logger = logger;
        }

        // student/ShowAll 
        public IActionResult ShowAll()
        {
            var students = obj.GetAll();
            return View(students);
        }

        // Student/ShowDetails?id=3 
        public IActionResult ShowDetails(int id)
        {
            var student = obj.Get(id);

            if (student == null)
            {
                return NotFound();
            }

            return View(student);
        }
    }
}
