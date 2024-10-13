using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace Data
{
    public class MaquinariasDat
    {
        // Se crea una instancia de la clase Persistence para manejar la conexión a la base de datos.
        Persistence objPer = new Persistence();


        // Método para mostrar las maquinarias desde la base de datos.
        public DataSet showMaquinarias()
        {
            MySqlDataAdapter objAdapter = new MySqlDataAdapter();
            DataSet objData = new DataSet();

            MySqlCommand objSelectCmd = new MySqlCommand();
            objSelectCmd.Connection = objPer.openConnection();
            objSelectCmd.CommandText = "sp_show_maquinarias"; // Nombre correcto del procedimiento almacenado
            objSelectCmd.CommandType = CommandType.StoredProcedure;

            objAdapter.SelectCommand = objSelectCmd;
            objAdapter.Fill(objData);

            objPer.closeConnection();

            return objData;
        }

        //Metodo para guardar un nueva maquinaria
        public bool saveMaquinarias(string _tipo, string _estado, DateTime _fechaAdquisicion, int _parcId)
        {
            bool executed = false;
            int row;

            MySqlCommand objSelectCmd = new MySqlCommand();
            objSelectCmd.Connection = objPer.openConnection();
            objSelectCmd.CommandText = "sp_insert_maquinarias"; // Nombre del procedimiento almacenado
            objSelectCmd.CommandType = CommandType.StoredProcedure;

            // Agrega los parámetros correspondientes
            objSelectCmd.Parameters.Add("v_maqu_tipo", MySqlDbType.VarChar).Value = _tipo;
            objSelectCmd.Parameters.Add("v_maqu_estado", MySqlDbType.VarChar).Value = _estado;
            objSelectCmd.Parameters.Add("v_maqu_fecha_adquisicion", MySqlDbType.Date).Value = _fechaAdquisicion;
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


        //Metodo para actulizar una maquinaria
        public bool updateMaquinarias(int _id, string _tipo, string _estado, DateTime _fechaAdquisicion, int _parcId)
        {
            bool executed = false;
            int row;

            MySqlCommand objSelectCmd = new MySqlCommand();
            objSelectCmd.Connection = objPer.openConnection();
            objSelectCmd.CommandText = "sp_update_maquinarias"; // Nombre correcto del procedimiento almacenado
            objSelectCmd.CommandType = CommandType.StoredProcedure;

            // Agrega los parámetros correspondientes
            objSelectCmd.Parameters.Add("v_maqu_id", MySqlDbType.Int32).Value = _id;
            objSelectCmd.Parameters.Add("v_maqu_tipo", MySqlDbType.VarChar).Value = _tipo;
            objSelectCmd.Parameters.Add("v_maqu_estado", MySqlDbType.VarChar).Value = _estado;
            objSelectCmd.Parameters.Add("v_maqu_fecha_adquisicion", MySqlDbType.Date).Value = _fechaAdquisicion;
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

        //Metodo para elimanar una maquinaria
        public bool deleteMaquinarias(int _id)
        {
            bool executed = false;
            int row;

            MySqlCommand objSelectCmd = new MySqlCommand();
            objSelectCmd.Connection = objPer.openConnection();
            objSelectCmd.CommandText = "sp_delete_maquinarias"; // Nombre del procedimiento almacenado
            objSelectCmd.CommandType = CommandType.StoredProcedure;

            // Agrega el parámetro correspondiente
            objSelectCmd.Parameters.Add("v_maqu_id", MySqlDbType.Int32).Value = _id;

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
