using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoTAPI.Data.DataClasses
{
    public class Affiliation
    {
        [Key]
        public int Id { get; set; }
        public string Group { get; set; }
        public string Description { get; set; }
        public virtual ICollection<CharacterAffiliation> CharacterAffiliations { get; set; }
    }
}
