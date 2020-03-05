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

        public HouseDetail ReadHouseById()
        {
           
        }

        public bool UpdateHouse(HouseUpdate model)
        {

        }

        public bool DeleteHouse(int houseId)
        {
            using (var ctx = new ApplicationDbContext())
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
