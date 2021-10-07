using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using MvcSportsStore.Data;
using Microsoft.Extensions.DependencyInjection;

namespace MvcSportsStore.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcSportsStoreContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MvcSportsStoreContext>>()))
            {
                // Look for any products.
                if (context.Products.Any())
                {
                    return;   // DB has been seeded
                }

                context.Products.AddRange(
                    new Products
                    {
                        Name = "Puma",
                        Catergory = "Shoes",
                        Price = 8.99M
                    },

                    new Products
                    {
                        Name = "Adidas",
                        Catergory = "Top",
                        Price = 15.99M
                    },

                    new Products
                    {
                        Name = "Apple",
                        Catergory = "Beats",
                        Price = 199.95M
                    },

                    new Products
                    {
                        Name = "Jordons",
                        Catergory = "3",
                        Price = 60.00M
                    }
                );
                context.SaveChanges();
            }
        }
    }
}