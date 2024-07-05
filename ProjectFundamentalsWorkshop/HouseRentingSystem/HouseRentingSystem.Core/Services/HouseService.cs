using HouseRentingSystem.Core.Contracts;
using HouseRentingSystem.Core.Models.Home;
using HouseRentingSystem.Infrastructer.Comman;
using HouseRentingSystem.Infrastructer.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace HouseRentingSystem.Core.Services
{
    public class HouseService : IHouseService
    {
        private readonly IRepository repository;
        public HouseService(IRepository _repository)
        {
            repository = _repository;
        }

        public async Task<IEnumerable<HouseIndexServiceModel>> LastThreeHouses()
        {
            return await repository
             .AllReadOnly<Infrastructer.Data.Models.House>()
             .OrderBy(h => h.Id)
             .Take(3)
             .Select(h => new HouseIndexServiceModel()
             {
                 Id = h.Id,
                 Title = h.Title,
                 ImageUrl = h.ImageUrl,
             })
             .ToListAsync();
           
        }
    }
}
