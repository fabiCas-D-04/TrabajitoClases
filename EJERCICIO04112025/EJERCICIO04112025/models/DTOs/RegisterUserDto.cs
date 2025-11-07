using System.ComponentModel.DataAnnotations;

namespace EJERCICIO04112025.models.DTOs
{
    public class RegisterUserDto
    {
        // Este DTO solo es para registrar un nuevo usuario
        // No necesita el Id porque es generado por la base de datos
        [Required, MaxLength(100)]
        public string UserName { get; set; } = string.Empty;

        [Required, EmailAddress]
        public string Email { get; set; } = string.Empty;

        [Required]
        public string Password { get; set; } = string.Empty;
    }

    // Esta clase es para actualizar un usuario existente mediante el ID
    public class UpdateUserDto
    {
        public int Id { get; set; }

        [Required, MaxLength(100)]
        public string UserName { get; set; } = string.Empty;

        [Required, EmailAddress]
        public string Email { get; set; } = string.Empty;
        [Required]
        public string Password { get; set; } = string.Empty;
    }
}
