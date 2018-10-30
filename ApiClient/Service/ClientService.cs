using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ApiClient.Models;
using ApiClient.Repository;

namespace ApiClient.Service
{
    public class ClientService : IClient
    {
        private ClientRepository listClient = ClientRepository.GetInstance();
        public bool Add(Client oCliente)
        {
            var result = false;
            Client aux;
            Client cliente = oCliente;
            aux = GetByDni(oCliente.Dni);
            if (aux == null)
            {
                listClient.Add(cliente);
                return true;
            }
            else
                return false;    
        }

        public List<Client> GetAll()
        {
            return listClient.GetAll();
        }

        public Client GetByDni(string dni)
        {
            Client oClient = null;
            return oClient = listClient.GetByDni(dni);
        }

        public int Modify(Client oCliente)
        {
            int resul;
            Client cliente = oCliente;
            resul=listClient.Modify(oCliente);
            return resul;
        }
    }
}