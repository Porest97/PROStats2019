using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HockeyStats2019.Models
{
    public class Arena
    {
        public int Id { get; set; }

        [Display(Name = "Arena")]        
        public string ArenaString { get { return string.Format("{0} {1} {2}", ArenaName, "-", ArenaCounty); } }

        [Display(Name = "Plats")]        
        public string LocationString { get { return string.Format("{0} {1}", ArenaName, ArenaAddress); } }

        [Display(Name = "Arena")]
        public string ArenaName { get; set; }

        [Display(Name = "Gatuadress")]
        public string ArenaStreetAddress { get; set; }

        [Display(Name = "Post Nr")]
        [DataType(DataType.PostalCode)]
        public string ArenaZipCode { get; set; }

        [Display(Name = "Post Ort")]
        public string ArenaCounty { get; set; }

        [Display(Name = "Land")]
        public string ArenaCountry { get; set; }

        [Display(Name = "Adress")]        
        public string ArenaAddress { get { return string.Format("{0} {1} {2} {3}",ArenaStreetAddress, ArenaZipCode, ArenaCounty, ArenaCountry); } }

        [Display(Name = "Distrikt")]
        public RefereeDistrict RefereeDistrict { get; set; }
        public int? RefereeDistrictId { get; set; }

        [Display(Name = "Kategori")]
        public ArenaCategory ArenaCategory { get; set; }
        public int? ArenaCategoryId { get; set; }

        [Display(Name = "Telefonnummer1")]
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }

        [Display(Name = "Telefonnummer2")]
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber1 { get; set; }

        public string PhoneNumbers { get { return string.Format("{0} {1} ", PhoneNumber, PhoneNumber1); } }

        [Display(Name = "Publik #")]
        public string AudienceCapacity { get; set; }

        [Display(Name = "Ståplats")]
        public string Standing { get; set; }

        [Display(Name = "Bänk")]
        public string Bench { get; set; }

        [Display(Name = "Stol")]
        public string Chair { get; set; }

        [Display(Name = "Mjuk stol")]
        public string SoftChair { get; set; }

        [Display(Name = "Handikapp #")]
        public string DisabledSeats { get; set; }

        [Display(Name = "Byggår")]
        public string BuildingYear { get; set; }

        [Display(Name = "Ombyggnadsår")]
        public string RebuildingYear { get; set; }

        [Display(Name = "Senaste Insp.")]
        public string LatestInspection { get; set; }

        [Display(Name = "Senaste Kontr.")]
        public string LatestChecked { get; set; }

        [Display(Name = "Arena TSM #")]
        public string ArenaNumberTSM { get; set; }



    }
}
