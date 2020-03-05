using GoTAPI.Models.CharacterEpisodeModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoTAPI.Services
{
    public class CharacterEpisodeService
    {
        private readonly Guid _userId;
        public CharacterEpisodeService(Guid userId)
        {
            _userId = userId;
        }
        //public bool CreateCharacterEpisode(CharacterEpisodeCreate model)
        //{

        //}
    }
}
