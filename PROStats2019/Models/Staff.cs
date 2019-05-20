using System.ComponentModel.DataAnnotations;

namespace HockeyStats2019.Models
{
    public class Staff
    {
        public int Id { get; set; }

        [Display(Name = "Personal Status")]
        public string Status { get; set; }
    }
}