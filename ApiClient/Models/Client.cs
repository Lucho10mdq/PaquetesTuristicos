using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ApiClient.Models
{
    public class Client
    {
        private int clientId;
        string name, lastname, dni, address;
        DateTime fechaNacimiento;

        public string Address
        {
            get
            {
                return address;
            }

            set
            {
                address = value;
            }
        }

        public int ClientId
        {
            get
            {
                return clientId;
            }

            set
            {
                clientId = value;
            }
        }

        public string Dni
        {
            get
            {
                return dni;
            }

            set
            {
                dni = value;
            }
        }

        public DateTime FechaNacimiento
        {
            get
            {
                return fechaNacimiento;
            }

            set
            {
                fechaNacimiento = value;
            }
        }

        public string Lastname
        {
            get
            {
                return lastname;
            }

            set
            {
                lastname = value;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }
    }
}