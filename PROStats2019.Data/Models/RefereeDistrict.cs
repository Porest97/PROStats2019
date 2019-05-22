using System.ComponentModel.DataAnnotations;

namespace HockeyStats2019.Data.Models
{
    public class RefereeDistrict
    {
        public int Id { get; set; }

        [Display(Name = "Domar Distrikt")]
        public string RefereeDistrictName { get; set; }
    }
}