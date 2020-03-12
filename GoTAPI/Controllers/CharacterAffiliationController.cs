using GoTAPI.Models.CharacterAffiliationModels;
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
    public class CharacterAffiliationController : ApiController
    {
        private CharacterAffiliationService CreateCharacterAffiliationService()
        {
            var userId = Guid.Parse(User.Identity.GetUserId());
            var characterAffiliationService = new CharacterAffiliationService();
            return characterAffiliationService;
        }
        [HttpPost]
        public IHttpActionResult Post(CharacterAffiliationCreate characterAffiliation)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            var service = CreateCharacterAffiliationService();
            if (!service.CreateCharacterAffiliation(characterAffiliation))
                return InternalServerError();
            return Ok();
        }
    }
}
