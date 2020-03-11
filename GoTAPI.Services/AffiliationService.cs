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
/*    public int Id { get; set; }
    public string Group { get; set; }
    public string Description { get; set; }
    public virtual ICollection<CharacterAffiliation> CharacterAffiliations { get; set; }
    public class AffiliationService*/
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
            var query ctx.Affiliations.Select(
                e =>
                    new AffiliationListItem
                    {
                        Group = e.Group,
                        Description = e.Description
                    }
                );
            return query.ToArray();
        }
    }
}
