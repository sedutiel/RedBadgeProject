using IdTapThat.Data;
using IdTapThat.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdTapThatApp.Services
{
    public class BreweryService
    {

        //method to create a brewery
        public bool CreateBrewery(BreweryCreate model)
        {
            var entity = new Brewery()
            {

                Name = model.Name,
                Inception = model.Inception,
                Location = model.Location,
                About = model.About,
            
            };

            using (var ctx = new BreweryDbContext())
            {
                ctx.Breweries.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }

        //method to get a list of brewery
        public IEnumerable<BreweryListItem> GetBreweries()
        {
            using (var ctx = new BreweryDbContext())
            {
                var query =
                    ctx
                        .Breweries
                        .Select(
                            e =>
                                new BreweryListItem
                                {
                                   
                                    Name = e.Name,
                                    Inception = e.Inception,
                                    Location = e.Location,
                                    About = e.About
                                }
                                );
                return query.ToArray();
            }
        }

        //method to update a brewery
        public bool UpdateBrewery(BreweryEdit model)
        {
            using (var ctx = new BreweryDbContext())
            {
                var entity =
                    ctx
                        .Breweries
                        .Single(e => e.Name == model.Name);


                entity.Name = model.Name;
                entity.Inception = model.Inception;
                entity.Location = model.Location;
                entity.About = model.About;


                return ctx.SaveChanges() == 1;

            }
        }

        //method to delete a brewery
        public bool DeleteBrewery(int breweryId)
        {
            using (var ctx = new BreweryDbContext())
            {
                var entity =
                    ctx
                        .Breweries
                        .Single(e => e.BreweryId == breweryId);

                ctx.Breweries.Remove(entity);

                return ctx.SaveChanges() == 1;
            }
        }
    }
}
