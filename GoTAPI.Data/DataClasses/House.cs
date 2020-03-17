using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoTAPI.Data.DataClasses
{
    public class House
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Sigil { get; set; }
        public string Words { get; set; }
        public string Region { get; set; }
        public virtual ICollection<Character> Characters { get; set; }
        //to  characterListItem convert from the 

        public House() { }
        public House(string name, string sigil, string words, string region, string causeOfDeath)
        {
            Name = name;
            Sigil = sigil;
            Words = words;
            Region = region;
        }
    }
}

