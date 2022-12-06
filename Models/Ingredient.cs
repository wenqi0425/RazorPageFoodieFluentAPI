using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace RazorPageFoodie.Models
{
    public class Ingredient
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Name:")]
        public string IngrediantName { get; set; }

        [Display(Name = "Introduction:")]
        public string? Introduction { get; set; }
        
        [Display(Name = "Image:")]
        public byte[]? ImageData { get; set; }
    }
}
