using System.ComponentModel.DataAnnotations;

namespace HockeyStats2019.Models
{
    public class Referee
    {
        public int Id { get; set; }

        [Display(Name ="Domarstatus")]
        public string Status { get; set; }

    }
}