using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
namespace Data
{
    public class CultivosDat
    {
        // Se crea una instancia de la clase Persistence para manejar la conexión a la base de datos.
        Persistence objPer = new Persistence();

        public DataSet showCultivo()
        {
            MySqlDataAdapter objAdapter = new MySqlDataAdapter();
            DataSet objData = new DataSet();

            MySqlCommand objSelectCmd = new MySqlCommand();
            objSelectCmd.Connection = objPer.openConnection();
            objSelectCmd.CommandText = "sp_show_cultivos"; // Nombre del procedimiento almacenado
            objSelectCmd.CommandType = CommandType.StoredProcedure;

            objAdapter.SelectCommand = objSelectCmd;
            objAdapter.Fill(objData);

            objPer.closeConnection();

            return objData;
        }

        public bool saveCultivo(string _nombre, DateTime _fecha, string _estado, int _parcId)
        {
            bool executed = false;
            int row;

            MySqlCommand objSelectCmd = new MySqlCommand();
            objSelectCmd.Connection = objPer.openConnection();
            objSelectCmd.CommandText = "sp_insert_cultivos"; // Nombre del procedimiento almacenado
            objSelectCmd.CommandType = CommandType.StoredProcedure;

            // Agrega los parámetros correspondientes
            objSelectCmd.Parameters.Add("v_cult_nombre", MySqlDbType.VarChar).Value = _nombre;
            objSelectCmd.Parameters.Add("v_cult_fecha_siembra", MySqlDbType.Date).Value = _fecha;
            objSelectCmd.Parameters.Add("v_cult_estado", MySqlDbType.VarChar).Value = _estado;
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

        public bool updateCultivo(int _id, string _nombre, DateTime _fecha, string _estado, int _parcId)
        {
            bool executed = false;
            int row;

            MySqlCommand objSelectCmd = new MySqlCommand();
            objSelectCmd.Connection = objPer.openConnection();
            objSelectCmd.CommandText = "sp_update_cultivos"; // Nombre del procedimiento almacenado
            objSelectCmd.CommandType = CommandType.StoredProcedure;

            // Agrega los parámetros correspondientes
            objSelectCmd.Parameters.Add("v_cult_id", MySqlDbType.Int32).Value = _id;
            objSelectCmd.Parameters.Add("v_cult_nombre", MySqlDbType.VarChar).Value = _nombre;
            objSelectCmd.Parameters.Add("v_cult_fecha_siembra", MySqlDbType.Date).Value = _fecha;
            objSelectCmd.Parameters.Add("v_cult_estado", MySqlDbType.VarChar).Value = _estado;
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

        public bool deleteCultivo(int _id)
        {
            bool executed = false;
            int row;

            MySqlCommand objSelectCmd = new MySqlCommand();
            objSelectCmd.Connection = objPer.openConnection();
            objSelectCmd.CommandText = "sp_delete_cultivos"; // Nombre del procedimiento almacenado
            objSelectCmd.CommandType = CommandType.StoredProcedure;

            // Agrega el parámetro correspondiente
            objSelectCmd.Parameters.Add("v_cult_id", MySqlDbType.Int32).Value = _id;

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