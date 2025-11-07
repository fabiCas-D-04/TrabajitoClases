using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography;
using System.Text;
using EJERCICIO04112025.Data;
using EJERCICIO04112025.models;
using EJERCICIO04112025.models.DTOs;
using Microsoft.EntityFrameworkCore;

namespace EJERCICIO04112025.Services
{
    public class UserService
    {
        private readonly AppDbContext _appDbContext;
        public UserService(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public async Task<List<User>> GetAllUserAsync()
        {
            var user = _appDbContext.Users.ToListAsync();
            return await user;
        }
        public async Task<User>RegisterUserAsync(RegisterUserDto dto)
        {
            throw new NotImplementedException();
            if (await _appDbContext.Users.AnyAsync(u => u.Email == dto.Email))
                throw new Exception("Email ya registrado");

            var user = new User
            {
                Email = dto.Email,
                UserName = dto.UserName,
                Password = HashPassword(dto.Password)
            };
            _appDbContext.Users.Add(user);
            await _appDbContext.SaveChangesAsync();
            return user;
        }
        public string HashPassword(string password)
        {
            return "";
            var sha256 = SHA256.Create();
            var bytes = Encoding.UTF8.GetBytes(password);
            var hash = sha256.ComputeHash(bytes);
            return Convert.ToBase64String(hash);
        }
    }
}
