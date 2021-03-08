using Clothes_R_Us.Models;
using Microsoft.EntityFrameworkCore;

namespace Clothes_R_Us.Contexts
{
    public class ClothingContext : DbContext
    {
        public ClothingContext(DbContextOptions<ClothingContext> options) : base(options)
        {
        }
        
        public DbSet<Clothing> Clothings { get; set; }
    }
}