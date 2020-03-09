using GoTAPI.Data.DataClasses;
using GoTAPI.Models;
using GoTAPI.Models.CharacterModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoTAPI.Services
{
    public class CharacterService
    {
        private readonly Guid _userId;

        public CharacterService() { }
        public CharacterService(Guid userId)
        {
            _userId = userId;
        }
        public bool CreateCharacter(CharacterCreate model)
        {
            var entity =
                new Character()
                {
                    Name = model.Name,
                    Alive = model.Alive,
                    EpisodeOfDeath = model.EpisodeOfDeath,
                    Gender = model.Gender,
                    Actor = model.Actor,
                    CauseOfDeath = model.CauseOfDeath,
                    HouseId = model.HouseId
                };
            using (var ctx=new ApplicationDbContext())
            {
                ctx.Characters.Add(entity);
                return ctx.SaveChanges() == 1;
            }

        }

        public IEnumerable<CharacterListItem> ReadCharacters()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query = ctx.Characters.Select(
                    e =>
                        new CharacterListItem
                        {
                            Name = e.Name,
                        });
                return query.ToArray();
            }
        }
        public CharacterDetail ReadCharacterById(int id)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var characterEpisodeService = new CharacterEpisodeService();
                var entity = ctx.Characters.Single(e => e.Id == id);
                return new CharacterDetail
                {
                    Id = entity.Id,
                    Name = entity.Name,
                    Alive = entity.Alive,
                    EpisodeOfDeath = entity.EpisodeOfDeath,
                    House = entity.House.Name,
                    Gender = entity.Gender,
                    Actor = entity.Actor,
                    CauseOfDeath = entity.CauseOfDeath,
                    Episodes = characterEpisodeService.ConvertCharEpisToEpis(entity.CharacterEpisodes)
                };


            }
        }
        //public bool UpdateCharacter(CharacterUpdate model)
        //{

        //}
        //public bool DeleteCharacter(int houseId)
        //{

        //}
        public IEnumerable<CharacterListItem> ConvertCharsToListItems(ICollection<Character> characters)
        {
                var query = characters.Select(
                            e =>
                                new CharacterListItem
                                {
                                    Name = e.Name
                                }
                        );
                return query.ToArray();
        }
    }
}