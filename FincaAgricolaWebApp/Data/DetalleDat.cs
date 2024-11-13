using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace Data
{
    public class DetalleDat
    {
        // Se crea una instancia de la clase Persistence para manejar la conexión a la base de datos.
        Persistence objPer = new Persistence();

        // Método para mostrar los productos desde la base de datos.
        public DataSet showDetalle_Ventas()
        {
            try
            {
                MySqlDataAdapter objAdapter = new MySqlDataAdapter();
                DataSet objData = new DataSet();
                MySqlCommand objSelectCmd = new MySqlCommand();

                objSelectCmd.Connection = objPer.openConnection();
                objSelectCmd.CommandText = "sp_show_detalle_ventas";
                objSelectCmd.CommandType = CommandType.StoredProcedure;
                objAdapter.SelectCommand = objSelectCmd;

                objAdapter.Fill(objData);
                objPer.closeConnection();

                return objData;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return null;
            }
        }

        // Método para guardar un nuevo detalle de venta
        public bool saveDetalle_ventas(int _venId, int _prodId, int _cantidad)
        {
            bool executed = false;
            int row;

            MySqlCommand objSelectCmd = new MySqlCommand();
            objSelectCmd.Connection = objPer.openConnection();
            objSelectCmd.CommandText = "sp_insert_detalle_ventas";
            objSelectCmd.CommandType = CommandType.StoredProcedure;

            // Se agregan parámetros al comando en el orden especificado.
            objSelectCmd.Parameters.Add("v_vent_id", MySqlDbType.Int32).Value = _venId;
            objSelectCmd.Parameters.Add("v_prod_id", MySqlDbType.Int32).Value = _prodId;
            objSelectCmd.Parameters.Add("v_deta_cantidad", MySqlDbType.Int32).Value = _cantidad;

            try
            {
                row = objSelectCmd.ExecuteNonQuery();

                if (row == 1)
                {
                    executed = true;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error " + e.ToString());
            }
            objPer.closeConnection();
            return executed;
        }

        // Método para actualizar un detalle de venta
        public bool updateDetalle_ventas( int _venId, int _prodId, int _cantidad)
        {
            bool executed = false;
            int row;

            MySqlCommand objSelectCmd = new MySqlCommand();
            objSelectCmd.Connection = objPer.openConnection();
            objSelectCmd.CommandText = "sp_update_detalle_ventas";
            objSelectCmd.CommandType = CommandType.StoredProcedure;

            // Se agregan parámetros al comando en el orden especificado.
           
            objSelectCmd.Parameters.Add("v_vent_id", MySqlDbType.Int32).Value = _venId;
            objSelectCmd.Parameters.Add("v_prod_id", MySqlDbType.Int32).Value = _prodId;
            objSelectCmd.Parameters.Add("v_deta_cantidad", MySqlDbType.Int32).Value = _cantidad;

            try
            {
                row = objSelectCmd.ExecuteNonQuery();
                if (row == 1)
                {
                    executed = true;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error " + e.ToString());
            }
            objPer.closeConnection();
            return executed;
        }

        // Método para borrar un detalle de venta
        public bool deleteDetalle_ventas(int _id)
        {
            bool executed = false;
            int row;

            MySqlCommand objSelectCmd = new MySqlCommand();
            objSelectCmd.Connection = objPer.openConnection();
            objSelectCmd.CommandText = "sp_delete_detalle_venta";
            objSelectCmd.CommandType = CommandType.StoredProcedure;
            objSelectCmd.Parameters.Add("v_deta_id", MySqlDbType.Int32).Value = _id;

            try
            {
                row = objSelectCmd.ExecuteNonQuery();
                if (row == 1)
                {
                    executed = true;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error " + e.ToString());
            }
            objPer.closeConnection();
            return executed;
        }
    }
}
