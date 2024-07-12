using AllUpPractice.Data;
using AllUpPractice.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AllUpPractice.Controllers
{
    public class HomeController : Controller
    {
        private readonly AllUpDbContext _context;

        public HomeController(AllUpDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            HomeVM homeVM = new();
            homeVM.Sliders = await _context.Sliders.Where(s=>!s.IsDelete).ToListAsync();
            homeVM.Categories=await _context.Categories.Where(c=>!c.IsDelete&&c.IsMain).ToListAsync();
            homeVM.NewProducts=await _context.Products.Where(p=>!p.IsDelete&&p.IsNewArrival).ToListAsync();
            homeVM.BestSellerProducts=await _context.Products.Where(p=>!p.IsDelete&&p.IsBestSeller).ToListAsync();
            homeVM.FeaturedProducts=await _context.Products.Where(p=>!p.IsDelete&&p.IsFeatured).ToListAsync();
            return View(homeVM);
        }

       
    }
}
