using System.ComponentModel.DataAnnotations;

namespace DeGuzman_Midterm_Store.Models
{
    public class CartItem
    {
        public int Id { get; set; }

        public int ProductId { get; set; }

        [Required]
        public string ProductName { get; set; } = "";

        public decimal Price { get; set; }

        [Range(1, 999)]
        public int Quantity { get; set; }
    }
}