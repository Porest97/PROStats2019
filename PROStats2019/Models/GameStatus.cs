﻿using System.ComponentModel.DataAnnotations;

namespace PROStats2019.Models
{
    public class GameStatus
    {
        public int Id { get; set; }

        [Display(Name ="Status")]
        public string GameStatusName { get; set; }
    }
}