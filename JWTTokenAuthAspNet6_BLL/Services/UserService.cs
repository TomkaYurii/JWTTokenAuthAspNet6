using JWTTokenAuthAspNet6_BLL.Contract;
using JWTTokenAuthAspNet6_BLL.Model;
using JWTTokenAuthAspNet6_DAL.Constants;
using JWTTokenAuthAspNet6_DAL.Data;
using JWTTokenAuthAspNet6_DAL.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JWTTokenAuthAspNet6_BLL.Services
{
    public class UserService : IUserService
    {
        private readonly AppDbContext _context;
        private readonly UserManager<AppUser> _userManager;
        private readonly RoleManager<IdentityRole> _rolemanager;
        public UserService(AppDbContext context, 
            UserManager<AppUser> userManager, 
            RoleManager<IdentityRole> rolemanager)
        {
            _context = context;
            _userManager = userManager;
            _rolemanager = rolemanager;
        }

        public Task<string> AddRoleAsync(AddModelDTO model)
        {
            throw new NotImplementedException();
        }

        public AppUser GetById(string id)
        {
            throw new NotImplementedException();
        }

        public Task<AuthentificationDTO> GetTokenAsync(TokenRequestDTO model)
        {
            throw new NotImplementedException();
        }

        public Task<AuthentificationDTO> RefreshTokenAsync(string model)
        {
            throw new NotImplementedException();
        }

        public async Task<string> RegisterAsync(RegisterModelDTO model)
        {
            var user = new AppUser
            {
                UserName = model.UserName,
                Email = model.Email,
                FirstName = model.FirstName,
                LastName = model.LastName
            };
            var userWithSameEmail = await _userManager.FindByEmailAsync(user.Email);
            if (userWithSameEmail == null)
            {
               var result = await _userManager.CreateAsync(user, model.Password);
                if (result.Succeeded)
                {
                    await _userManager.AddToRoleAsync(user, Authorization.default_role.ToString());
                }
                return $"User REGISTERED! with username {user.UserName}";
            }
            else
            {
             return $"User is already REGISTERED! ";
            }
        }

        public bool RevokeToken(string token)
        {
            throw new NotImplementedException();
        }
    }
}
