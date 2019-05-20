using PROStats2019.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HockeyStats2019.Models
{
    public class Person
    {
        public int Id { get; set; }
        //Person props
        [Display(Name = "Förnamn")]
        public string FirstName { get; set; }

        [Display(Name = "Efternamn")]
        public string LastName { get; set; }

        public string FullName { get { return string.Format("{0} {1} ", FirstName, LastName); } }

        [Display(Name = "Gatuadress")]
        public string StreetAddress { get; set; }

        [Display(Name = "Post Nr")]
        [DataType(DataType.PostalCode)]
        public string ZipCode { get; set; }

        [Display(Name = "Post Ort")]
        public string County { get; set; }

        [Display(Name = "Land")]
        public string Country { get; set; }

        [Display(Name = "Adress")]
        public string Address { get { return string.Format("{0} {1} {2}", StreetAddress, ZipCode, County); } }

        [Display(Name = "Personnummer")]
        public string Ssn { get; set; }

        [Display(Name = "Telefonnummer")]
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }

        [Display(Name = "E-Post")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Display(Name = "Klubb")]
        public int? ClubId { get; set; }
        [Display(Name = "Klubb")]
        public Club Club { get; set; }

        //Refereerelated props
        [Display(Name = "Domare")]
        public string RefString { get { return string.Format("{0} {1} {2}", FirstName, LastName, County); } }
        

        [Display(Name = "Domarnummer")]
        public int? RefereeNumber { get; set; }

        [Display(Name = "Domartyp")]
        public RefereeType RefereeType { get; set; }
        public int? RefereeTypeId { get; set; }


        [Display(Name = "Domarkategori")]
        public RefereeCategory RefereeCategory { get; set; }
        public int? RefereeCategoryId { get; set; }

        [Display(Name = "Domarkategori Typ")]
        public RefereeCategoryType RefereeCategoryType { get; set; }
        public int? RefereeCategoryTypeId { get; set; }

        [Display(Name = "Domardistrikt")]
        public RefereeDistrict RefereeDistrict { get; set; }
        public int? RefereeDistrictId { get; set; }

        //Person role related props !
        [Display(Name = "Domar Status")]
        public int? RefereeId { get; set; }
        [Display(Name = "Domar Status")]
        public Referee Referee { get; set; }

        [Display(Name = "Tränar Status")]
        public int? CoachId { get; set; }
        [Display(Name = "Tränar Status")]
        public Coach Coach { get; set; }
                       
        [Display(Name = "Spelar Status")]
        public int? PlayerId { get; set; }
        [Display(Name = "Spelar Status")]
        public Player Player { get; set; }

        [Display(Name = "Personal Status")]
        public int? StaffId { get; set; }
        [Display(Name = "Personal Status")]
        public Staff Staff { get; set; }
    }
}
