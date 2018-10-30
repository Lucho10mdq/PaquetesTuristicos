using ApiClient.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiClient.Repository
{
    interface IClient
    {
        int Add(Client oClient);
        List<Client> GetAll();
        Client GetByDni(string dni);
        int Modify(Client oCliente);
    }
}
