using GoTAPI.Data.DataClasses;
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
            var entity =
                new House()
                {
                    Name = model.Name,
                    Sigil = model.Sigil,
                    Words = model.Words,
                    Region = model.Region
                };
            using (var ctx=new ApplicationDbContext())
            {
                ctx.Houses.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }

       public IEnumerable<HouseListItem> ReadHouses()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query = ctx.Houses.Select(
                            e =>
                                new HouseListItem
                                {
                                    Name = e.Name
                                }
                        );
                return query.ToArray();
            }
        }

        public HouseDetail ReadHouseById(int id)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var characterService = new CharacterService();
                var entity = ctx.Houses.Single(e => e.Id == id);
                return new HouseDetail
                {
                    Id = entity.Id,
                    Name = entity.Name,
                    Sigil = entity.Sigil,
                    Words = entity.Words,
                    Region = entity.Region,
                    Characters = characterService.ConvertCharsToListItems(entity.Characters)

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
            using (var ctx =new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .Houses
                        .Single(e => e.Id == houseId);
                ctx.Houses.Remove(entity);
                return ctx.SaveChanges() == 1;
            }
        }
    }
}
