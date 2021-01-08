using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdTapThat.Models
{
    public class BeerDetail
    {
        public int BeerId { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Brewery { get; set; }
        public string Description { get; set; }
        public int Rating { get; set; }
        public string Review { get; set; }
    }
}
   