using ApiClient.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiClient.Service
{
    interface IClient
    {
        bool Add(Client oClient);
        List<Client> GetAll();
        Client GetByDni(string dni);
        Client GetById(int dni);
        int Modify(Client oClient);
    }
}
