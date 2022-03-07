using System.ComponentModel.DataAnnotations;

namespace Volkswagen.Models
{
    public class Model
    {
        public int Id { get; set; }

        [StringLength(50, MinimumLength = 2)]
        [Required]
        [Display(Name = "Car Models")]
        public string? Car_Model { get; set; }

        [Required]
        public int Stock { get; set; }

        public string? Features { get; set; }

        [Required]
        public decimal Price { get; set; }
    }
}