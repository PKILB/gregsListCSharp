using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace gregsListCSharp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HousesController : ControllerBase
    {
        private readonly HousesService housesService;

        public HousesController(HousesService housesService)
        {
            this.housesService = housesService;
        }
        [HttpPost]
        public ActionResult<House> Create([FromBody] House houseData)
        {
            try
            {
                {
                    House house = housesService.Create(houseData);
                    return Ok(house);
                }
            }
            catch (System.Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}