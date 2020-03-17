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
        [Route("api/Character")]
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
        [Route("api/Character")]
        public IHttpActionResult Get()
        {
            CharacterService characterService = CreateCharacterService();
            var characters = characterService.ReadCharacters();
            return Ok(characters);
        }
        [HttpGet]
        [Route("api/Character/{id}")]
        public IHttpActionResult Get(int id)
        {
            CharacterService characterService = CreateCharacterService();
            var character = characterService.ReadCharacterById(id);
            return Ok(character);
        }
        [HttpGet]
        [Route("api/Character/Alive/{alive}")]
        public IHttpActionResult Get(bool alive)
        {
            CharacterService characterService = CreateCharacterService();
            var characters = characterService.ReadCharactersByStatus(alive);
            return Ok(characters);
        }
        [HttpPut]
        [Route("api/Character")]
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
        [Route("api/Character/{id}")]
        public IHttpActionResult Delete(int id)
        {
            var service = CreateCharacterService();

            if (!service.DeleteCharacter(id))
                return InternalServerError();
            return Ok();
        }
    }
}
