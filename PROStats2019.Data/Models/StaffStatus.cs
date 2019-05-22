using System.ComponentModel.DataAnnotations;

namespace HockeyStats2019.Data.Models
{
    public class StaffStatus
    {
        public int Id { get; set; }

        [Display(Name = "Personal Status")]
        public string Status { get; set; }
    }
}