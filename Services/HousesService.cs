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

        internal string Remove(int id)
        {
            House house = this.Find(id);
            bool result = _repo.Remove(id);
            if (!result) throw new Exception($"something bad happened when trying to delete {house.Price} {house.Levels} @ id {house.Id}");
            return $"deleted {house.Price} {house.Levels}";
        }

        internal House Update(House updateData)
        {
            House original = this.Find(updateData.Id);
            original.Bathrooms = updateData.Bathrooms != 0 ? updateData.Bathrooms : original.Bathrooms;
            original.Bedrooms = updateData.Bedrooms != 0 ? updateData.Bedrooms : original.Bedrooms;
            original.Levels = updateData.Levels != 0 ? updateData.Levels : original.Levels;
            original.Price = updateData.Price != null ? updateData.Price : original.Price;
            original.ImgUrl = updateData.ImgUrl != null ? updateData.ImgUrl : original.ImgUrl;
            original.Description = updateData.Description != null ? updateData.Description : original.Description;
            original.Year = updateData.Year != 0 ? updateData.Year : original.Year;
            int rowsAffected = _repo.Update(original);
            if (rowsAffected == 0) throw new Exception($"could not modify {updateData.Description} {updateData.Year} @id {updateData.Id} for some reason");
            if (rowsAffected > 1) throw new Exception($"Something horrible happened, you made at least {rowsAffected} of houses into {updateData.Description} {updateData.Year}, might wanna check the db");
            return original;
        }

        // internal List<House> Find()
        // {
        //     throw new NotImplementedException();
        // }
    }
}