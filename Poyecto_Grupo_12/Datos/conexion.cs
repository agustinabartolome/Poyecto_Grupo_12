using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace Poyecto_Grupo_12.Datos
{
    public class conexion
    {
        private string baseDatos;
        private string servidor;
        private string puerto;
        private string usuario;
        private string clave;
        private static conexion con = null;

        private conexion()
        {
            this.baseDatos = "";
            this.servidor = "";
            this.puerto = "";
            this.usuario = "";
            this.clave = "";
        }
        public MySqlConnection crearConexion()
        {
            MySqlConnection cadena = new MySqlConnection();

            try
            {
                cadena.ConnectionString = "datasource=" + this.servidor +
                ";port=" + this.puerto +
                ";username=" + this.usuario +
                ";password=" + this.clave +
                ";Database=" + this.baseDatos;
            }
            catch (Exception ex)
            {
                cadena = null;
                throw;
            }
            return cadena;
        }

        public static conexion getInstancia()
        {
            if (con == null)
            {
                con = new conexion();
            }
            return con;
        }

    }

}
