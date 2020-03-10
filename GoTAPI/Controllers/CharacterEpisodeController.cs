using GoTAPI.Models.CharacterEpisodeModels;
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
    public class CharacterEpisodeController : ApiController
    {
        private CharacterEpisodeService CreateCharacterEpisodeService()
        {
            var userId = Guid.Parse(User.Identity.GetUserId());
            var characterEpisodeService = new CharacterEpisodeService(userId);
            return characterEpisodeService;
        }
        [HttpPost]
        public IHttpActionResult Post(CharacterEpisodeCreate characterEpisode)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            var service = CreateCharacterEpisodeService();
            if (!service.CreateCharacterEpisode(characterEpisode))
                return InternalServerError();
            return Ok();
        }
    }
}
