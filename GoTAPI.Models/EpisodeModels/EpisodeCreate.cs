using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoTAPI.Models.EpisodeModels
{
    public class EpisodeCreate
    {
       // public int Id { get; set; }
        public int Season { get; set; }
        public int EpisodeNumber { get; set; }
        public string Title { get; set; }
        public int RunTime { get; set; }
    }
}
