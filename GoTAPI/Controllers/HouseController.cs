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
        public IHttpActionResult Get()
        {
            HouseService houseService = CreateHouseService();
            var houses = houseService.ReadHouses();
            return Ok(houses);
        }
        [HttpGet]
        public IHttpActionResult Get(int id)
        {
            HouseService houseService = CreateHouseService();
            var house = houseService.ReadHouseById(id);
            return Ok(house);
        }
        [HttpPut]
        public IHttpActionResult Put(HouseUpdate model)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            var service = CreateHouseService();
            if (!service.UpdateHouse(model))
                return InternalServerError();
            return Ok();
        }
        [HttpDelete]
        public IHttpActionResult Delete(int id)
        {
            var service = CreateHouseService();

            if (!service.DeleteHouse(id))
                return InternalServerError();

            return Ok();
        }
    }
}
