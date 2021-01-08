using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdTapThat.Models
{
    public class ReviewListItem
    {
        public int ReviewId { get; set; }

        public string BeerName { get; set; }

        public string Brewery { get; set; }

        public int ABV { get; set; }

        public int Rating { get; set; }

        public string Description { get; set; }
    }
}
