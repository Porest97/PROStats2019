using System.ComponentModel.DataAnnotations;

namespace HockeyStats2019.Data.Models
{
    public class CoachStatus
    {
        public int Id { get; set; }

        [Display(Name = "Tränar Status")]
        public string Status { get; set; }
    }
}