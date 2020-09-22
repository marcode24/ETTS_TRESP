
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using Alejandro_Trespalacios_ETS21092020.DAO;


namespace Alejandro_Trespalacios_ETS21092020.Modelos
{
    public class alumnos : Conexion
    {
        public Int64 boleta { get; set; }
        public string nombre { get; set; }
        
        public string carrera { get; set; }

        public bool guardarAlumno()
        {
            try
            {
                // Datos de sql
                // id int primary key identity(1,1),
	            //nombre varchar(20) not null,
	            //matricula bigint not null unique,
	            //carerra varchar(20) not null
                string query = "INSERT INTO Alumnos(nombre, matricula, carrera) " +
                    "VALUES(@nombre, @matricula, @carrera)";
                SqlCommand cmd = new SqlCommand(query);
                cmd.Parameters.AddWithValue("@nombre", nombre);
                cmd.Parameters.AddWithValue("@matricula", boleta);
                cmd.Parameters.AddWithValue("@carrera", carrera);
                return (ejecutar(cmd) > 0) ? true : false;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public bool verificarMatricula()
        {
            try
            {
                string query = "SELECT * FROM Alumnos WHERE matricula = @matricula";
                SqlCommand cmd = new SqlCommand(query);
                cmd.Parameters.AddWithValue("@matricula", boleta);
                return (Consultar(cmd).Rows.Count > 0) ? true : false;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
       

        

       
    }
}
