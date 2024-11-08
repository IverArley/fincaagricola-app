using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
namespace Data
{
    public class ClientesDat
    {
        
        Persistence objPer = new Persistence();

        public DataSet showClientes()
        {
            MySqlDataAdapter objAdapter = new MySqlDataAdapter();
            DataSet objData = new DataSet();
            MySqlCommand objSelectCmd = new MySqlCommand();
            objSelectCmd.Connection = objPer.openConnection();
            objSelectCmd.CommandText = "sp_show_clientes";
            objSelectCmd.CommandType = CommandType.StoredProcedure;
            objAdapter.SelectCommand = objSelectCmd;
            objAdapter.Fill(objData);
            objPer.closeConnection();
            return objData;
        }

        public DataSet showClientesDDL()

        {
            MySqlDataAdapter objAdapter = new MySqlDataAdapter();
            DataSet objData = new DataSet();

            MySqlCommand objSelectCmd = new MySqlCommand();
            objSelectCmd.Connection = objPer.openConnection();
            objSelectCmd.CommandText = "sp_show_clientes_ddl";
            objSelectCmd.CommandType = CommandType.StoredProcedure;
            objAdapter.SelectCommand = objSelectCmd;
            objAdapter.Fill(objData);
            objPer.closeConnection();
            return objData;
        }

        //Metodo para guardar un nuevo Clima
        public bool saveClientes(string _nombre, string _telefono, string _direccion)
        {
            bool executed = false;
            int row;
            MySqlCommand objSelectCmd = new MySqlCommand();
            objSelectCmd.Connection = objPer.openConnection();
            objSelectCmd.CommandText = "sp_insert_clientes"; 
            objSelectCmd.CommandType = CommandType.StoredProcedure;
            
            objSelectCmd.Parameters.Add("v_clie_nombre", MySqlDbType.VarString).Value = _nombre;
            objSelectCmd.Parameters.Add("v_clie_telefono", MySqlDbType.VarString).Value = _telefono;
            objSelectCmd.Parameters.Add("v_clie_direccion", MySqlDbType.Int32).Value = _direccion;

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

        public bool updateClientes(int _id, string _nombre, string _telefono, string _direccion)
        {
            bool executed = false;
            int row;

            MySqlCommand objSelectCmd = new MySqlCommand();
            objSelectCmd.Connection = objPer.openConnection();
            objSelectCmd.CommandText = "sp_update_clientes";
            objSelectCmd.CommandType = CommandType.StoredProcedure;

            objSelectCmd.Parameters.Add("v_clie_id", MySqlDbType.Int32).Value = _id;
            objSelectCmd.Parameters.Add("v_clie_nombre", MySqlDbType.VarString).Value = _nombre;
            objSelectCmd.Parameters.Add("v_clie_telefono", MySqlDbType.VarString).Value = _telefono;
            objSelectCmd.Parameters.Add("v_clie_direccion", MySqlDbType.Int32).Value = _direccion;

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

        public bool deleteClientes(int _id)
        {
            bool executed = false;
            int row;

            MySqlCommand objSelectCmd = new MySqlCommand();
            objSelectCmd.Connection = objPer.openConnection();
            objSelectCmd.CommandText = "sp_delete_clientes"; 
            objSelectCmd.CommandType = CommandType.StoredProcedure;
            objSelectCmd.Parameters.Add("v_clie_id", MySqlDbType.Int32).Value = _id;

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