﻿using GoTAPI.Models.EpisodeModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoTAPI.Services
{
    public class EpisodeService
    {
        private readonly Guid _userId;
        public EpisodeService(Guid userId)
        {
            _userId = userId;
        }
        //public bool CreateEpisode(EpisodeCreate model)
        //{

        //}

        //public IEnumerable<EpisodeListItem> ReadEpisodes()
        //{

        //}
        //public EpisodeDetail ReadEpisodeById()
        //{

        //}
        //public bool UpdateEpisode(EpisodeUpdate model)
        //{

        //}
        //public bool DeleteEpisode(int houseId)
        //{

        //}
    }
}
