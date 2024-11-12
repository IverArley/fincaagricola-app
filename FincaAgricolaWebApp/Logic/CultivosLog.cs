using Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;


namespace Logic
{
    public class CultivosLog
    {
        CultivosDat objCult = new CultivosDat();

        public DataSet showCultivo()
        {
            return objCult.showCultivo();
        }

        //Metodo para guardar un nuevo finca
        public bool saveCultivo(string _nombre, DateTime _fecha, string _estado, int _parcId)
        {
            return objCult.saveCultivo(_nombre, _fecha, _estado, _parcId);
        }

        //Metodo para actulizar un finca
        public bool updateCultivo(int _id, string _nombre, DateTime _fecha, string _estado, int _parcId)
        {
            return objCult.updateCultivo(_id, _nombre, _fecha, _estado, _parcId);
        }

        //Metodo para borrar una finca
        public bool deleteCultivo(int _id)
        {
            return objCult.deleteCultivo(_id);

        }
    }
}