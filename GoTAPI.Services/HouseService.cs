using GoTAPI.Models;
using GoTAPI.Models.HouseModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoTAPI.Services
{
    public class HouseService
    {
        private readonly Guid _userId;
        public HouseService(Guid userId)
        {
            _userId = userId;
        }
        public bool CreateHouse(HouseCreate model)
        {

        }

        public IEnumerable<HouseListItem> ReadHouses()
        {

        }

        public HouseDetail ReadHouseById(int houseId)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity = ctx.Houses.Single(e => e.Id == houseId);
                return new HouseDetail
                {
                    Id = entity.Id,
                    Name = entity.Name,
                    Sigil = entity.Sigil,
                    Words = entity.Words,
                    Region = entity.Region,
                    Characters = entity.Characters

                };
            }
        }

        public bool UpdateHouse(HouseUpdate model)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                       .Houses
                       .Single(e => e.Id == model.Id);
                entity.Name = model.Name;
                entity.Sigil = model.Sigil;
                entity.Words = model.Words;
                entity.Region = model.Region;

                return ctx.SaveChanges() == 1;
            }
        }

        public bool DeleteHouse(int houseId)
        {

        }
    }
}
