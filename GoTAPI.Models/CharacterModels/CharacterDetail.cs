using GoTAPI.Data.DataClasses;
using GoTAPI.Models.EpisodeModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoTAPI.Models.CharacterModels
{
    public class CharacterDetail
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool Alive { get; set; }
        public int? EpisodeOfDeath { get; set; }
        public string House { get; set; }
        public string Gender { get; set; }
        public string Actor { get; set; }
        public string CauseOfDeath { get; set; }
        public virtual IEnumerable<string> Episodes { get; set; }
        public virtual IEnumerable<string> Affiliation { get; set; }
    }
}
