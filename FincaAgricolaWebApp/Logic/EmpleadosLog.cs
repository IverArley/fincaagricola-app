using Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace Logic
{
    public class EmpleadosLog
    {
        // Instancia de la clase EmpleadosDat (capa de datos)
        EmpleadosDat objEmpl = new EmpleadosDat();

        // Mostrar todos los empleados (se obtiene desde el procedimiento almacenado)
        public DataSet showEmpleados()
        {
            return objEmpl.showEmpleado();  // Llama al método de la capa de datos
        }

        // Guardar un nuevo empleado
        public bool saveEmpleado(string _nombre, string _rol, DateTime _fecha, int _parcId)
        {
            return objEmpl.saveEmpleado(_nombre, _rol, _fecha, _parcId);  // Llama al método de la capa de datos
        }

        // Actualizar un empleado existente
        public bool updateEmpleado(int _id, string _nombre, string _rol, DateTime _fecha, int _parcId)
        {
            return objEmpl.updateEmpleado(_id, _nombre, _rol, _fecha, _parcId);  // Llama al método de la capa de datos
        }

        // Eliminar un empleado
        public bool deleteEmpleado(int _id)
        {
            return objEmpl.deleteEmpleado(_id);  // Llama al método de la capa de datos
        }
    }
}
