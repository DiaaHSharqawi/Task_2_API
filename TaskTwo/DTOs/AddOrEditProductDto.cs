using System.ComponentModel.DataAnnotations;

namespace TaskTwo.DTOs
{
    public class AddOrEditProductDto
    {
        [Required(ErrorMessage = "Plese, Enter your name")]
        [MinLength(5, ErrorMessage = "Please, The min length should be 5")]
        [MaxLength(30, ErrorMessage = "Please, The max length should be 30 ")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please, Enter your price...!!")]
        [Range(20, 3000)]
        public decimal Price { get; set; }
        [Required(ErrorMessage = "Please, Enter your Description !!")]
        [MinLength(10)]
        public string Description { get; set; }
    }
}
