using Data;
using System;
using System.Data;

namespace Logic
{
    public class VentasLog
    {
        VentasDat objVen = new VentasDat();

        public DataSet showVentas()
        {
            return objVen.showVentas();
        }

        // Método para mostrar únicamente el ID y el nombre
        public DataSet showVentassDDL()
        {
            return objVen.showVentassDDL();
        }

        // Método para guardar una nueva venta
        public bool saveVentas(int clieId, DateTime _fecha, decimal _monto)
        {
            return objVen.saveVentas(clieId, _fecha, _monto);
        }

        // Método para actualizar una venta
        public bool updateVentas(int _id, int clieId, DateTime _fecha, decimal _monto)
        {
            return objVen.updateVentas(_id, clieId, _fecha, _monto);
        }

        // Método para borrar una venta
        public bool deleteVentas(int _id)
        {
            return objVen.deleteVentas(_id);
        }
    }
}
