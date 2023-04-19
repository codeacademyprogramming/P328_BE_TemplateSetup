using Homework.DataAccess;
using Homework.Models;
using Homework.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Homework.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            StudentViewModel studentVM = new StudentViewModel
            {
                Groups = Data.Groups,
                Students = Data.Students
            };
            return View(studentVM);
        }

        public IActionResult Detail(int id)
        {
            Student std = Data.Students.Find(x => x.Id == id);

            if (std == null)
                return View("Error");


            return View(std);
        }
    }
}
