using GoTAPI.Data.DataClasses;
using GoTAPI.Models.CharacterEpisodeModels;
using GoTAPI.Models.CharacterModels;
using GoTAPI.Models.EpisodeModels;
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
        public CharacterEpisodeService() { }
        public CharacterEpisodeService(Guid userId)
        {
            _userId = userId;
        }
        public CharacterEpisodeService()
        { 
        
        }

        public IEnumerable<EpisodeListItem> ConvertCharEpisToEpis(ICollection<CharacterEpisode> characterEpisodes)
        {
            var query = characterEpisodes.Select(
                        e =>
                            new EpisodeListItem
                            {
                                Title = e.Episode.Title
                            }
                            );
            return query.ToArray();
        }
        /*public bool CreateCharacterEpisode(CharacterEpisodeCreate model)
        {

        }*/
        public IEnumerable<string> ConvertCharEpisToEpis(ICollection<CharacterEpisode> characterEpisodes)
        {
            var query = characterEpisodes.Select(
                        e =>
                            new EpisodeListItem 
                            {
                                Title = e.Episode.Title
                            }
                    );
            query.ToArray();
            List<string> episodeStrings = new List<string>();

            foreach(EpisodeListItem episodeListItem in query)
            {
                episodeStrings.Add(episodeListItem.Title);
            }
            return episodeStrings;

        }
    }
}
