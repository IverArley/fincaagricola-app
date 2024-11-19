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

        public bool saveParcela(string _tamano, string _ubicacion, int _finId)
        {
            return objPar.saveParcela(_tamano, _ubicacion, _finId);
        }

        public bool updateParcela(int _id, string _tamano, string _ubicacion, int _finId)
        {
            return objPar.updateParcela(_id, _tamano, _ubicacion, _finId);
        }

        public bool deleteParcela(int _id)
        {
            return objPar.deleteParcela(_id);
        }
    }
}