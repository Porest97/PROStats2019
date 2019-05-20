using System.ComponentModel.DataAnnotations;

namespace HockeyStats2019.Models
{
    public class Coach
    {
        public int Id { get; set; }

        [Display(Name = "Tränar Status")]
        public string Status { get; set; }
    }
}