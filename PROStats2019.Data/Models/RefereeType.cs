﻿using System.ComponentModel.DataAnnotations;

namespace HockeyStats2019.Data.Models
{
    public class RefereeType
    {
        public int Id { get; set; }

        [Display(Name = "Domartyp")]
        public string RefereeTypeName { get; set; }
    }
}