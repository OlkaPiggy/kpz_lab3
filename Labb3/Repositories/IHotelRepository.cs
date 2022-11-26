using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Labb3.Models;

namespace Labb3.Repositories
{
    public interface IHotelRepository
    {
        Task<IEnumerable<Hotel>> Get();
        Task<Hotel> Get(int id);
        Task<Hotel> Create(Hotel hotel);
        Task Update(Hotel hotel);
        Task Delete(int id);
    }
}
