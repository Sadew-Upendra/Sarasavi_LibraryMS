using Sarasavi_Library_MS.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sarasavi_Library_MS.DAO
{
    public interface IUserDAO
    {
        bool Save(User user);
        User FindById(string userId);
        List<User> FindAll();
        bool Update(User user);
        bool Delete(string userId);
        bool ExistsByNic(string nic);
        string GetNextUserId();
        bool SaveLogin(string username, string password, string role);
        bool DeleteLogin(string username);
    }
}
