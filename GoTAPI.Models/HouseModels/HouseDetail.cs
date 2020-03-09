using GoTAPI.Data.DataClasses;
using GoTAPI.Models.CharacterModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoTAPI.Models.HouseModels
{
    public class HouseDetail
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Sigil { get; set; }
        public string Words { get; set; }
        public string Region { get; set; }
        public IEnumerable<CharacterListItem> Characters { get; set; }
    }
}
