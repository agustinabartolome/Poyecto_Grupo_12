using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Poyecto_Grupo_12.Datos
{
    internal class sistema
    {
        public DataTable administracion(string operador, string usuario)
        {
            MySqlDataReader resultado;
            DataTable tabla = new DataTable();
            MySqlConnection sqlCon = new MySqlConnection();
            try
            {
                sqlCon = conexion.getInstancia().crearConexion();

                MySqlCommand comando = new MySqlCommand("Operador", sqlCon);

                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("Operador", MySqlDbType.VarChar).Value = operador;
                comando.Parameters.Add("Usuario", MySqlDbType.VarChar).Value = usuario;

                sqlCon.Open();
                resultado = comando.ExecuteReader();

                tabla.Load(resultado);

                return tabla;

            }

            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open)
                { sqlCon.Close(); };
            }
        }
    }
}
