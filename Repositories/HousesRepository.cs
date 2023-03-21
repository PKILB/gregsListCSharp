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

        internal List<House> FindAll()
        {
            string sql = @"
            SELECT
            *
            From houses;
            ";
            List<House> houses = _db.Query<House>(sql).ToList();
            return houses;
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

        internal House FindOne(int id)
        {
            string sql = @"
            Select
            *
            From houses
            WHERE id = @id;
            ";
            House house = _db.Query<House>(sql, new {id}).FirstOrDefault();
            return house;
        }

        internal bool Remove(int id)
        {
            string sql = @"
            DELETE FROM houses WHERE id = @id;
            ";
            int rows = _db.Execute(sql, new { id });
            return rows == 1;
        }

        internal int Update(House update)
        {
            string sql = @"
            UPDATE houses
            SET
            bathrooms = @bathrooms,
            bedrooms = @bedrooms,
            levels = @levels,
            price = @price,
            imgUrl = @imgUrl,
            description = @description,
            year = @year
            WHERE id = @id;
            ";
            int rows = _db.Execute(sql, update);
            return rows;
        }
    }
}