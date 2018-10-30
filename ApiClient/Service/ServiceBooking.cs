using ApiClient.Models;
using ApiClient.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ApiClient.Service
{
    public class ServiceBooking : IBooking
    {
        private BookingRepository ListBooking = BookingRepository.GetInstance();

        public void AddBooking(int idClient, int idTourist, DateTime BookingDate)
        {
            Booking oBooking = new Booking(idClient, idTourist, BookingDate);
            ListBooking.AddBooking(oBooking);
        }
    }
}