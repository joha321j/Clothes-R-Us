using System.Collections.Generic;
using System.Runtime.InteropServices;
using Clothes_R_Us.Contexts;
using Clothes_R_Us.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Clothes_R_Us.Controllers
{
    [ApiController]
    [Route("clothing")]
    public class ClothingController
    {
        private readonly ClothingContext _clothingContext;
        private readonly ILogger<ClothingController> _logger;

        public ClothingController(ClothingContext clothingContext, ILogger<ClothingController> logger)
        {
            _clothingContext = clothingContext;
            _logger = logger;
        }

        [HttpGet]
        public List<Clothing> GetClothes()
        {
            List<Clothing> clothes = new List<Clothing>();
            
            return clothes;
        }
    }
}