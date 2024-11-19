using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace Data
{
    public class InsumosDat
    {
        // Se crea una instancia de la clase Persistence para manejar la conexión a la base de datos.
        Persistence objPer = new Persistence();

        public DataSet showInsumo()
        {
            MySqlDataAdapter objAdapter = new MySqlDataAdapter();
            DataSet objData = new DataSet();

            MySqlCommand objSelectCmd = new MySqlCommand();
            objSelectCmd.Connection = objPer.openConnection();
            objSelectCmd.CommandText = "sp_show_insumos"; // Nombre del procedimiento almacenado
            objSelectCmd.CommandType = CommandType.StoredProcedure;

            objAdapter.SelectCommand = objSelectCmd;
            objAdapter.Fill(objData);

            objPer.closeConnection();

            return objData;
        }

        public bool saveInsumo(string _nombre, decimal _cantidad, DateTime _fecha, int _provId, int _parcId)
        {
            bool executed = false;
            int row;

            MySqlCommand objSelectCmd = new MySqlCommand();
            objSelectCmd.Connection = objPer.openConnection();
            objSelectCmd.CommandText = "sp_insert_insumos"; // Nombre del procedimiento almacenado
            objSelectCmd.CommandType = CommandType.StoredProcedure;

            // Agrega los parámetros correspondientes
            objSelectCmd.Parameters.Add("v_insu_nombre", MySqlDbType.VarChar).Value = _nombre;
            objSelectCmd.Parameters.Add("v_insu_cantidad", MySqlDbType.Decimal).Value = _cantidad;
            objSelectCmd.Parameters.Add("v_insu_fecha_entrada", MySqlDbType.Date).Value = _fecha;
            objSelectCmd.Parameters.Add("v_prov_id", MySqlDbType.Int32).Value = _provId;
            objSelectCmd.Parameters.Add("v_parc_id", MySqlDbType.Int32).Value = _parcId;

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

        public bool updateInsumo(int _id, string _nombre, decimal _cantidad, DateTime _fecha, int _provId, int _parcId)
        {
            bool executed = false;
            int row;

            MySqlCommand objSelectCmd = new MySqlCommand();
            objSelectCmd.Connection = objPer.openConnection();
            objSelectCmd.CommandText = "sp_update_insumos"; // Nombre del procedimiento almacenado
            objSelectCmd.CommandType = CommandType.StoredProcedure;

            // Agrega los parámetros correspondientes
            objSelectCmd.Parameters.Add("v_insu_id", MySqlDbType.Int32).Value = _id;
            objSelectCmd.Parameters.Add("v_insu_nombre", MySqlDbType.VarChar).Value = _nombre;
            objSelectCmd.Parameters.Add("v_insu_cantidad", MySqlDbType.Decimal).Value = _cantidad;
            objSelectCmd.Parameters.Add("v_insu_fecha_entrada", MySqlDbType.Date).Value = _fecha;
            objSelectCmd.Parameters.Add("v_prov_id", MySqlDbType.Int32).Value = _provId;
            objSelectCmd.Parameters.Add("v_parc_id", MySqlDbType.Int32).Value = _parcId;

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

        public bool deleteInsumo(int _id)
        {
            bool executed = false;
            int row;

            MySqlCommand objSelectCmd = new MySqlCommand();
            objSelectCmd.Connection = objPer.openConnection();
            objSelectCmd.CommandText = "sp_delete_insumos"; // Nombre del procedimiento almacenado
            objSelectCmd.CommandType = CommandType.StoredProcedure;

            // Agrega el parámetro correspondiente
            objSelectCmd.Parameters.Add("v_insu_id", MySqlDbType.Int32).Value = _id;

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