using GoTAPI.Data.DataClasses;
using GoTAPI.Models;
using GoTAPI.Models.EpisodeModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoTAPI.Services
{
    public class EpisodeService
    {
        private readonly Guid _userId;
        public EpisodeService(Guid userId)
        {
            _userId = userId;
        }


        /*public int Season { get; set; }
        public int EpisodeNumber { get; set; }
        public string Title { get; set; }
        public int RunTime { get; set; }*/
        public bool CreateEpisode(EpisodeCreate model)
        {
            var entity =
                new Episode()
                {
                    Season = model.Season,
                    EpisodeNumber = model.EpisodeNumber,
                    Title = model.Title,
                    RunTime = model.RunTime
                };
            using (var ctx = new ApplicationDbContext())
            {
                ctx.Episodes.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }

        public IEnumerable<EpisodeListItem> ReadEpisodes()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query = ctx.Episodes.Select(
                            e =>
                                new EpisodeListItem
                                {
                                    Title = e.Title,
                                    Season=e.Season,
                                    Episode=e.EpisodeNumber
                                }
                        );
                return query.ToArray();
            }
        }
        public EpisodeDetail ReadEpisodeById(int id)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var characterEpisodeService = new CharacterEpisodeService();
                var entity = ctx.Episodes.Single(e => e.Id == id);
                return new EpisodeDetail
                {
                    Season = entity.Season,
                    EpisodeNumber = entity.EpisodeNumber,
                    Title = entity.Title,
                    RunTime = entity.RunTime,
                    Characters = characterEpisodeService.ConvertCharEpisToChar(entity.CharacterEpisodes)
                };


            }
        }
        public bool UpdateEpisode(EpisodeUpdate model)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                       .Episodes
                       .Single(e => e.Id == model.Id);
                entity.Season = model.Season;
                entity.EpisodeNumber = model.EpisodeNumber;
                entity.Title = model.Title;
                entity.RunTime = model.RunTime;
                return ctx.SaveChanges() == 1;
            }
        }
        public bool DeleteEpisode(int id)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .Episodes
                        .Single(e => e.Id == id);
                ctx.Episodes.Remove(entity);
                return ctx.SaveChanges() == 1;
            }
        }
    }
}
