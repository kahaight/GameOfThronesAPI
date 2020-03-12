using GoTAPI.Data.DataClasses;
using GoTAPI.Models;
using GoTAPI.Models.CharacterModels;
using GoTAPI.Models.HouseModels;
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

     /*   public IEnumerable<CharacterListItem> ReadCharacters()
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
        }*/

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
               /* query.ToArray();*/
                 
              /*  Array.Sort(query, (x, y) => (String.Compare(x.Name, y.Name);*/


               /* IEnumerable<string> queries = from word in query
                                              orderby word ascending
                                              select word;*/
                                              
                return query.OrderBy(s => s.Name).ToArray();
            }
        }

        /*string[] words = { "the", "quick", "brown", "fox", "jumps" };

        IEnumerable<string> query = from word in words
                                    orderby word.Substring(0, 1) descending
                                    select word;  
  
foreach (string str in query)  
    Console.WriteLine(str);  */
  
/* This code produces the following output:  
  
    the  
    quick  
    jumps  
    fox  
    brown  
*/

        public CharacterDetail ReadCharacterById(int id)
        {
            using (var ctx =new ApplicationDbContext())
            {
                var characterEpisodeService = new CharacterEpisodeService();
                var characteraffiliationService = new CharacterAffiliationService();
                var entity = ctx.Characters.Single(e => e.Id == id);
                return new CharacterDetail
                {
                    Id = entity.Id,
                    Name=entity.Name,
                    Alive = entity.Alive,
                    EpisodeOfDeath = entity.EpisodeOfDeath,
                    House = entity.House.Name,
                    Gender = entity.Gender,
                    Actor = entity.Actor,
                    CauseOfDeath = entity.CauseOfDeath,
                    Episodes = characterEpisodeService.ConvertCharEpisToEpis(entity.CharacterEpisodes),
                    Affiliation= characteraffiliationService.ConvertCharAfilToAfil(entity.CharacterAffiliations)
                };
            }
        }
      
        public bool UpdateCharacter(CharacterUpdate model)
        {
          using (var ctx = new ApplicationDbContext())
          {
            var entity = 
                        ctx
                       .Characters
                       .Single(e => e.Id == model.Id);
                entity.Name = model.Name;
                entity.Alive = model.Alive;
                entity.EpisodeOfDeath = model.EpisodeOfDeath;
                entity.HouseId = model.HouseId;
                entity.Gender = model.Gender;
                entity.Actor = model.Actor;
                entity.CauseOfDeath = model.CauseOfDeath;
                return ctx.SaveChanges() == 1;
            }
        }
        public bool DeleteCharacter(int id)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .Characters
                        .Single(e => e.Id == id);
                ctx.Characters.Remove(entity);
                return ctx.SaveChanges() == 1;
            }
        }
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