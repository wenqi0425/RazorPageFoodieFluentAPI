using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace RazorPageFoodie.Models
{
    public class RecipeIngredient
    {
        // Mapping composite keys
        [Column(Order = 0), Key, ForeignKey("Recipe")]
        public int RecipeId { get; set; }

        [Column(Order = 1), Key, ForeignKey("Ingredient")]
        public int IngredientId { get; set; }

        [Required]
        [Display(Name = "Amount:")]
        public string Amount { get; set; }

        // Navigation Properties
        public Recipe Recipe { get; set; }
        public Ingredient Ingredient { get; set; }
    }
}
