using FormAE.Models;
using Microsoft.AspNetCore.Mvc;

namespace FormAE.Controllers
{
    public class FormsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult ArabicForm()
        {
            return View();
        }
        public IActionResult EnglishForm()
        {
            return View();
        }
        public IActionResult ProcessLogin(StudentModel studentModel)
        {
            if (studentModel.lang == "arabic")
            {
                ViewBag.ArabicLang = studentModel.lang;
                return View("ArabicForm", studentModel);
            }else
            {
                ViewBag.EnglishLang = studentModel.lang;
                return View("EnglishForm", studentModel);
            }
        }
        public IActionResult ReadData(StudentModel studentModel)
        {
            return View("ReadData", studentModel);
        }
    }
}
