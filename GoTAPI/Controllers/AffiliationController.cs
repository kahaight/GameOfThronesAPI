using GoTAPI.Models.AffiliationModels;
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
    public class AffiliationController : ApiController
    {
        private AffiliationService CreateAffiliationService()
        {
            var userId = Guid.Parse(User.Identity.GetUserId());
            var affiliationService = new AffiliationService(userId);
            return affiliationService;
        }
        [HttpPost]
        [Route("api/Affiliation")]
        public IHttpActionResult Post(AffiliationCreate affiliation)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            var service = CreateAffiliationService();
            if (!service.CreateAffiliation(affiliation))
                return InternalServerError();
            return Ok();
        }
        [HttpGet]
        [Route("api/Affiliation")]
        public IHttpActionResult Get()
        {
            AffiliationService affiliationService = CreateAffiliationService();
            var affiliations = affiliationService.ReadAffiliations();
            return Ok(affiliations);
        }
        [HttpGet]
        [Route ("api/Affiliation/{id}")]
        public IHttpActionResult Get(int id)
        {
            AffiliationService affiliationService = CreateAffiliationService();
            var affiliation = affiliationService.ReadAffiliationById(id);
            return Ok(affiliation);

        }
        [HttpPut]
        [Route("api/Affiliation")]
        public IHttpActionResult Put(AffiliationUpdate model)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            var service = CreateAffiliationService();
            if (!service.UpdateAffiliation(model))
                return InternalServerError();
            return Ok();
        }
        [HttpDelete]
        [Route("api/Affiliation/{id}")]
        public IHttpActionResult Delete(int id)
        {
            var service = CreateAffiliationService();

            if (!service.DeleteAffiliation(id))
                return InternalServerError();
            return Ok();
        }
    }
}
