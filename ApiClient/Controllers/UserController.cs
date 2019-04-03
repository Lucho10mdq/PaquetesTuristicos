using ApiClient.Models;
using ApiClient.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace ApiClient.Controllers
{
    [EnableCors(origins: "http://localhost:4200", headers: "*", methods: "*")]
    [RoutePrefix("api/User")]
    public class UserController : ApiController
    {
        IUser cs = new UserService();

        [Route("UserAdd")]
        [HttpPost]
        public bool UserAdd(User oUser)
        {
            var result = false;
            result=cs.AddUser(oUser);
            return result;
        }

        [Route("GetUserByEmail")]
        [HttpPost]
        public User GetUserByEmail(User oUser)
        {
            string email = oUser.Email;
            string password = oUser.Password;

            User aux;
            aux = cs.GetUserByEmail(email, password);

            if (aux != null)
                return aux;
            return aux;    
        }
    }
}
