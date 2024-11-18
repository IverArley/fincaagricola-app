using System.Data;
using Data;

namespace Logic
{
    public class ArduinoLog
    {
        // Instancia de la clase ControlRiegoDat para manejar la conexión con la base de datos.
        ArduinoDat objArd = new ArduinoDat();

        // Método para mostrar todos los registros de control de riego.
        public DataSet showControlRiego()
        {
            return objArd.showControlRiego();
        }

        // Método para agregar un nuevo registro de control de riego.
        public bool saveControlRiego(decimal humedad, string clima, decimal cantidadAgua)
        {
            return objArd.saveControlRiego(humedad, clima, cantidadAgua);
        }

        // Método para actualizar un registro de control de riego existente.
        public bool updateControlRiego(int id, decimal humedad, string clima, decimal cantidadAgua)
        {
            return objArd.updateControlRiego(id, humedad, clima, cantidadAgua);
        }

        // Método para eliminar un registro de control de riego por ID.
        public bool deleteControlRiego(int id)
        {
            return objArd.deleteControlRiego(id);
        }
    }
}
