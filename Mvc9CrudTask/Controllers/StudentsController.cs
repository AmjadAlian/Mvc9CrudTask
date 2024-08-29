using Microsoft.AspNetCore.Mvc;
using Mvc9CrudTask.Data;
using Mvc9CrudTask.Models;

namespace Mvc9CrudTask.Controllers
{
    public class StudentsController : Controller
    {
       ApplicationDbContext context = new ApplicationDbContext();
        public IActionResult Index()
        {

            var students = context.Students.ToList();
            
            return View(students);
        }
        public IActionResult Create() { 
        
        
            return View();
        
        }
        public IActionResult Store(Student stu) {

            context.Students.Add(stu);
            context.SaveChanges();
            return RedirectToAction("Index");

        }
        [HttpGet]
        public IActionResult Edit (int Id) {
            var oldStudent = context.Students.Find(Id);
            return View(oldStudent);
        }
        [HttpPost]
        public IActionResult Edit(Student student)
        {
            context.Students.Update(student);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Delete(int Id)
        {
            var student = context.Students.Find(Id);
            context.Students.Remove(student);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
