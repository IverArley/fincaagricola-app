using Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace Logic
{
    public class ClimaLog
    {
        ClimaDat objClim = new ClimaDat();


        public DataSet showClima()
        {
            return objClim.showClima();
        }

        //Metodo para guardar un nuevo finca
        public bool saveClima(DateTime _fecha, double _humedad, double _temperatura, int _parcId)
        {
            return objClim.saveClima(_fecha, _humedad, _temperatura, _parcId);
        }

        //Metodo para actulizar un finca
        public bool updateProductos(int _id, DateTime _fecha, double _humedad, double _temperatura, int _parcId)
        {
            return objClim.updateClima(_id, _fecha, _humedad, _temperatura, _parcId);
        }

        //Metodo para borrar una finca
        public bool deleteClima(int _id)
        {
            return objClim.deleteClima(_id);

        }
    }
}