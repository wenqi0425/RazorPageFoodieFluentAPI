using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using RazorPageFoodie.Data;
using RazorPageFoodie.Models;

using System;
using System.Linq;

namespace RazorPageFoodie.Data
{
    public class SeedData
    {
        /*
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new FoodieContext(serviceProvider.GetRequiredService<DbContextOptions<FoodieContext>>()))
            {
                if (context.Ingredients.Any())
                {
                    return;
                }

                context.Ingredients.AddRange(
                    new Ingredient
                    {
                        Name = "Lotus Root",
                        Description = "Lotus root is an edible rhizome, a bulb from the flower of the same name that can be peeled, sliced, and eaten raw or cooked. It's an ancient ingredient used by emperors and villagers alike and proves so versatile, chefs have used the lotus root in salads and soups, in the main course, and also in many snack foods.",
                        ImageData = { }
                    },

                    new Ingredient
                    {
                        Name = "Shanghai Green",
                        Description = "Dark green, large spoon-shaped leaves with wide, light green midribs and mild flavor. Shanghai Green forms densely packed, vase-like heads. Plants can be spaced closely for baby choi, which is in demand with chefs for its tenderness and mild flavor.",
                        ImageData = { }
                    },

                    new Ingredient
                    {
                        Name = "Shiitake Mushroom",
                        Description = "Shiitake are rich in polysaccharides like lentinans and other beta-glucans. These compounds protect against cell damage, help your immune system, and boost white blood cell production for fighting off microbes. Polysaccharides also have anti-inflammatory properties.",
                        ImageData = { }
                    },

                    new Ingredient
                    {
                        Name = "Tofu",
                        Description = "Tofu is a food prepared by coagulating soy milk and then pressing the resulting curds into solid white blocks of varying softness; it can be silken, soft, firm, extra firm or super firm. Beyond these broad textural categories, there are many varieties of tofu. It has a subtle flavor, so it can be used in savory and sweet dishes. It is often seasoned or marinated to suit the dish and its flavors, and due to its spongy texture, it absorbs flavors well.",
                        ImageData = { }
                    },

                    new Ingredient
                    {
                        Name = "Wax gourd",
                        Description = "Wax gourd is also commonly called ash gourd, winter melon, white gourd, and winter gourd. It is a member of the gourd family (Cucurbitaceae), commonly referred to as cucurbits, which includes cucumbers, melons, zucchini, pumpkins, and other squash.",
                        ImageData = { }
                    }
                );

                context.SaveChanges();
            }
        }  
        */
    }
}
