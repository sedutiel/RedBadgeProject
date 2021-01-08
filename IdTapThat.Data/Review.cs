using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdTapThat.Data
{
    public class Review
    {
        [Key]
        public int ReviewId { get; set; }
        [Required]
        public string BeerName { get; set; }
        public string Brewery { get; set; }
        [Required]
        public int Rating { get; set; }
        [Required]
        public string Description { get; set; }
        public int ABV { get; set; }


        [ForeignKey(nameof(Beer))]
        public int BeerId { get; set; }
        public virtual Beer Beer { get; set; }

     
    }

    public class ReviewDbContext : DbContext
    {
        public DbSet<Review> Reviews { get; set; }
    }
}