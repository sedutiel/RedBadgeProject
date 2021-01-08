using IdTapThat.Data;
using IdTapThat.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdTapThat.Services
{
    public class BeerService
    {

        //method to create a beer
        public bool CreateBeer(BeerCreate model)
        {
            var entity = new Beer()
            {
                
                Name = model.Name,
                Type = model.Type,
                Brewery = model.Brewery,
                Description = model.Description,
                Rating = model.Rating,
                Review = model.Review
            };

            using (var ctx = new BeerDbContext())
            {
                ctx.Beers.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }

        //method to get a list of beers 
        public IEnumerable<BeerListItem> GetBeers()
        {
            using (var ctx = new BeerDbContext())
            {
                var query =
                    ctx
                        .Beers
                        .Select(
                            e =>
                                new BeerListItem
                                {
                                    BeerId = e.BeerID,
                                    Name = e.Name,
                                    Brewery = e.Brewery
                                }
                                );
                return query.ToArray();
            }
        }

        //method to update a beer
        public bool UpdateBeer(BeerEdit model)
        {
            using (var ctx = new BeerDbContext())
            {
                var entity =
                    ctx
                        .Beers
                        .Single(e => e.Name == model.Name);

                
                entity.Name = model.Name;
                entity.Type = model.Type;
                entity.Brewery = model.Brewery;
                entity.Description = model.Description;
                entity.Rating = model.Rating;
                entity.Review = model.Review;
                

                return ctx.SaveChanges() == 1;

            }
        }

        //method to delete a beer 
        public bool DeleteBeer(int beerId)
        {
            using (var ctx = new BeerDbContext())
            {
                var entity =
                    ctx
                        .Beers
                        .Single(e => e.BeerID == beerId);

                ctx.Beers.Remove(entity);

                return ctx.SaveChanges() == 1;
            }
        }
    }
}
