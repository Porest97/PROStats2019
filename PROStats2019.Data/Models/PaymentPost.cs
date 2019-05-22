using HockeyStats2019.Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PROStats2019.Data.Models
{
    public class PaymentPost
    {
        public int Id { get; set; }
        //Game props !
        [Display(Name = "Match")]
        public int? GameId { get; set; }
        [Display(Name = "Match")]
        [ForeignKey("GameId")]
        public Game Game { get; set; }

        //Referees participating in the Game !
        [Display(Name = "HD1")]
        public int? PersonId { get; set; }
        [Display(Name = "HD1")]
        [ForeignKey("PersonId")]
        public Person Referee1 { get; set; }

        [Display(Name = "HD2")]
        public int? PersonId1 { get; set; }
        [Display(Name = "HD2")]
        [ForeignKey("PersonId1")]
        public Person Referee2 { get; set; }

        [Display(Name = "LD1")]
        public int? PersonId2 { get; set; }
        [Display(Name = "LD1")]
        [ForeignKey("PersonId2")]
        public Person Referee3 { get; set; }

        [Display(Name = "LD2")]
        public int? PersonId3 { get; set; }
        [Display(Name = "LD2")]
        [ForeignKey("PersonId3")]
        public Person Referee4 { get; set; }
        /// <summary>
        /// Over this post Person props !
        /// </summary>
        //TravelFee / Km !
        [Display(Name = "Reseersättning / km")]
        [DataType(DataType.Currency)]
        public double? TravelFeePerKm { get; } = 3;

        //Payment HD1 !
        [Display(Name = "Arvode HD1")]
        [DataType(DataType.Currency)]
        public double? FeeHD1 { get; set; }

        [Display(Name = "Traktamente HD1")]
        [DataType(DataType.Currency)]
        public double? AlowenceHD1 { get; set; }        

        [Display(Name = "Resa i km HD1")]
        public double? TravelDistanceHD1 { get; set; }
        
        [Display(Name = "Resa HD1")]
        [DataType(DataType.Currency)]
        public double? TravelCostHD1 { get; set; }

        [Display(Name = "Sen Matchstart HD1")]
        [DataType(DataType.Currency)]
        public double? LateMatchStartHD1 { get; set; }

        [Display(Name = "Att Betala HD1")]
        [DataType(DataType.Currency)]
        public double? TotalPaymentHD1 { get; set; }

        //Payment HD2 !
        [Display(Name = "Arvode HD2")]
        [DataType(DataType.Currency)]
        public double? FeeHD2 { get; set; }

        [Display(Name = "Traktamente HD2")]
        [DataType(DataType.Currency)]
        public double? AlowenceHD2 { get; set; }        

        [Display(Name = "Resa i km HD2")]
        public double? TravelDistanceHD2 { get; set; }

        [Display(Name = "Resa HD2")]
        [DataType(DataType.Currency)]
        public double? TravelCostHD2 { get; set; }

        [Display(Name = "Sen Matchstart HD2")]
        [DataType(DataType.Currency)]
        public double? LateMatchStartHD2 { get; set; }

        [Display(Name = "Att Betala HD2")]
        [DataType(DataType.Currency)]
        public double? TotalPaymentHD2 { get; set; }

        //Payment LD1 !
        [Display(Name = "Arvode LD1")]
        [DataType(DataType.Currency)]
        public double? FeeLD1 { get; set; }

        [Display(Name = "Traktamente LD1")]
        [DataType(DataType.Currency)]
        public double? AlowenceLD1 { get; set; }

        [Display(Name = "Resa i km LD1")]
        public double? TravelDistanceLD1 { get; set; }

        [Display(Name = "Resa LD1")]
        [DataType(DataType.Currency)]
        public double? TravelCostLD1 { get; set; }

        [Display(Name = "Sen Matchstart LD1")]
        [DataType(DataType.Currency)]
        public double? LateMatchStartLD1 { get; set; }

        [Display(Name = "Att Betala LD1")]
        [DataType(DataType.Currency)]
        public double? TotalPaymentLD1 { get; set; }

        //Payment LD2 !
        [Display(Name = "Arvode LD2")]
        [DataType(DataType.Currency)]
        public double? FeeLD2 { get; set; }

        [Display(Name = "Traktamente LD2")]
        [DataType(DataType.Currency)]
        public double? AlowenceLD2 { get; set; }

        [Display(Name = "Resa i km LD2")]
        public double? TravelDistanceLD2 { get; set; }

        [Display(Name = "Resa LD1")]
        [DataType(DataType.Currency)]
        public double? TravelCostLD2 { get; set; }

        [Display(Name = "Sen Matchstart LD1")]
        [DataType(DataType.Currency)]
        public double? LateMatchStartLD2 { get; set; }

        [Display(Name = "Att Betala LD2")]
        [DataType(DataType.Currency)]
        public double? TotalPaymentLD2 { get; set; }     



    }
}
