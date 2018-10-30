using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ApiClient.Models
{
    public class Booking
    {
        int idBooking, idClient, idTouristPackage;
        DateTime bookingDate;

        public int IdBooking
        {
            get
            {
                return idBooking;
            }

            set
            {
                idBooking = value;
            }
        }

        public int IdClient
        {
            get
            {
                return idClient;
            }

            set
            {
                idClient = value;
            }
        }

        public int IdTouristPackage
        {
            get
            {
                return idTouristPackage;
            }

            set
            {
                idTouristPackage = value;
            }
        }

        public DateTime BookingDate
        {
            get
            {
                return bookingDate;
            }

            set
            {
                bookingDate = value;
            }
        }

        public Booking(int idClient, int idTouristPackage, DateTime bookingDate)
        {
            this.idClient = idClient;
            this.idTouristPackage = idTouristPackage;
            this.bookingDate = bookingDate;
        }
    }
}