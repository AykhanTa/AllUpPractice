using AllUpPractice.Models;

namespace AllUpPractice.ViewModels
{
    public class HomeVM
    {
        public IEnumerable<Slider> Sliders { get; set; }
        public IEnumerable<Category> Categories{ get; set; }
    }
}
