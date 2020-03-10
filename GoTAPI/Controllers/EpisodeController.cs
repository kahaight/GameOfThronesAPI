﻿using GoTAPI.Data.DataClasses;
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
        private EpisodeService CreateEpisodeService()
        {
            var userId = Guid.Parse(User.Identity.GetUserId());
            var episodeService = new EpisodeService(userId);
            return episodeService;
        }
        [HttpPost]
        public IHttpActionResult Post(EpisodeCreate episode)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            var service = CreateEpisodeService();
            if (!service.CreateEpisode(episode))
                return InternalServerError();
            return Ok();
        }
        [HttpGet]
        public IHttpActionResult Get()
        {
            EpisodeService episodeService = CreateEpisodeService();
            var episodes = episodeService.ReadEpisodes();
            return Ok(episodes);
        }
        [HttpGet]
        public IHttpActionResult Get(int id)
        {
            EpisodeService episodeService = CreateEpisodeService();
            var episode = episodeService.ReadEpisodeById(id);
            return Ok(episode);

        }
        [HttpPut]
        public IHttpActionResult Put(EpisodeUpdate model)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            var service = CreateEpisodeService();
            if (!service.UpdateEpisode(model))
                return InternalServerError();
            return Ok();
        }
        [HttpDelete]
        public IHttpActionResult Delete(int id)
        {
            var service = CreateEpisodeService();

            if (!service.DeleteEpisode(id))
                return InternalServerError();
            return Ok();
        }
    }
}
