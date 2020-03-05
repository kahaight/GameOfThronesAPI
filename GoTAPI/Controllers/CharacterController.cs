using GoTAPI.Data.DataClasses;
using GoTAPI.Models.CharacterModels;
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
    public class CharacterController : ApiController
    {
        private CharacterService CreateCharacterService()
        {
            var userId = Guid.Parse(User.Identity.GetUserId());
            var characterService = new CharacterService(userId);
            return characterService;
        }
        //[HttpPost]
        //public IHttpActionResult Post(CharacterCreate character)
        //{

        //}
        //[HttpGet]
        //public IHttpActionResult Get()
        //{
        //}
        //[HttpGet]
        //public IHttpActionResult Get(int characterId)
        //{

        //}
        //[HttpPut]
        //public IHttpActionResult Put([FromUri]int characterId, [FromBody] CharacterUpdate model)
        //{

        //}
    }
}
