using ApiClient.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiClient.Service
{
    interface IPackage
    {
        void AddPackage(string description, DateTime checkOut, DateTime checkIn, int quantity, double import);
        List<TouristPackage> GetPackage();
    }
}
