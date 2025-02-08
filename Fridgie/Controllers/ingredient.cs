using System.ComponentModel.DataAnnotations;

namespace Fridgie.Controllers {
    public class ingredient {
        [Key]
        public int IngredientId { get; set; }
        [Required]
        [Display(Name ="Name")]
        public string IngredientName { get; set; } = "";
        [Display(Name = "Calories (per 100g")]
        public int CaloricValue { get; set; }
        [Required]
        [Display(Name = "Protein (per 100g")]
        public int ProteinValue { get; set; }

        [Display(Name = "Sodium (per 100g")]
        public int? SodiumContent { get; set; }
        [Display(Name = "Manufacturer?")]
        public string? Manufacturer { get; set; }

        public DateTime? ExpiryDate { get; set; }



    }
}
