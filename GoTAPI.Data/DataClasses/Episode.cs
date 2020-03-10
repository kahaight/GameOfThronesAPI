using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoTAPI.Data.DataClasses
{
    public class Episode
    {
        [Key]
        public int Id { get; set; }
        public int Season { get; set; }
        public int EpisodeNumber { get; set; }
        public string Title { get; set; }
        public int RunTime { get; set; }
        public virtual ICollection<CharacterEpisode> CharacterEpisodes { get; set; }
    }
}
