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

        internal List<House> Find()
        {
            List<House> houses = _repo.FindAll();
            return houses;
        }
        internal House Create(House houseData)
        {
            House house = _repo.Create(houseData);
            return house;
        }

        internal House Find(int id)
        {
            House house = _repo.FindOne(id);
            if (house == null) throw new Exception($"no house at id: {id}");
            return house;
        }

        // internal List<House> Find()
        // {
        //     throw new NotImplementedException();
        // }
    }
}