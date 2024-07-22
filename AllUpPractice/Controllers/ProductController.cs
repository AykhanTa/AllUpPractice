using AllUpPractice.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AllUpPractice.Controllers
{
    public class ProductController : Controller
    {
        private readonly AllUpDbContext _context;

        public ProductController(AllUpDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }
        public async Task<IActionResult> ProductModal(int? id)
        {
            if (id == null) return BadRequest();
            var product= await _context.Products
                .AsNoTracking()
                .Where(x => !x.IsDelete)
                .Include(p=>p.ProductImages)
                .FirstOrDefaultAsync(p=>p.Id==id);
            if (product == null) return NotFound();
            return PartialView("_ModalPartial",product);
        }
        public IActionResult SearchProduct(int? categoryId,string search)
        {
            if (categoryId != null && !_context.Categories.Any(c => c.Id == categoryId)) 
                return BadRequest();
            
            var products = _context.Products
                .AsNoTracking()
                .Where(p => !p.IsDelete && categoryId!=null?p.CategoryId==categoryId:true
                &&(p.Name.ToLower().Contains(search.ToLower()) || p.Brand.Name.ToLower().Contains(search.ToLower())))
                .ToList();
            return PartialView("_SearchPartial",products);

        }
    }
}
