using ApiClient.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiClient.Service
{
    interface IUser
    {
        User GetUserByEmail(string email, string password);
        bool AddUser(User oUser);
    }
}
