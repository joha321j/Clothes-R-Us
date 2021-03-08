using System;
using System.Collections.Generic;
using System.Linq;
using Clothes_R_Us.Contexts;
using Clothes_R_Us.Models;
using Clothes_R_Us.Models.Enums;
using Clothes_R_Us.Models.PriceCalculators;
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
                
                context.Clothings.AddRange(
                    new Clothing(
                        Sex.Male,
                        Age.Adult,
                        "Boxers",
                        01,
                        "Underbukser",
                        "Sebastians brugte underbukser",
                        123.456,
                        new List<Image>(),
                        new List<Size>(),
                        new List<Colour>()),
                    
                    new Clothing(
                        Sex.Female,
                        Age.Children,
                        "Shoes",
                        02,
                        "Sko",
                        "Kaares løbesko",
                        0.00,
                        new List<Image>(),
                        new List<Size>(),
                        new List<Colour>()),
                    
                    new Clothing(
                        Sex.Male,
                        Age.Adult,
                        "T-shirt",
                        03,
                        "Grim t-shirt",
                        "T-shirts som kun Johannes ville gå med. ",
                        10,
                        new List<Image>(),
                        new List<Size>(),
                        new List<Colour>()),
                    
                    new Clothing(
                        Sex.Male,
                        Age.Adult,
                        "Hat",
                        03,
                        "Slidt hat",
                        "Hat til at gemme bald spots",
                        600,
                        new List<Image>(),
                        new List<Size>(),
                        new List<Colour>())
                );

                context.SaveChanges();

            }
        }
    }
}