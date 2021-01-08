﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdTapThat.Models
{
    public class BreweryCreate
    {
        [Key]
        public string Name { get; set; }
        [Required]
        public string Inception { get; set; }
        [Required]
        public string Location { get; set; }
        [Required]
        public string About { get; set; }
    }
}
