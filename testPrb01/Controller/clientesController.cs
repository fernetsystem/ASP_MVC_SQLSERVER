using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using testPrb01.Models;

namespace testPrb01.Controller
{
    public class clientesController
    {
        ClientesImpl clientesImpl = new ClientesImpl();
        public int saveClient(Clientes cl)
        {
            return clientesImpl.insertClient(cl);
        }

        public IEnumerable<Clientes> getAllClients()
        {
            return clientesImpl.listClient();
        }
    }
}