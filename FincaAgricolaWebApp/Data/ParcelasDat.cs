using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using MySql.Data.MySqlClient;

namespace Data
{
    public class ParcelasDat
    {
        // Se crea una instancia de la clase Persistence para manejar la conexión a la base de datos.
        Persistence objPer = new Persistence();

        public DataSet showParcela()
        {
            MySqlDataAdapter objAdapter = new MySqlDataAdapter();
            DataSet objData = new DataSet();

            MySqlCommand objSelectCmd = new MySqlCommand();
            objSelectCmd.Connection = objPer.openConnection();
            objSelectCmd.CommandText = "sp_show_parcelas"; // Nombre del procedimiento almacenado
            objSelectCmd.CommandType = CommandType.StoredProcedure;

            objAdapter.SelectCommand = objSelectCmd;
            objAdapter.Fill(objData);

            objPer.closeConnection();

            return objData;
        }

        public DataSet showParcelaDDL()
        {
            MySqlDataAdapter objAdapter = new MySqlDataAdapter();
            DataSet objData = new DataSet();

            MySqlCommand objSelectCmd = new MySqlCommand();
            objSelectCmd.Connection = objPer.openConnection();
            objSelectCmd.CommandText = "sp_show_parcelas_ddl"; // Nombre del procedimiento almacenado
            objSelectCmd.CommandType = CommandType.StoredProcedure;

            objAdapter.SelectCommand = objSelectCmd;
            objAdapter.Fill(objData);

            objPer.closeConnection();

            return objData;
        }

        public bool saveParcela(string _ubicacion, double _tamano, string _estado, DateTime _fecha, int _provId, int _finId)
        {
            bool executed = false;
            int row;

            MySqlCommand objSelectCmd = new MySqlCommand();
            objSelectCmd.Connection = objPer.openConnection();
            objSelectCmd.CommandText = "sp_insert_parcelas"; // Nombre del procedimiento almacenado
            objSelectCmd.CommandType = CommandType.StoredProcedure;

            // Agrega los parámetros correspondientes
            objSelectCmd.Parameters.Add("v_par_ubicacion", MySqlDbType.VarChar).Value = _ubicacion;
            objSelectCmd.Parameters.Add("v_par_tamano", MySqlDbType.Int32).Value = _tamano;
            objSelectCmd.Parameters.Add("v_par_estado", MySqlDbType.VarChar).Value = _estado;
            objSelectCmd.Parameters.Add("v_par_fecha_revision", MySqlDbType.Date).Value = _fecha;
            objSelectCmd.Parameters.Add("v_fin_id", MySqlDbType.Int32).Value = _finId;

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

        public bool updateParcela(int _id, string _ubicacion, double _tamano, string _estado, DateTime _fecha, int _provId, int _finId)
        {
            bool executed = false;
            int row;

            MySqlCommand objSelectCmd = new MySqlCommand();
            objSelectCmd.Connection = objPer.openConnection();
            objSelectCmd.CommandText = "sp_update_parcelas"; // Nombre del procedimiento almacenado
            objSelectCmd.CommandType = CommandType.StoredProcedure;

            // Agrega los parámetros correspondientes
            objSelectCmd.Parameters.Add("v_par_id", MySqlDbType.Int32).Value = _id;
            objSelectCmd.Parameters.Add("v_par_ubicacion", MySqlDbType.VarChar).Value = _ubicacion;
            objSelectCmd.Parameters.Add("v_par_tamano", MySqlDbType.Int32).Value = _tamano;
            objSelectCmd.Parameters.Add("v_par_estado", MySqlDbType.VarChar).Value = _estado;
            objSelectCmd.Parameters.Add("v_par_fecha_revision", MySqlDbType.Date).Value = _fecha;
            objSelectCmd.Parameters.Add("v_fin_id", MySqlDbType.Int32).Value = _finId;

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

        public bool deleteParcela(int _id)
        {
            bool executed = false;
            int row;

            MySqlCommand objSelectCmd = new MySqlCommand();
            objSelectCmd.Connection = objPer.openConnection();
            objSelectCmd.CommandText = "sp_delete_parcelas"; // Nombre del procedimiento almacenado
            objSelectCmd.CommandType = CommandType.StoredProcedure;

            // Agrega el parámetro correspondiente
            objSelectCmd.Parameters.Add("v_par_id", MySqlDbType.Int32).Value = _id;

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