using GoTAPI.Data.DataClasses;
using GoTAPI.Models.EpisodeModels;
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
    public class EpisodeController : ApiController
    {
        private EpisodeService CreateHouseService()
        {
            var userId = Guid.Parse(User.Identity.GetUserId());
            var episodeService = new EpisodeService(userId);
            return episodeService;
        }
        //[HttpPost]
        //public IHttpActionResult Post(EpisodeCreate episode)
        //{

        //}
        //[HttpGet]
        //public IHttpActionResult Get()
        //{
        //}
        //[HttpGet]
        //public IHttpActionResult Get(int episodeId)
        //{

        //}
        //[HttpPut]
        //public IHttpActionResult Put([FromUri]int episodeId, [FromBody] EpisodeUpdate model)
        //{

        //}
    }
}
