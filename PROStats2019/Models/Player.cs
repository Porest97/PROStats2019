using System.ComponentModel.DataAnnotations;

namespace HockeyStats2019.Models
{
    public class Player
    {
        public int Id { get; set; }

        [Display(Name = "Spelar Status")]
        public string Status { get; set; }
    }
}