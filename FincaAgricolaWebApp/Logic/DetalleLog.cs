using Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace Logic
{
    public class DetalleLog
    {
        DetalleDat objDetVenta = new DetalleDat();

        // Método para mostrar todos los detalles de ventas
        public DataSet showDetalle_Ventas()
        {
            return objDetVenta.showDetalle_Ventas();
        }

        // Método para guardar un nuevo detalle de venta
        public bool saveDetalle_Venta(int _venId, int _prodId, int _cantidad)
        {
            return objDetVenta.saveDetalle_ventas(_venId, _prodId, _cantidad);
        }

        // Método para actualizar un detalle de venta
        public bool updateDetalle_Venta( int _venId, int _prodId, int _cantidad)
        {
            return objDetVenta.updateDetalle_ventas(_venId, _prodId, _cantidad);
        }

        // Método para borrar un detalle de venta
        public bool deleteDetalle_Venta(int _id)
        {
            return objDetVenta.deleteDetalle_ventas(_id);
        }
    }
}

