using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace gregsListCSharp.Repositories
{
    public class HousesRepository
    {
        private readonly IDbConnection _db;

        public HousesRepository(IDbConnection db)
        {
            _db = db;
        }

        internal House Create(House houseData)
        {
            string sql = @"
            Insert INTO houses
            (bathrooms, bedrooms, levels, price, imgUrl, description, year)
            VALUES
            (@bathrooms, @bedrooms, @levels, @price, @imgUrl, @description, @year);
            SELECT LAST_INSERT_ID();
            ";
            int id = _db.ExecuteScalar<int>(sql, houseData);
            houseData.Id = id;
            return houseData;
        }
    }
}