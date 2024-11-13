using Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace Logic
{
    public class InsumosLog
    {
        // Se crea una instancia de la clase InsumosDat para manejar la lógica relacionada con los insumos.
        InsumosDat objInsumosDat = new InsumosDat();

        // Método para obtener todos los insumos
        public DataSet showInsumo()
        {
            return objInsumosDat.showInsumo();
        }

        // Método para guardar un nuevo insumo
        public bool saveInsumo(string _nombre, decimal _cantidad, DateTime _fecha, int _provId, int _parcId)
        {
            return objInsumosDat.saveInsumo(_nombre, _cantidad, _fecha, _provId, _parcId);
        }

        // Método para actualizar un insumo
        public bool updateInsumo(int _id, string _nombre, decimal _cantidad, DateTime _fecha, int _provId, int _parcId)
        {
            return objInsumosDat.updateInsumo(_id, _nombre, _cantidad, _fecha, _provId, _parcId);
        }

        // Método para eliminar un insumo
        public bool deleteInsumo(int _id)
        {
            return objInsumosDat.deleteInsumo(_id);
        }
    }
}
