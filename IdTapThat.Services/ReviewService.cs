using IdTapThat.Data;
using IdTapThat.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdTapThat.Services
{
    public class ReviewService
    {

        //method to create a Review
        public bool CreateBrewery(ReviewCreate model)
        {
            var entity = new Review()
            {

                
                BeerName= model.BeerName,
                Brewery = model.Brewery,
                ABV = model.ABV,
                Rating = model.Rating,
                Description = model.Description

            };

            using (var ctx = new ReviewDbContext())
            {
                ctx.Reviews.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }

        //method to get a list of reviews
        public IEnumerable<ReviewListItem> GetReviews()
        {
            using (var ctx = new ReviewDbContext())
            {
                var query =
                    ctx
                        .Reviews
                        .Select(
                            e =>
                                new ReviewListItem
                                {

                                    ReviewId = e.ReviewId,
                                    BeerName = e.BeerName,
                                    Brewery = e.Brewery,
                                    ABV = e.ABV,
                                    Rating = e.Rating,
                                    Description = e.Description
                                }
                                );
                return query.ToArray();
            }
        }

        //method to update a review
        public bool UpdateReview(ReviewEdit model)
        {
            using (var ctx = new ReviewDbContext())
            {
                var entity =
                    ctx
                        .Reviews
                        .Single(e => e.BeerName == model.BeerName);


                entity.BeerName = model.BeerName;
                entity.Brewery = model.Brewery;
                entity.ABV = model.ABV;
                entity.Rating = model.Rating;
                entity.Description = model.Description;


                return ctx.SaveChanges() == 1;

            }
        }

        //method to delete a review
        public bool DeleteReview(int reviewId)
        {
            using (var ctx = new ReviewDbContext())
            {
                var entity =
                    ctx
                        .Reviews
                        .Single(e => e.ReviewId == reviewId);

                ctx.Reviews.Remove(entity);

                return ctx.SaveChanges() == 1;
            }
        }
    }
}