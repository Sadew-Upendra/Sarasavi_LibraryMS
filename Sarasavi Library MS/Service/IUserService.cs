using Sarasavi_Library_MS.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sarasavi_Library_MS.Service
{
    public interface IUserService
    {
        bool RegisterUser(UserDTO dto);
        UserDTO GetUserById(string userId);
        List<UserDTO> GetAllUsers();
        bool UpdateUser(UserDTO dto);
        bool DeleteUser(string userId);
        string ValidateLogin(string username, string password); // returns role or null

        bool UpdatePassword(string userId, string currentPassword, string newPassword);
    }
}
