using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PROStats2019.Models
{
    public class Country
    {
        public int Id { get; set; }


        [Display(Name ="Land")]
        public string CountryName { get; set; }
    }
}
