using GoTAPI.Data.DataClasses;
using GoTAPI.Models;
using GoTAPI.Models.AffiliationModels;
using GoTAPI.Models.CharacterAffiliationModels;
using GoTAPI.Models.CharacterModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoTAPI.Services
{
    public class CharacterAffiliationService
    {
        private readonly Guid _userId;
        public CharacterAffiliationService() { }
        public CharacterAffiliationService(Guid userId)
        {
            _userId = userId;
        }
        public bool UpdateCharacterAffiliation(CharacterAffiliationUpdate model)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity = ctx.Affiliations;
                return ctx.SaveChanges() == 1;
            }
        }
        public bool CreateCharacterAffiliation(CharacterAffiliationCreate model)
        {
            var entity =
                new CharacterAffiliation()
                {
                    Description = model.Description
                };
            using (var ctx = new ApplicationDbContext())
            {
                ctx.CharacterAffiliations.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }
        public IEnumerable<string> ConvertCharAfilToAfil(ICollection<CharacterAffiliation> characterAffiliation)
        {
            var query = characterAffiliation.Select(
                        e =>
                            new AffiliationListItem
                            {
                                Description = e.Affiliation.Description
                            }
                    );
            query.ToArray();
            List<string> affiliationStrings = new List<string>();

            foreach (AffiliationListItem affiliationListItem in query)
            {
                affiliationStrings.Add(affiliationListItem.Description);
            }
            return affiliationStrings;
        }
        public IEnumerable<string> ConvertCharAfilToChar(ICollection<CharacterAffiliation> affiliationCharacter)
        {
            var query = affiliationCharacter.Select(
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
