using System.ComponentModel.DataAnnotations;

namespace DeGuzman_Midterm_Store.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = "";

        [Required]
        public string Description { get; set; } = "";

        [Required]
        [Range(0.01, 999999999)]
        public decimal Price { get; set; }

        [Required]
        public string Category { get; set; } = "";
    }
}