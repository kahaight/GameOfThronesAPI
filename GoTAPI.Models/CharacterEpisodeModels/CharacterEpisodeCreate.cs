using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoTAPI.Models.CharacterEpisodeModels
{
    public class CharacterEpisodeCreate
    {
        public int EpisodeId { get; set; }
        public int CharacterId { get; set; }
    }
}
