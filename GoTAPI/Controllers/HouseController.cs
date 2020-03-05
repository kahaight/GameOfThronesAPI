using GoTAPI.Models.HouseModels;
using GoTAPI.Services;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace GoTAPI.Controllers
{
    public class HouseController : ApiController
    {
        private HouseService CreateHouseService()
        {
            var userId = Guid.Parse(User.Identity.GetUserId());
            var houseService = new HouseService(userId);
            return houseService;
        }
        [HttpPost]
        public IHttpActionResult Post(HouseCreate episode)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            var service = CreateHouseService();
            if (!service.CreateHouse(episode))
                return InternalServerError();
            return Ok();
        }
        [HttpGet]
       /* public IHttpActionResult Get()
        {
        }
        [HttpGet]
        public IHttpActionResult Get(int houseId)
        {
            HouseService houseService = CreateHouseService();
            var houses = houseService.ReadHouseById(houseId);
            return Ok(houses);
        }
        [HttpPut]
        public IHttpActionResult Put([FromUri]int houseId, [FromBody] HouseUpdate model)
        {

        }*/
        
        public IHttpActionResult Delete(int id)
        {
            var service = CreateHouseService();

            if (!service.DeleteHouse(id))
                return InternalServerError();

            return Ok();
        }
    }
}
