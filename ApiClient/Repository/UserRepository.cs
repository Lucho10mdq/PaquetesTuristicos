using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ApiClient.Models;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace ApiClient.Repository
{
    public class UserRepository : Singleton<UserRepository>, IUser
    {
        private List<User> UserList = new List<User>();
        static UserRepository instance = null;
        SqlConnection conexion = new SqlConnection(@"Server=LAPTOP-7TTM2QIN;Database=Clientes;Trusted_Connection=True;");

        public int AddUser(User oUser)
        {
            conexion.Open();
            SqlCommand c = conexion.CreateCommand();
            c.CommandType = CommandType.StoredProcedure;
            c.CommandText = "Add_User";
            c.Parameters.AddWithValue("name", oUser.Name);
            c.Parameters.AddWithValue("email", oUser.Email);
            c.Parameters.AddWithValue("password", oUser.Password);
            c.Parameters.AddWithValue("activo", oUser.Activo);
            int Affecterows = c.ExecuteNonQuery();
            conexion.Close();
            return Affecterows;
        }

        public List<User> GetUser()
        {
            throw new NotImplementedException();
        }

        public User GetUserByEmail(string email, string password)
        {
            User oUser = null;
            conexion.Open();

            SqlCommand c = conexion.CreateCommand();
            c.CommandType = CommandType.StoredProcedure;
            c.CommandText = "Get_UserByEmail";

            SqlParameter EmailParemeter = c.CreateParameter();
            EmailParemeter.ParameterName = "@email";
            EmailParemeter.SqlDbType = SqlDbType.VarChar;
            EmailParemeter.Value = email;
            c.Parameters.Add(EmailParemeter);

            SqlParameter PasswordParameter = c.CreateParameter();
            PasswordParameter.ParameterName = "@password";
            PasswordParameter.SqlDbType = SqlDbType.VarChar;
            PasswordParameter.Value = password;
            c.Parameters.Add(PasswordParameter);
            SqlDataReader dn = c.ExecuteReader();

            while (dn.Read())
            {
                oUser = new User();
                oUser.Name = dn.GetString(1);
                oUser.Email = dn.GetString(2);
                oUser.Password = dn.GetString(3);
               oUser.Activo = dn.GetBoolean(4);
              
                oUser.UserId = dn.GetInt32(0);
            }
            dn.Close();
            conexion.Close();
            return oUser;
        }
    }
}