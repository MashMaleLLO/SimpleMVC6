using System.ComponentModel.DataAnnotations;
namespace CultureTravelSimple.Data
{
    public class User
    {
        [Required]
        public int ID { get; set; }

        [Required]
        public string? Username { get; set; }

        [Required]
        public string? Password { get; set; }

        [Required]
        public string? Is_Admin { get; set; }

        [Required]
        public string? Is_Ban { get; set; }
    }
}
