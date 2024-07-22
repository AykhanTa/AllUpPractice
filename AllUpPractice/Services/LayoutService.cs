using AllUpPractice.Data;
using AllUpPractice.Interfaces;
using AllUpPractice.Models;
using Microsoft.EntityFrameworkCore;

namespace AllUpPractice.Services
{
    public class LayoutService : ILayoutService
    {
        private readonly AllUpDbContext _context;

        public LayoutService(AllUpDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Category>> GetCategoriesAsync()
        {
            var categories = await _context.Categories
                .AsNoTracking()
                .Where(c=>!c.IsDelete)
                .Include(c=>c.Children)
                .ToListAsync();
            return categories;
        }

        public IDictionary<string, string> GetSettings() => _context.Settings
            .Where(s => !s.IsDelete)
            .ToDictionary(s => s.Key, s => s.Value);
    }
}
