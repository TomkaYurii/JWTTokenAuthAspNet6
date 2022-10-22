using JWTTokenAuthAspNet6_BLL.Model;
using JWTTokenAuthAspNet6_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JWTTokenAuthAspNet6_BLL.Contract
{
    public interface IUserService
    {
        Task<string> RegisterAsync(RegisterModelDTO model);
        Task<AuthentificationDTO> GetTokenAsync(TokenRequestDTO model);
        Task<string> AddRoleAsync(AddModelDTO model);
        Task<AuthentificationDTO> RefreshTokenAsync (string model);
        bool RevokeToken (string token);
        AppUser GetById(string id);
    }
}
