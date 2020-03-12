using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoTAPI.Models.AffiliationModels
{
    public class AffiliationDetail
    {
     /*   public int Id { get; set; }*/
        public string Group { get; set; }
        public string Description { get; set; }
        public virtual IEnumerable<string> Characters { get; set; }
    }
}
