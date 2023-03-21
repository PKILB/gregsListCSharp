using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace gregsListCSharp.Services
{
    public class HousesService
    {
        private readonly HousesRepository _repo;

        public HousesService(HousesRepository repo)
        {
            _repo = repo;
        }

        internal House Create(House houseData)
        {
            House house = _repo.Create(houseData);
            return house;
        }
    }
}