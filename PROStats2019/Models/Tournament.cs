using HockeyStats2019.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PROStats2019.Models
{
    public class Tournament
    {
        public int Id { get; set; }

        //District (RefereeDistrict allready exsisting)
        [Display(Name = "Distrikt")]
        public int? RefereeDistrictId { get; set; }
        [Display(Name = "Distrikt")]
        [ForeignKey("RefereeDistrictId")]
        public RefereeDistrict District { get; set; }

        //TournamentName (Prolly just an GET)
        [Display(Name = "Turn.Namn")]
        public string TournamentName { get; set; }

        //TournamentPhase
        [Display(Name = "Turn.Fas")]
        public int? TournamentPhaseId { get; set; }
        [Display(Name = "Turn.Fas")]
        [ForeignKey("TournamentPhaseId")]
        public TournamentPhase TournamentPhase { get; set; }

        //SeriesNuber (Int stored here)
        [Display(Name ="Serienr")]
        public int? SeriesNumber { get; set; }

        
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
        
        //MatchReporting
        [Display(Name = "Matchrapporeting")]
        public int? MatchReportingId { get; set; }
        [Display(Name = "Matchrapportering")]
        [ForeignKey("MatchReportingId")]
        public MatchReporting MatchReporting { get; set; }

        // TableSystem
        [Display(Name = "TabellSystem")]
        public int? TableSystemId { get; set; }
        [Display(Name = "Tabellsystem")]
        [ForeignKey("TableSystemId")]
        public TableSystem TableSystem { get; set; }

        // RefereeLevel
        [Display(Name = "Domarnivå")]
        public int? RefereeLevelId { get; set; }
        [Display(Name = "Domarnivå")]
        [ForeignKey("RefereeLevelId")]
        public RefereeLevel RefereeLevel { get; set; }

        // TeamNotification(Yes,No)
        [Display(Name = "Laganmälan")]
        public int? TeamNotificationId { get; set; }
        [Display(Name = "Laganmälan")]
        [ForeignKey("TeamNotificationId")]
        public TeamNotification TeamNotification { get; set; }

        // TeamRegistration(Yes,No)
        [Display(Name = "Lagregistrering")]
        public int? TeamRegistrationId { get; set; }
        [Display(Name = "Lagregistrering")]
        [ForeignKey("TeamRegistrationId")]
        public TeamRegistration TeamRegistration { get; set; }

        //TeamOfficial
        [Display(Name = "Lagfuntionärer")]
        public int? TeamOfficialId { get; set; }
        [Display(Name = "Lagfuntionärer")]
        [ForeignKey("TeamOfficialId")]
        public TeamOfficial TeamOfficial { get; set; }

        //MatchTime(Ye, No)
        [Display(Name = "Lagfuntionärer")]
        public int? MatchTimeId { get; set; }
        [Display(Name = "Lagfuntionärer")]
        [ForeignKey("MatchTimeId")]
        public MatchTime MatchTime { get; set; }




    }
}
