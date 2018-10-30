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
    [RoutePrefix("api/clients")]
    public class ClientController : ApiController
    {
        
        IClient cs = new ClientService();


        [Route("GetAll")]
        [HttpGet]
        public IEnumerable<Client> GetAll()
        {
            return cs.GetAll();
        }
        [Route("AddClient")]
        [HttpPost]
        public string AddClient(Client oCliente) { 
            var msj = "No agrege";
            var result = false;
            result=cs.Add(oCliente);
            if (result == true)
            { msj = "Agrege con exito";
                return msj;
            }
            return msj;
        }


        [Route("GetByDni/{dni}")]
        [HttpGet]
        public Client GetByDni(string dni)
        {
            var client= cs.GetByDni(dni);
            return client;
        }

        [Route("ModifyClient")]
        [HttpPost]
        public string ModifyClient(Client oClient)
        {
            var msj = "no se modificaron datos";
            int resul=cs.Modify(oClient);
            if (resul == 1)
                msj = "se modifico con exito";
            return msj;
        }
    }
}
