using System.ComponentModel.DataAnnotations;

namespace WebApCore070922.Models
{
    public class Doctor
    {
        [Key]
        public int ID { get; set; }
        [Required(ErrorMessage = "Must to type first First Name")]
        [MinLength(3, ErrorMessage = "Minimum lenght is 3")]
        public string? FirstName { get; set; }

        [Required(ErrorMessage = "Must to type first Last Name")]
        [MinLength(3, ErrorMessage = "Minimum lenght is 3")]
        public string? LastName { get; set; }

        [Required(ErrorMessage = "Must to type first Identity No")]

        public string? Specialty { get; set; }

        [Required(ErrorMessage = "Must to type first Age")]


       
        public int Age { get; set; }

        [Required(ErrorMessage = "Must to type first Address")]
        public string? Address { get; set; }

        [Required(ErrorMessage = "Must to type first Phone")]

        [StringLength(11, ErrorMessage = "Maximum lenght is 11")]
        public string? Phone { get; set; }

        public string? EmailId { get; set; }

    }
}
