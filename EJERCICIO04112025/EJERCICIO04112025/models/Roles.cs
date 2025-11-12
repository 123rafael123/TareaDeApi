using System.ComponentModel.DataAnnotations;

namespace EJERCICIO04112025.models
{
    public class Roles
    {
        public int Id { get; set; }
        [Required, MaxLength(100)]
        public string Name { get; set; } = string.Empty;
        [Required, EmailAddress]
        public bool Estado { get; set; }
        [Required]
        public string Descripcion { get; set; } = string.Empty;
        public ICollection<User> Users { get; set; }
    }
    }
