using AllUpPractice.Models;

namespace AllUpPractice.Interfaces
{
    public interface ILayoutService
    {
        IDictionary<string, string> GetSettings();
        Task<IEnumerable<Category>> GetCategoriesAsync();
    }
}