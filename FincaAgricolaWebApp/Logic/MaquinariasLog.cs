using Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace Logic
{
    public class MaquinariasLog
    {
        // Instancia de la clase de acceso a datos para maquinarias
        MaquinariasDat objMaq = new MaquinariasDat();

        // Método para mostrar las maquinarias
        public DataSet showMaquinarias()
        {
            return objMaq.showMaquinarias();
        }

        // Método para guardar una nueva maquinaria
        public bool saveMaquinaria(string _tipo, string _estado, DateTime _fechaAdquisicion, int _parcId)
        {
            return objMaq.saveMaquinarias(_tipo, _estado, _fechaAdquisicion, _parcId);
        }

        // Método para actualizar una maquinaria existente
        public bool updateMaquinarias(int _id, string _tipo, string _estado, DateTime _fechaAdquisicion, int _parcId)
        {
            return objMaq.updateMaquinarias(_id, _tipo, _estado, _fechaAdquisicion, _parcId);
        }

        // Método para eliminar una maquinaria
        public bool deleteMaquinarias(int _id)
        {
            return objMaq.deleteMaquinarias(_id);
        }
    }
}
