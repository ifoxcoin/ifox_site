using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace ifox_site.Models
{
    public class SendMailViewModel
    {
        [Required(ErrorMessage = "Please enter your name.")]
        [StringLength(100, MinimumLength = 2)]
        public string? Name { get; set; }

        [Required(ErrorMessage = "Please enter your email address.")]
        [EmailAddress]
        public string? Email { get; set; }

        [Required(ErrorMessage = "Please enter your contact number.")]
        [Phone]
        [RegularExpression(@"^\+?[0-9][0-9\s().-]{6,24}$", ErrorMessage = "Please enter a valid contact number.")]
        public string? Contact { get; set; }

        [Required(ErrorMessage = "Please enter a subject.")]
        [StringLength(200, MinimumLength = 2)]
        public string? Subject { get; set; }

        public IFormFile? Attachments { get; set; }

        [StringLength(5000)]
        public string? Message { get; set; }

        
    }
}
