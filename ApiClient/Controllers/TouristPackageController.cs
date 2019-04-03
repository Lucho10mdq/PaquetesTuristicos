using ApiClient.Models;
using ApiClient.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ApiClient.Controllers
{
    [RoutePrefix("api/package")]
    public class TouristPackageController : ApiController
    {
        IPackage cs =  new ServicePackage();

        [Route("GetAll")]
        [HttpGet]
        public IEnumerable<TouristPackage> GetAll()
        {
            return cs.GetPackage();
        }

        [Route("AddPackage")]
        [HttpPost]
        public string AddPackage(TouristPackage oTourist)
        {
            var message = "agrege";
            cs.AddPackage(oTourist);
            return message;

        }
    }


}
