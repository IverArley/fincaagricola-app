using Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace Logic
{
    public class VentasLog
    {
        VentasDat objVen = new VentasDat();


        public DataSet showVentas()
        {

            return objVen.showVentas();
        }

        //Metodo para mostrar unicamente el id y el nombre
        public DataSet showVentassDDL()
        {
            return objVen.showVentassDDL();
        }

        //Metodo para guardar un nuevo finca
        public bool saveVentas(DateTime _fecha, double _monto)
        {
            return objVen.saveVentas(_fecha, _monto);
        }

        //Metodo para actulizar un finca
        public bool updateVentas(int _id, DateTime _fecha, double _monto, int clieId)
        {
            return objVen.updateVentas(_id, _fecha, _monto, clieId);
        }

        //Metodo para borrar una finca
        public bool deleteFinca(int _id)
        {
            return objVen.deleteFinca(_id);

        }
    }
}