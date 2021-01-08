using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdTapThat.Models
{
    public class BreweryListItem
    {
        
        public string Name { get; set; }
       
        public string Inception { get; set; }
        
        public string Location { get; set; }
        
        public string About { get; set; }
    }
}
