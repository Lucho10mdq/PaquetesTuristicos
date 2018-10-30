using ApiClient.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiClient.Repository
{
    interface ITouristPackage
    {
        int AddPackage(TouristPackage oTouristPackage);
        List<TouristPackage> GetPackage();
        int ModifyPackage(TouristPackage oTouristPackage);
    }
}
