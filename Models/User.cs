using Azure.Core;
using System.ComponentModel.DataAnnotations;

namespace inventBackend.Models
{
    public class User
    {
        [Key]
        public string UserId { get; set; }

        [Required]
        public string Fname { get; set; }

        [Required]
        public string Lname { get; set; }

        public string Role { get; set; } = "employee";

        [Required]
        [EmailAddress]
        public string Email { get; set; }


        public string Position { get; set; }

        public bool IsDeleted { get; set; } = false;

        public ICollection<Request> Requests { get; set; } = new List<Request>();


    }

}
