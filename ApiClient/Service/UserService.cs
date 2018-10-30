using ApiClient.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ApiClient.Models;

namespace ApiClient.Service
{
    public class UserService:IUser
    {
        private UserRepository UserList = UserRepository.GetInstance();

        public bool AddUser(User oUser)
        {
            var result = false;
            if (UserList.GetUserByEmail(oUser.Email,oUser.Password) == null)
            {
                oUser.Activo = true;
                UserList.AddUser(oUser);
                result = true;
            }
            return result;
        }

        public User GetUserByEmail(string email, string password)
        {
            User oUser = null;
            var result = false;
            oUser = UserList.GetUserByEmail(email, password);

            if (oUser == null)
            {
                return oUser;

            }
            else
            {
                if (oUser.Activo == false)
                {
                    result = false;
                }
                else
                {
                    return oUser;
                }
            }
            return oUser;
        }
    }
}