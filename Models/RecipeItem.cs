using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace RazorPageFoodie.Models
{
    public class RecipeItem
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Ingrediant:")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Amount:")]
        public string Amount { get; set; }

        [ForeignKey("Recipe")]
        public int RecipeID { get; set; }

        // Navigation Properties
        public Recipe Recipe { get; set; }
    }
}
