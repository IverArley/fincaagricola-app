﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;


namespace Logic
{

    public class ProveedoresLog
    {
        // Se crea una instancia de la clase Persistence para manejar la conexión a la base de datos.
        ProveedoresLog objPro = new ProveedoresLog();

        public DataSet showProveedor()
        {
            return objPro.showProveedor();
        }
    
        //Metodo para mostrar unicamente el id y el nombre
        public DataSet showProvedoresDDL()
        {
            return objPro.showProvedoresDDL();
        }

        public bool saveProveedor(string _nombre, string _contacto, string _tipo)
        {
            return objPro.saveProveedor(_nombre,  _contacto,  _tipo);
        }

        public bool updateProveedor(int _id, string _nombre, string _contacto, string _tipo)
        {
            return objPro.updateProveedor(_id,_nombre, _contacto, _tipo);
        }

        public bool deleteProveedor(int _id)
        {
            return objPro.deleteProveedor(_id);
        }
    }
}