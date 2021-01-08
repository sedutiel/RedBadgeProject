using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdTapThat.Data
{
    public class Beer
    {
        [Key]
        public int BeerID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Type { get; set; }
        [Required]
        public string Brewery { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public int Rating { get; set; }
        [Required]
        public string Review { get; set; }
    }

    public class BeerDbContext : DbContext
    {
        public DbSet<Beer> Beers { get; set; }

    }

}


