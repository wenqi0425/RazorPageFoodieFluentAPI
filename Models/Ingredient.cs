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
        public string Name { get; set; }

        [Display(Name = "Description:")]
        public string? Description { get; set; }
        
        [Display(Name = "Image:")]
        public byte[]? ImageData { get; set; }
    }
}
