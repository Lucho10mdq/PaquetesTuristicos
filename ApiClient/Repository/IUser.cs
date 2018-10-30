using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ApiClient.Models;

namespace ApiClient.Repository
{
    interface IUser
    {
        User GetUserByEmail(string email, string password);
        int AddUser(User oUser);
        List<User> GetUser();
    }
}
