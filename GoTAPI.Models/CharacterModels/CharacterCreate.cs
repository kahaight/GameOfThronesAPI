﻿using GoTAPI.Data.DataClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoTAPI.Models.CharacterModels
{
    public class CharacterCreate
    {
        public int Id { get; set; }
       /* [ForeignKey(nameof(House))]*/
        public int HouseId { get; set; }
        public string Name { get; set; }
        public bool Alive { get; set; }
        public int? EpisodeOfDeath { get; set; }
        public virtual House House { get; set; }
        public string Gender { get; set; }
        public string Actor { get; set; }
        public string CauseOfDeath { get; set; }
        public virtual ICollection<CharacterEpisode> CharacterEpisodes { get; set; }
    }
}
