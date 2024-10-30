using Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace Logic
{
    public class ParcelasLog
    {
        ParcelasDat objPar = new ParcelasDat();

        public DataSet showParcela()
        {
            return objPar.showParcela();
        }

        public DataSet showParcelaDDL()
        {
            return objPar.showParcelaDDL();
        }

        public bool saveParcela(string _ubicacion, double _tamano, string _estado, DateTime _fecha, int _provId, int _finId)
        {
            return objPar.saveParcela(_ubicacion, _tamano, _estado, _fecha, _provId, _finId);
        }

        public bool updateParcela(int _id, string _ubicacion, double _tamano, string _estado, DateTime _fecha, int _provId, int _finId)
        {
            return objPar.updateParcela(_id, _ubicacion, _tamano, _estado, _fecha, _provId, _finId);
        }

        public bool deleteParcela(int _id)
        {
            return objPar.deleteParcela(_id);
        }
    }
}