using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Epitec_Assignment.Data
{
    public class Contact
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        [StringLength(250, ErrorMessage = "First name cannot exceed 250 characters.")]
        public string? FirstName { get; set; }
        [Required]
        [StringLength(250, ErrorMessage = "Last name cannot exceed 250 characters.")]
        public string? LastName { get; set; }

        [StringLength(15, ErrorMessage = "Phone number cannot exceed 15 characters.")]
        public string? PhoneNumber { get; set; }

        public DateTime BirthDate { get; set; }
    }
}
