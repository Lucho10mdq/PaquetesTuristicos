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

        public void AddPackage(TouristPackage oTourist)
        {
            ListPackage.AddPackage(oTourist);
        }

        public List<TouristPackage> GetPackage()
        {
            return ListPackage.GetPackage();
        }
    }
}