using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace Data
{
    public class ArduinoDat
    {
        // Instancia de la clase Persistence para manejar la conexión a la base de datos.
        Persistence objPer = new Persistence();

        // Método para mostrar todos los registros de la tabla control_riego.
        public DataSet showControlRiego()
        {
            MySqlDataAdapter objAdapter = new MySqlDataAdapter();
            DataSet objData = new DataSet();

            MySqlCommand objSelectCmd = new MySqlCommand();
            objSelectCmd.Connection = objPer.openConnection();
            objSelectCmd.CommandText = "sp_show_control_riego"; // Procedimiento almacenado
            objSelectCmd.CommandType = CommandType.StoredProcedure;

            objAdapter.SelectCommand = objSelectCmd;
            objAdapter.Fill(objData);

            objPer.closeConnection();

            return objData;
        }

        // Método para insertar un registro en la tabla control_riego.
        public bool saveControlRiego(decimal humedad, string clima, decimal cantidadAgua)
        {
            bool executed = false;
            int row;

            MySqlCommand objInsertCmd = new MySqlCommand();
            objInsertCmd.Connection = objPer.openConnection();
            objInsertCmd.CommandText = "sp_insert_control_riego"; // Procedimiento almacenado
            objInsertCmd.CommandType = CommandType.StoredProcedure;

            // Agrega los parámetros correspondientes
            objInsertCmd.Parameters.Add("v_humedad", MySqlDbType.Decimal).Value = humedad;
            objInsertCmd.Parameters.Add("v_clima", MySqlDbType.VarChar).Value = clima;
            objInsertCmd.Parameters.Add("v_cantidad_agua", MySqlDbType.Decimal).Value = cantidadAgua;

            try
            {
                row = objInsertCmd.ExecuteNonQuery();
                if (row == 1)
                {
                    executed = true;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.ToString());
            }
            objPer.closeConnection();
            return executed;
        }

        // Método para actualizar un registro en la tabla control_riego.
        public bool updateControlRiego(int id, decimal humedad, string clima, decimal cantidadAgua)
        {
            bool executed = false;
            int row;

            MySqlCommand objUpdateCmd = new MySqlCommand();
            objUpdateCmd.Connection = objPer.openConnection();
            objUpdateCmd.CommandText = "sp_update_control_riego"; // Procedimiento almacenado
            objUpdateCmd.CommandType = CommandType.StoredProcedure;

            // Agrega los parámetros correspondientes
            objUpdateCmd.Parameters.Add("v_id", MySqlDbType.Int32).Value = id;
            objUpdateCmd.Parameters.Add("v_humedad", MySqlDbType.Decimal).Value = humedad;
            objUpdateCmd.Parameters.Add("v_clima", MySqlDbType.VarChar).Value = clima;
            objUpdateCmd.Parameters.Add("v_cantidad_agua", MySqlDbType.Decimal).Value = cantidadAgua;

            try
            {
                row = objUpdateCmd.ExecuteNonQuery();
                if (row == 1)
                {
                    executed = true;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.ToString());
            }
            objPer.closeConnection();
            return executed;
        }

        // Método para eliminar un registro en la tabla control_riego.
        public bool deleteControlRiego(int id)
        {
            bool executed = false;
            int row;

            MySqlCommand objDeleteCmd = new MySqlCommand();
            objDeleteCmd.Connection = objPer.openConnection();
            objDeleteCmd.CommandText = "sp_delete_control_riego"; // Procedimiento almacenado
            objDeleteCmd.CommandType = CommandType.StoredProcedure;

            // Agrega el parámetro correspondiente
            objDeleteCmd.Parameters.Add("v_id", MySqlDbType.Int32).Value = id;

            try
            {
                row = objDeleteCmd.ExecuteNonQuery();
                if (row == 1)
                {
                    executed = true;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.ToString());
            }
            objPer.closeConnection();
            return executed;
        }
    }
}
