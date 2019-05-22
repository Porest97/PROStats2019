using System.ComponentModel.DataAnnotations;

namespace HockeyStats2019.Data.Models
{
    public class RefereeStatus
    {
        public int Id { get; set; }

        [Display(Name ="Domarstatus")]
        public string Status { get; set; }

    }
}