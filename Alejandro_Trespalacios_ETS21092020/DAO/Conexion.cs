
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;

namespace Alejandro_Trespalacios_ETS21092020.DAO
{
    public class Conexion
    {
        protected string cadena_conexion;
        protected SqlConnection cnn;
        protected string tabla;

        public Conexion()
        {
            try
            {
                cadena_conexion = @"Data Source=.;Initial Catalog=AlumnosDB;Integrated Security=True";
                cnn = new SqlConnection(cadena_conexion);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        protected DataTable consultar(SqlCommand cmd)
        {
            try
            {
                if (cnn.State == ConnectionState.Closed) cnn.Open();

                cmd.Connection = cnn;
                SqlDataReader lector = cmd.ExecuteReader();
                DataTable tabla = new DataTable();
                tabla.Load(lector);
                cnn.Close();
                return tabla;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        protected int ejecutar(SqlCommand cmd)
        {
            try
            {
                if (cnn.State == ConnectionState.Closed) cnn.Open();
                cmd.Connection = cnn;
                //Llamamos al método ExecuteNonQuery el cual devuelve el número de filas afectadas
                int resultado = cmd.ExecuteNonQuery();
                cnn.Close();
                return resultado;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        protected DataTable Consultar(SqlCommand cmd)
        {
            try
            {
                if (cnn.State == ConnectionState.Closed) cnn.Open();
                //cmd(que es un objeto sqlCommand) tiene una propiedad llamada connection el cual le establecemos
                //el objeto cnn(que es un sqlConnection)
                cmd.Connection = cnn;
                //llamamos al metodo ExecuteReader del objeto cmd el cual ns devuelve un SqlDataReader con los datos obtenidos en la consulta
                //despues se asigna a la variable lector
                SqlDataReader lector = cmd.ExecuteReader();
                DataTable tabla = new DataTable();
                //se llama al metodo Load del objeto DataTable y se pasa como argumento un objeto SqlDataReader para cargar la informacion
                tabla.Load(lector);
                cnn.Close();
                return tabla;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}

