using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoTAPI.Data.DataClasses
{
    public class CharacterEpisode
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey(nameof(Episode))]
        public int EpisodeId { get; set; }
        [ForeignKey(nameof(Character))]
        public int CharacterId { get; set; }
        public virtual Character Character { get; set; }
        public virtual Episode Episode { get; set; }
    }
}
