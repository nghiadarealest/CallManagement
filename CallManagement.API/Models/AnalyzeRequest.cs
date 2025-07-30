using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace CallManagement.API.Models
{
    public class AnalyzeRequest
    {
        [Required]
        public IFormFile Audio { get; set; }
    }
}
