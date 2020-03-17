using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoTAPI.Data.DataClasses
{
    public class CharacterAffiliation
    {
        [Key]
        public int Id { get; set; }
        public string Description { get; set; }
        [ForeignKey(nameof(Character))]
        public int CharacterId { get; set; }
        [ForeignKey(nameof(Affiliation))]
        public int AffiliationId { get; set; }
        public virtual Character Character { get; set; }
        public virtual Affiliation Affiliation { get; set; }

    }
}
