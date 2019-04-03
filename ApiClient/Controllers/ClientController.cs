using ApiClient.Models;
using ApiClient.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace ApiClient.Controllers
{
    [EnableCors(origins: "http://localhost:4200",headers:"*",methods:"*")]
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
        public bool AddClient(Client oCliente) { 
            var result = "No agrege";
            var resultado = false;
            resultado=cs.Add(oCliente);
            if (resultado == true)
            { result = "Agrege con exito";
                return resultado;
            }
            return resultado;
        }


        [Route("GetByDni/{dni}")]
        [HttpGet]
        public Client GetByDni(string dni)
        {
            var client= cs.GetByDni(dni);
            return client;
        }

        [Route("GetById/{id}")]
        [HttpGet]
        public Client GetById(int id)
        {
            var client = cs.GetById(id);
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
