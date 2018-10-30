using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ApiClient.Models
{
    public class TouristPackage
    {
        int idPackage, quantity;
        double import;
        string description;
        DateTime checkOut, checkIn;

        public int IdPackage
        {
            get
            {
                return idPackage;
            }

            set
            {
                idPackage = value;
            }
        }

        public int Quantity
        {
            get
            {
                return quantity;
            }

            set
            {
                quantity = value;
            }
        }

        public double Import
        {
            get
            {
                return import;
            }

            set
            {
                import = value;
            }
        }

        public string Description
        {
            get
            {
                return description;
            }

            set
            {
                description = value;
            }
        }

        public DateTime CheckOut
        {
            get
            {
                return checkOut;
            }

            set
            {
                checkOut = value;
            }
        }

        public DateTime CheckIn
        {
            get
            {
                return checkIn;
            }

            set
            {
                checkIn = value;
            }
        }

        public TouristPackage(int quantity, double import, string description, DateTime checkOut, DateTime checkIn)
        {

            this.Quantity = quantity;
            this.Import = import;
            this.Description = description;
            this.CheckOut = checkOut;
            this.CheckIn = checkIn;
        }
    }
}