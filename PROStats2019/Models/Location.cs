using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PROStats2019.Models
{
    public class Location
    {
        public int Id { get; set; }


        [Display(Name ="Plats")]
        public string LocationName { get; set; }

        

    }
}
