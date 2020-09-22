using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace Alejandro_Trespalacios_ETS21092020
{
    public partial class Resultados : Form
    {
        string miconexion = @"Data Source=.;Initial Catalog=AlumnosDB;Integrated Security=True";
        public Resultados()
        {
            InitializeComponent();
        }
        Modelos.alumnos alumnos = new Modelos.alumnos();
        private void Resultados_Load(object sender, EventArgs e)
        {
            
            using (SqlConnection conexion = new SqlConnection(miconexion))
            {
                conexion.Open();
                string query = "select count(*) as total from Alumnos ";
                SqlCommand cmd = new SqlCommand(query, conexion);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    string numero = reader["total"].ToString();
                    if (numero == "")
                    {
                        lblTotal.Text = 0.ToString();
                    }
                    else
                    {
                        lblTotal.Text = numero.ToString();
                    }
                }
            }
            using (SqlConnection conexion = new SqlConnection(miconexion))
            {
                conexion.Open();
                string query = "select count(*) as Turismo from Alumnos where carrera = 'Turismo'";
                SqlCommand cmd = new SqlCommand(query, conexion);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    string turismo = reader["Turismo"].ToString();
                    lblT.Text = (turismo == "") ? 0.ToString() : turismo.ToString();
                }
            }
            using (SqlConnection conexion = new SqlConnection(miconexion))
            {
                conexion.Open();
                string query = "select count(*) as Admin from Alumnos where carrera = 'Administracion'";
                SqlCommand cmd = new SqlCommand(query, conexion);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    string admin = reader["Admin"].ToString();
                    lblA.Text = (admin == "") ? 0.ToString() : admin.ToString();
                }
            }
            using (SqlConnection conexion = new SqlConnection(miconexion))
            {
                conexion.Open();
                string query = "select count(*) as Info from Alumnos where carrera = 'Informatica'";
                SqlCommand cmd = new SqlCommand(query, conexion);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    string info = reader["Info"].ToString();
                    lblI.Text = (info == "") ? 0.ToString() : info.ToString();
                }
            }
            using (SqlConnection conexion = new SqlConnection(miconexion))
            {
                conexion.Open();
                string query = "select count(*) as Conta from Alumnos where carrera = 'Contaduria'";
                SqlCommand cmd = new SqlCommand(query, conexion);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    string conta = reader["Conta"].ToString();
                    lblC.Text = (conta == "") ? 0.ToString() : conta.ToString();
                }
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }
    }
}
