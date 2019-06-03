using HockeyStats2019.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PROStats2019.Models
{
    public class RefereeFee
    {
        public int Id { get; set; }

        [Display(Name = "Arvode")]
        public string FeeName { get { return string.Format("{0} {1} {2}",Series.SeriesName,"-",MatchLength.MatchLengthName); } }

        //Series (SeriesName)
        [Display(Name = "Serienamn")]
        public int? SeriesId { get; set; }
        [Display(Name = "Serienamn")]
        [ForeignKey("SeriesId")]
        public Series Series { get; set; }

        //MatchLength
        [Display(Name = "Matchlängd")]
        public int? MatchLengthId { get; set; }
        [Display(Name = "Matchlängd")]
        [ForeignKey("MatchLengthId")]
        public MatchLength MatchLength { get; set; }

        [Display(Name = "Domartyp")]
        public RefereeType RefereeType { get; set; }
        public int? RefereeTypeId { get; set; }

        [Display(Name ="Belopp")]
        [DataType(DataType.Currency)]
        public decimal FeeValue { get; set; }
    }
}
