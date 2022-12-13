using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace RazorPageFoodie.Models
{
    public class Recipe
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Recipe Name:")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Cooking Steps:")]
        public string CookingSteps { get; set; }

        [Display(Name = "Introduction:")]
        public string? Introduction { get; set; }

        [Display(Name = "Recipe Image:")]
        public byte[]? ImageData { get; set; }

        //[ForeignKey("AppUser")]
        //public int AppUserId { get; set; }

        // Navigation Properties
        //public AppUser AppUser { get; set; }
        public ICollection<RecipeIngredient> RecipeIngredients { get; set; }
    }
}
