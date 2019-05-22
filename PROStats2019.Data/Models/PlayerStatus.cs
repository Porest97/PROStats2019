using System.ComponentModel.DataAnnotations;

namespace HockeyStats2019.Data.Models
{
    public class PlayerStatus
    {
        public int Id { get; set; }

        [Display(Name = "Spelar Status")]
        public string Status { get; set; }
    }
}