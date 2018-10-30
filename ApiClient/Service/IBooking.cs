using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApiClient.Models;

namespace ApiClient.Service
{
    interface IBooking
    {
        void AddBooking(int idClient, int idTourist, DateTime BookingDate);
    }
}
