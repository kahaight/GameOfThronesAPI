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
        [HttpPost]
        public IHttpActionResult Post(CharacterCreate character)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            var service = CreateCharacterService();
            if (!service.CreateCharacter(character))
                return InternalServerError();
            return Ok();
        }
        [HttpGet]
        public IHttpActionResult Get()
        {
            CharacterService characterService = CreateCharacterService();
            var characters = characterService.ReadCharacters();
            return Ok(characters);
        }

        [HttpGet]
        public IHttpActionResult Get(int id)
        {
            CharacterService characterService = CreateCharacterService();
            var character = characterService.ReadCharacterById(id);
            return Ok(character);
        }
        [HttpPut]
        public IHttpActionResult Put(CharacterUpdate model)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            var service = CreateCharacterService();
            if (!service.UpdateCharacter(model))
                return InternalServerError();
            return Ok();
        }
        [HttpDelete]
        public IHttpActionResult Delete(int id)
        {
            var service = CreateCharacterService();

            if (!service.DeleteCharacter(id))
                return InternalServerError();
            return Ok();
        }
    }
}
