using System.ComponentModel.DataAnnotations;

namespace shopapp.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        [Required]
        [StringLength(60, MinimumLength = 10,ErrorMessage ="Please write 10-60 characters")]
        public string Name { get; set; } 
        [Required(ErrorMessage ="Please enter a price")]
        public double? Price { get; set; } 
        public string Description { get; set; } 
        public bool IsApproved { get; set; }
        [Required]
        public string ImageUrl { get; set; }
        [Required]
        public int? CategoryId { get; set; }

    }
}