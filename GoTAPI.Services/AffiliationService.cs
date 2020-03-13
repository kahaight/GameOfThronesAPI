using GoTAPI.Data.DataClasses;
using GoTAPI.Models;
using GoTAPI.Models.AffiliationModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoTAPI.Services
{
    public class AffiliationService
    {
        private readonly Guid _userId;
        public AffiliationService(Guid userId)
        {
            _userId = userId;
        }
        public bool CreateAffiliation(AffiliationCreate model)
        {
            var entity =
                new Affiliation()
                {
                    Group = model.Group,
                    Description = model.Description,
                };
            using (var ctx = new ApplicationDbContext())
            {
                ctx.Affiliations.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }

        public IEnumerable<AffiliationListItem> ReadAffiliations()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query = ctx.Affiliations.Select(
                    e =>
                        new AffiliationListItem
                        {
                            Group = e.Group
                        }
                    );
                return query.ToArray();
            }
        }
        public AffiliationDetail ReadAffiliationById(int id)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var characterAffiliationService = new CharacterAffiliationService();
                var entity = ctx.Affiliations.Single(e => e.Id == id);
                return new AffiliationDetail
                { Group = entity.Group,
                  Description=entity.Description,
                  Characters = characterAffiliationService.ConvertCharAfilToChar(entity.CharacterAffiliations)
                };

            }
        }
        public bool UpdateAffiliation(AffiliationUpdate model)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                    .Affiliations
                    .Single(e => e.Id == model.Id);
                entity.Group = model.Group;
                entity.Description = model.Description;
                return ctx.SaveChanges() == 1;
            }
        }
        public bool DeleteAffiliation(int id)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                    .Affiliations
                    .Single(e => e.Id == id);
                ctx.Affiliations.Remove(entity);
                return ctx.SaveChanges() == 1;
            }
        }
    }
}
