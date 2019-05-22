using System.ComponentModel.DataAnnotations;

namespace HockeyStats2019.Data.Models
{
    public class RefereeCategory
    {
        public int Id { get; set; }

        [Display(Name = "Domar Kategori")]
        public string RefereeCategoryName { get; set; }
    }
}