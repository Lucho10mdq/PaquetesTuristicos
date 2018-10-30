using ApiClient.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ApiClient.Models;

namespace ApiClient.Service
{
    public class ServicePackage:IPackage
    {
        private PackageRepository ListPackage = PackageRepository.GetInstance();

        public void AddPackage(string description, DateTime checkOut, DateTime checkIn, int quantity, double import)
        {
            TouristPackage oTourist = new TouristPackage(quantity, import, description, checkOut, checkIn);
            ListPackage.AddPackage(oTourist);
        }

        public List<TouristPackage> GetPackage()
        {
            return ListPackage.GetPackage();
        }
    }
}