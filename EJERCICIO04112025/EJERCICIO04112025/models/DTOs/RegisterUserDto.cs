using System.ComponentModel.DataAnnotations;

namespace EJERCICIO04112025.models.DTOs
{
    public class RegisterUserDto
    {
        [Required, MaxLength(100)]
        public string UserName { get; set; } = string.Empty;
        [Required, EmailAddress]
        public string Email { get; set; } = string.Empty;
        [Required]
        public string Password { get; set; } = string.Empty;
    }
}
