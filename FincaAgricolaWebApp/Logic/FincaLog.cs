using Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace Logic
{
    public class FincaLog
    {
        
        FincaDat objFin = new FincaDat();

 
        public DataSet showFinca()
        {
             
            return objFin.showFinca();
        }

        //Metodo para mostrar unicamente el id y el nombre
        public DataSet showFincaDDL()
        {
            return objFin.showFincaDDL();
        }

        //Metodo para guardar un nuevo finca
        public bool saveFinca(string _nombre, string _ubicacion, string _tamano)
        {
            return objFin.saveFinca(_nombre,  _ubicacion, _tamano);
        }

        //Metodo para actulizar un finca
        public bool updateFinca(int _id, string _nombre, string _ubicacion, string _tamano)
        {
            return objFin.updateFinca(_id, _nombre, _ubicacion, _tamano);
        }

        //Metodo para borrar una finca
        public bool deleteFinca(int _id)
        {
            return objFin.deleteFinca(_id);

        }
    }
}