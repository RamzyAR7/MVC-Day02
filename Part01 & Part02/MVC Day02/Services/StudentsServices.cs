using Microsoft.EntityFrameworkCore;
using MVC_Day02.DbContexts;
using MVC_Day02.Models;
using System.Collections;

namespace MVC_Day02.Services
{
    public class StudentsServices
    {
        AcademyDbContext _dbContext = new AcademyDbContext();

        public ICollection<Student> GetAll()
        {
            var students = _dbContext.Students
                .Include(s => s.Department)
                .Include(s => s.StuCrsRes)
                .ThenInclude(sc => sc.Course)
                            .ToList();
            return students;
        }
        public Student Get(int id)
        {
            var student = _dbContext.Students
                .Include(s => s.Department)
                .Include(s => s.StuCrsRes)
                .ThenInclude(sc => sc.Course)
                .FirstOrDefault(s => s.Id == id);
            return student;
        }
    }
}
