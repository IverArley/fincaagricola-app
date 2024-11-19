using Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace Logic
{
    public class RiegoLog
    {
        RiegoDat objRie = new RiegoDat();


        public DataSet showRiego()
        {

            return objRie.showRiego();
        }

        //Metodo para guardar un nuevo finca
        public bool saveRiego(int _parcId, DateTime _fecha)
        {
            return objRie.saveRiego(_parcId, _fecha);
        }

        //Metodo para actulizar un finca
        public bool updateRiego(int _id, int _parcId, DateTime _fecha)
        {
            return objRie.updateRiego(_id, _parcId, _fecha);
        }

        //Metodo para borrar una finca
        public bool deleteRiego(int _id)
        {
            return objRie.deleteRiego(_id);

        }
    }
}