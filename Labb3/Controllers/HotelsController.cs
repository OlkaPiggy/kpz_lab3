using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Labb3.Models;
using Labb3.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Labb3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HotelsController : ControllerBase
    {
        private readonly IHotelRepository hotelRepository1;
        public HotelsController(IHotelRepository hotelRepository)
        {
            hotelRepository1 = hotelRepository;
        }

        [HttpGet]
        public async Task<IEnumerable<Hotel>> GetHotels()
        {
            return await hotelRepository1.Get();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Hotel>> GetHotels(int id)
        {
            return await hotelRepository1.Get(id);
        }
    }
}
