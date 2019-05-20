using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LcvDB.Models
{
    public class Company
    {
        public int Id { get; set; }

        public string CompanyName { get; set; }

        public IdentityUser CompanyContact { get; set; }
        public string IdentityUserId { get; set; }

        public string CompanyEmail { get; set; }

        public string CompanyStreetAddress { get; set; }
        public string CompanyZipCode { get; set; }
        public string CompanyWebSite { get; set; }
        public string CompanyCounty { get; set; }
        public string CompanyCountry { get; set; }
        public CompanyType CompanyType { get; set; }
        
    }
}
