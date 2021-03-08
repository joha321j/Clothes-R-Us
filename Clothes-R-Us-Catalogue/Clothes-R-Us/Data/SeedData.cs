using System;
using System.Linq;
using Clothes_R_Us.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Clothes_R_Us.Data
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context =
                new ClothingContext(
                    serviceProvider
                        .GetRequiredService<DbContextOptions<ClothingContext>>()))
            {
                if (context.Clothings.Any())
                {
                    return;
                } 
                
            }
        }
    }
}