using GoTAPI.Data.DataClasses;
using GoTAPI.Models;
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

        public bool CreateCharacterEpisode(CharacterEpisodeCreate model)
        {
            var entity =
                new CharacterEpisode()
                {
                    CharacterId = model.CharacterId,
                    EpisodeId = model.EpisodeId
                };
            using (var ctx = new ApplicationDbContext())
            {
                ctx.CharacterEpisodes.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }
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

            foreach (EpisodeListItem episodeListItem in query)
            {
                episodeStrings.Add(episodeListItem.Title);
            }
            return episodeStrings;

        }

        public IEnumerable<string> ConvertCharEpisToChar(ICollection<CharacterEpisode> episodeCharacter)
        {
            var query = episodeCharacter.Select(
                        e =>
                            new CharacterListItem
                            {
                                Name = e.Character.Name
                            }
                    );
            query.ToArray();
            List<string> characterStrings = new List<string>();

            foreach (CharacterListItem characterListItem in query)
            {
                characterStrings.Add(characterListItem.Name);
            }
            return characterStrings;

        }
    }
}
