using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alejandro_Trespalacios_ETS21092020
{
    public partial class Registro : Form
    {
        public Registro()
        {
            InitializeComponent();
        }
        Modelos.alumnos alumnos = new Modelos.alumnos();
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text.Trim() == "" || txtMatricula.Text.Trim() == "" || CMBCarrera.Text.Trim() == "")
            {
                MessageBox.Show("verifica que los campos no esten vacios");
            }
            else
            {
                alumnos.boleta = Convert.ToInt64(txtMatricula.Text);
                if (alumnos.verificarMatricula() == false)
                {
                    alumnos.nombre = txtNombre.Text;
                    alumnos.carrera = CMBCarrera.Text;
                    if (alumnos.guardarAlumno())
                    {
                        btnGuardar.Enabled = false;
                        MessageBox.Show("Alumno Agregado correctamente");
                        Form1 f = new Form1();
                        f.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Ocurrio un error");
                    }
                }
                else
                {
                    MessageBox.Show("Matricula " + txtMatricula.Text + " ya ha sido registrada");
                    alumnos.boleta = 0;
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
