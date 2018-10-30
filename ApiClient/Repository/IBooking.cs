using ApiClient.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiClient.Repository
{
    interface IBooking
    {
        int AddBooking(Booking oBooking);
        int ModifyBooking(Booking oBooking);
    }
}
