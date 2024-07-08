using System.ComponentModel.DataAnnotations;

namespace AllUpPractice.Models
{
    public class Category:BaseEntity
    {
        [Required]
        [MaxLength(100)]    
        public string Name { get; set; }
        public string Image { get; set; }
        public bool IsMain { get; set; }
        public int? ParentId { get; set; }
        public Category Parent { get; set; }
        public List<Category> Children { get; set; }
        public List<Product> Products { get; set; }
    }
}
