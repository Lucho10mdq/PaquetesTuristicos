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
    public class ClientRepository : Singleton<ClientRepository>, IClient
    {
        private List<Client> ClientList = new List<Client>();
        static ClientRepository instance = null;
        SqlConnection conexion = new SqlConnection(@"Server=LAPTOP-7TTM2QIN;Database=Clientes;Trusted_Connection=True;");

        public int Add(Client oClient)
        {
            conexion.Open();
            SqlCommand c = conexion.CreateCommand();
            c.Connection = conexion;
            c.CommandType = CommandType.StoredProcedure;
            c.CommandText = "Add_Client";
            c.Parameters.AddWithValue("name", oClient.Name);
            c.Parameters.AddWithValue("lastName", oClient.Lastname);
            c.Parameters.AddWithValue("dni", oClient.Dni);
            c.Parameters.AddWithValue("addres", oClient.Address);
            c.Parameters.AddWithValue("birthdate", oClient.FechaNacimiento);

            int AffectRows = c.ExecuteNonQuery();
            conexion.Close();
            return AffectRows;
        }

        public List<Client> GetAll()
        {
            conexion.Open();
            SqlCommand c = conexion.CreateCommand();
            c.Connection = conexion;
            c.CommandType = CommandType.StoredProcedure;
            c.CommandText = "Get_Clients";
            SqlDataReader dn = c.ExecuteReader();
            c.Prepare();
            ClientList.Clear();
            while (dn.Read())
            {
                Client oClient = new Client();

                oClient.Name = dn.GetString(1);
                oClient.Lastname = dn.GetString(2);
                oClient.Dni= dn.GetString(3);
                oClient.Address = dn.GetString(4);
                oClient.FechaNacimiento = dn.GetDateTime(5);
               
                oClient.ClientId = dn.GetInt32(0);
                ClientList.Add(oClient);
            }
            dn.Close();
            conexion.Close();
            return ClientList;
        }

        public Client GetByDni(string dni)
        {
            Client oClient = null;
            conexion.Open();
            SqlCommand c = conexion.CreateCommand();
            c.CommandType = CommandType.StoredProcedure;
            c.CommandText = "Get_ClientByDni";

            SqlParameter DniParameter = c.CreateParameter();
            DniParameter.ParameterName = "@dni";
            DniParameter.SqlDbType = SqlDbType.VarChar;
            DniParameter.Value = dni;
            c.Parameters.Add(DniParameter);


            SqlDataReader dn = c.ExecuteReader();

            while (dn.Read())
            {
                oClient = new Client();

                oClient.Name = dn.GetString(1);
                oClient.Lastname = dn.GetString(2);
                oClient.Dni = dn.GetString(3);
                oClient.Address = dn.GetString(4);
                oClient.FechaNacimiento = dn.GetDateTime(5);

                oClient.ClientId = dn.GetInt32(0);

                oClient.ClientId = dn.GetInt32(0);
            }
            dn.Close();
            conexion.Close();
            return oClient;
        }

        public Client GetById(int id)
        {
            Client oClient = null;
            conexion.Open();
            SqlCommand c = conexion.CreateCommand();
            c.CommandType = CommandType.StoredProcedure;
            c.CommandText = "Get_ClientById";

            SqlParameter DniParameter = c.CreateParameter();
            DniParameter.ParameterName = "@id";
            DniParameter.SqlDbType = SqlDbType.VarChar;
            DniParameter.Value = id;
            c.Parameters.Add(DniParameter);


            SqlDataReader dn = c.ExecuteReader();

            while (dn.Read())
            {
                oClient = new Client();

                oClient.Name = dn.GetString(1);
                oClient.Lastname = dn.GetString(2);
                oClient.Dni = dn.GetString(3);
                oClient.Address = dn.GetString(4);
                oClient.FechaNacimiento = dn.GetDateTime(5);

                oClient.ClientId = dn.GetInt32(0);

                oClient.ClientId = dn.GetInt32(0);
            }
            dn.Close();
            conexion.Close();
            return oClient;
        }

        public int Modify(Client oCliente)
        {
            conexion.Open();
            SqlCommand c = conexion.CreateCommand();
            c.Connection = conexion;
            c.CommandType = CommandType.StoredProcedure;
            c.CommandText = "Update_Client";
            c.Parameters.AddWithValue("name", oCliente.Name);
            c.Parameters.AddWithValue("lastName", oCliente.Lastname);
            c.Parameters.AddWithValue("dni", oCliente.Dni);
            c.Parameters.AddWithValue("addres", oCliente.Address);
            c.Parameters.AddWithValue("birthdate", oCliente.FechaNacimiento);
            int affectedRows = c.ExecuteNonQuery();
            conexion.Close();
            return affectedRows;
        }
    }
}