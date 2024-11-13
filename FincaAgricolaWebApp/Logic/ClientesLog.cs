using Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace Logic
{
    public class ClientesLog
    {
        ClientesDat objClie = new ClientesDat();

        public DataSet showClientes()
        {
            return objClie.showClientes();
        }

        public DataSet showClientesDDL()
        {
            return objClie.showClientesDDL();
        }

        public bool saveClientes(string _nombre, string _telefono, string _direccion)
        {
            return objClie.saveClientes(_nombre, _telefono, _direccion);
        }

        public bool updateClientes(int _id, string _nombre, string _telefono, string _direccion)
        {
            return objClie.updateClientes(_id, _nombre, _telefono, _direccion);
        }

        public bool deleteClientes(int _id)
        {
            return objClie.deleteClientes(_id);
        }
    }
}