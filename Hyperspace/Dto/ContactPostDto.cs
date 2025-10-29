using System.ComponentModel.DataAnnotations;

namespace Hyperspace.Dto
{
    public class ContactPostDto
    {

        [Required]
        public string Phone { get; set; }
        [Required]
        public string Subject { get; set; }
        [EmailAddress]
        [Required]
        public string Email { get; set; }
        [MaxLength(30),MinLength(3)]
        public string Name { get; set; }
        [Required]
        public string Message { get; set; }
    }
}
