
using System.ComponentModel.DataAnnotations;

namespace ejercicio611.Models
{
    public class Roles
    {
        public int Id { get; set; }
       
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } 

        public bool IsDeleted { get; set; } = false;
        public List<User> Users { get; set; } = new();


    }
}
