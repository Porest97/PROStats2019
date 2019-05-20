using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LcvDB.Models
{
    public class Person : IdentityUser
    {
       

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string SsN { get; set; }

        public string Streetaddress { get; set; }

        public string ZipCode { get; set; }

        public string County { get; set; }

              
    }
}
