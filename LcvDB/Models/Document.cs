using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LcvDB.Models
{
    public class Document
    {
        public int Id { get; set; }
        
        public string DocumentName { get; set; }
        public string DocumentDescription { get; set; }

        public DocumentType DocumentType { get; set; }


        [Display(Name = "Date Created")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd HHMM}")]
        [DataType(DataType.DateTime)]
        public DateTime TimeStamp { get; set; }

        [Display(Name = "Document Link")]
        public string Url { get; set; }

        [Display(Name = "Owner")]
        public IdentityUser IdentityUser { get; set; }
        public string IdentityUserId { get; set; }

        public bool IsAdmin { get; set; } = false;

      
    }
}
