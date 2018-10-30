using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using ApiClient.Models;

namespace ApiClient.Repository
{
    public class PackageRepository : Singleton<PackageRepository>,ITouristPackage
    {
        private List<TouristPackage> ListPackage = new List<TouristPackage>();
        static PackageRepository instance = null;
        SqlConnection conexion = new SqlConnection(@"Server=LAPTOP-7TTM2QIN;Database=Clientes;Trusted_Connection=True;");

        public int AddPackage(TouristPackage oTouristPackage)
        {
            conexion.Open();
            SqlCommand c = conexion.CreateCommand();
            c.Connection = conexion;
            c.CommandType = CommandType.StoredProcedure;
            c.CommandText = "Add_Package";
            c.Parameters.AddWithValue("description", oTouristPackage.Description);
            c.Parameters.AddWithValue("checkOut", oTouristPackage.CheckOut);
            c.Parameters.AddWithValue("checkIn", oTouristPackage.CheckIn);
            c.Parameters.AddWithValue("quantity", oTouristPackage.Quantity);
            c.Parameters.AddWithValue("import", oTouristPackage.Import);
            int AffectedRow = c.ExecuteNonQuery();
            conexion.Close();
            return AffectedRow;
        }

        public List<TouristPackage> GetPackage()
        {
            conexion.Open();
            SqlCommand c = conexion.CreateCommand();
            c.Connection = conexion;
            c.CommandType = CommandType.StoredProcedure;
            c.CommandText = "Get_Package";
            SqlDataReader dn = c.ExecuteReader();
            ListPackage.Clear();
            while (dn.Read())
            {
                string descripcion = dn.GetString(1);
                DateTime chekIn = dn.GetDateTime(3);
                DateTime chekOut = dn.GetDateTime(2);
                double import = dn.GetDouble(5);
                int cantidad = dn.GetInt32(4);
                TouristPackage oTourist = new TouristPackage(cantidad, import, descripcion, chekOut, chekIn);
                oTourist.IdPackage = dn.GetInt32(0);
                ListPackage.Add(oTourist);
            }
            dn.Close();
            conexion.Close();
            return ListPackage;
        }

        public int ModifyPackage(TouristPackage oTouristPackage)
        {
            throw new NotImplementedException();
        }
    }
}