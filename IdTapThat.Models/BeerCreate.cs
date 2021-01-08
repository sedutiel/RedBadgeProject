using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdTapThat.Models
{
    public class BeerCreate
    {
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
}