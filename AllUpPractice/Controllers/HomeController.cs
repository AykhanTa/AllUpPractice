using AllUpPractice.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace AllUpPractice.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

       
    }
}
