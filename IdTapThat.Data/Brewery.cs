using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdTapThat.Data
{
    public class Brewery
    {
        [Key]
        public int BreweryId { get; set; }
        public string Name { get; set; }
        [Required]
        public string Inception { get; set; }
        [Required]
        public string Location { get; set; }
        [Required]
        public string About { get; set; }
    }

    public class BreweryDbContext : DbContext
    {
        public DbSet<Brewery> Breweries { get; set; }
    }

}