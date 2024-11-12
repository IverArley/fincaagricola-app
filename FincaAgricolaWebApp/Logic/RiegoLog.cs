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
        public bool saveRiego(DateTime _fecha, int _parcId)
        {
            return objRie.saveRiego(_fecha, _parcId);
        }

        //Metodo para actulizar un finca
        public bool updateRiego(int _id, DateTime _fecha, int _parcId)
        {
            return objRie.updateRiego(_id, _fecha, _parcId);
        }

        //Metodo para borrar una finca
        public bool deleteRiego(int _id)
        {
            return objRie.deleteRiego(_id);

        }
    }
}