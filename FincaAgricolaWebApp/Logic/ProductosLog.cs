using Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace Logic
{
    public class ProductosLog
    {
        ProductosDat objPro = new ProductosDat();


        public DataSet showProductos()
        {

            return objPro.showProductos();
        }

        //Metodo para mostrar unicamente el id y el nombre
        public DataSet showProductosDDL()
        {
            return objPro.showProductosDDL();
        }

        //Metodo para guardar un nuevo finca
        public bool saveProductos(string _nombre, string _descripcion, decimal _precio, int _parcId)
        {
            return objPro.saveProductos(_nombre, _descripcion, _precio, _parcId);
        }

        //Metodo para actulizar un finca
        public bool updateProductos(int _id, string _nombre, string _descripcion, decimal _precio, int _parcId)
        {
            return objPro.updateProductos(_id, _nombre, _descripcion, _precio, _parcId);
        }

        //Metodo para borrar una finca
        public bool deleteProductos(int _id)
        {
            return objPro.deleteProductos(_id);

        }
    }
}