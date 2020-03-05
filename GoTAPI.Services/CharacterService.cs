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
        public CharacterService(Guid userId)
        {
            _userId = userId;
        }
        public bool CreateCharacter(CharacterCreate model)
        {

        }

        public IEnumerable<CharacterListItem> ReadCharacters()
        {

        }
        public CharacterDetail ReadCharacterById()
        {

        }
        public bool UpdateCharacter(CharacterUpdate model)
        {

        }
        public bool DeleteCharacter(int houseId)
        {

        }
    }
}