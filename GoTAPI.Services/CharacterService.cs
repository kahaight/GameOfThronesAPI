using GoTAPI.Data.DataClasses;
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
        //public bool CreateCharacter(CharacterCreate model)
        //{

        //}

        //public IEnumberable<CharacterListItem> ReadCharacters()
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
        //public CharacterDetail ReadCharacterById()
        //{

        //}
        //public bool UpdateCharacter(CharacterUpdate model)
        //{

        //}
        //public bool DeleteCharacter(int houseId)
        //{

        //}
    }
}