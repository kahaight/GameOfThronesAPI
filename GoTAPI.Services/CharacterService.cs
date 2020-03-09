using GoTAPI.Data.DataClasses;
<<<<<<< HEAD
using GoTAPI.Models;
=======
>>>>>>> 29ec58678564f71f831f279818003d419b557dcf
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
                    House = model.House,
                    Gender = model.Gender,
                    Actor = model.Actor,
                    CauseOfDeath = model.CauseofDeath
                };
            using (var ctx=new ApplicationDbContext())
            {
                ctx.Characters.Add(entity);
                return ctx.SaveChanges() == 1;
            }

        }

<<<<<<< HEAD
        public IEnumerable<CharacterListItem> ReadCharacters()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query = ctx.Characters.Where(e=>e.OwnerId==_userId).Select(
                    e=>
                        new CharacterListItem
                        {
                            CharacterId=e.CharacterId,

                        })
            }
        }
=======
        //public IEnumberable<CharacterListItem> ReadCharacters()
        //{

        //}

>>>>>>> 29ec58678564f71f831f279818003d419b557dcf
        //public CharacterDetail ReadCharacterById()
        //{

        //}
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