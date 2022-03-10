using System.ComponentModel.DataAnnotations;

namespace Backend_Mapanimal.Dtos
{
    public class CredentialsUser
    {
        [EmailAddress]
        [Required]
        public string Email { get; set;}
        [Required]
        public string Password { get; set;}
    }
}
