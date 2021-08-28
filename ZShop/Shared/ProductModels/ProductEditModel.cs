using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ZShop.Shared.ProductModels
{
    public class ProductEditModel
    {
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Description { get; set; }
        public string Image { get; set; }
        public Category Category { get; set; }
        public int CategoryId { get; set; }
        public List<ProductVariant> Variants { get; set; } = new List<ProductVariant>();
        public int Views { get; set; }
    }
}
