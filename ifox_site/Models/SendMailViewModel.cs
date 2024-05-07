using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace ifox_site.Models
{
    public class SendMailViewModel
    {
        [Required]
        public string? Name { get; set; }

        [Required] 
        public string? Email { get; set; }

        [Required]
        public string Contact { get; set; }

        [Required]
        public string? Subject { get; set; }

        public IFormFile? Attachments { get; set; }

        [Required]
        public string? Message { get; set; }

        
    }
}
