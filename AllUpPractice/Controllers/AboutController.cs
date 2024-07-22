using AllUpPractice.Interfaces;
using AllUpPractice.Services;
using Microsoft.AspNetCore.Mvc;

namespace AllUpPractice.Controllers
{
    public class AboutController : Controller
    {
        private readonly ILayoutService _layoutService;

        public AboutController(ILayoutService layoutService)
        {
            _layoutService = layoutService;
        }

        public IActionResult Index()
        {
            return View(_layoutService.GetSettings());
        }
    }
}
