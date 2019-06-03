using System.ComponentModel.DataAnnotations;

namespace PROStats2019.Models
{
    public class TableSystem
    {
        public int Id { get; set; }

        [Display(Name ="Tabell")]
        public string TableSystemName { get; set; }
    }
}