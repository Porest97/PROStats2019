using HockeyStats2019.Models;
using Microsoft.CodeAnalysis;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PROStats2019.Models
{
    public class Workout
    {
        public int Id { get; set; }

        [Display(Name = "Sport")]
        public int? SportId { get; set; }
        [Display(Name = "Sport")]
        [ForeignKey("SportId")]
        public Sport Sport { get; set; }

        [Display(Name = "Plats")]
        public int? LocationId { get; set; }
        [Display(Name = "Plats")]
        [ForeignKey("LocationId")]
        public Location Location { get; set; }

        [Display(Name = "Distans i Km")]
        public double? Distance { get; set; }

        [Display(Name = "Starttid")]
        public DateTime StartDateTime { get; set; }

        [Display(Name = "Sluttid")]
        public DateTime EndDateTime { get; set; }

        [Display(Name = "Tid H,xx")]
        
        public decimal Duration { get; set; }

    }
}
