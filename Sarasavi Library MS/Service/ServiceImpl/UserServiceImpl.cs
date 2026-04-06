using Sarasavi_Library_MS.DAO.DAOImpl;
using Sarasavi_Library_MS.DTO;
using Sarasavi_Library_MS.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sarasavi_Library_MS.Service.ServiceImpl
{
    public class UserServiceImpl : IUserService
    {
        private readonly UserDAOImpl _userDAO = new UserDAOImpl();

        public bool RegisterUser(UserDTO dto)
        {
            if (_userDAO.ExistsByNic(dto.NIC))
                throw new InvalidOperationException("A user with this NIC already exists.");

            dto.UserID = _userDAO.GetNextUserId();

            var user = new User
            {
                UserID = dto.UserID,
                FullName = dto.FullName,
                Sex = dto.Sex,
                NIC = dto.NIC,
                TelephoneNo = dto.TelephoneNo,
                Address = dto.Address,
                UserType = dto.UserType
            };

            if (!_userDAO.Save(user)) return false;

            // Create login: username = UserID, password = NIC
            _userDAO.SaveLogin(dto.UserID, dto.NIC, "user");
            return true;
        }

        public UserDTO GetUserById(string userId)
        {
            var user = _userDAO.FindById(userId);
            return user == null ? null : ToDTO(user);
        }

        public List<UserDTO> GetAllUsers()
        {
            return _userDAO.FindAll().ConvertAll(u => ToDTO(u));
        }

        public bool UpdateUser(UserDTO dto)
        {
            var user = new User
            {
                UserID = dto.UserID,
                FullName = dto.FullName,
                Sex = dto.Sex,
                NIC = dto.NIC,
                TelephoneNo = dto.TelephoneNo,
                Address = dto.Address,
                UserType = dto.UserType
            };
            return _userDAO.Update(user);
        }

        public bool DeleteUser(string userId) => _userDAO.Delete(userId);

        public string ValidateLogin(string username, string password) =>
            _userDAO.ValidateLogin(username, password);

        private static UserDTO ToDTO(User u) => new UserDTO
        {
            UserID = u.UserID,
            FullName = u.FullName,
            Sex = u.Sex,
            NIC = u.NIC,
            TelephoneNo = u.TelephoneNo,
            Address = u.Address,
            UserType = u.UserType
        };
    }
}
