using System.ComponentModel.DataAnnotations;

namespace Usuarios.Models
{
    public class Usuario
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Nombre { get; set; }

        [Required]
        [EmailAddress]
        public string Emaill { get; set; }

        [Required]
        [StringLength(100)]
        public string Contrasena { get; set; }
    }
}
