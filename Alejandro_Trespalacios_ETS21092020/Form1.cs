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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Registro reg = new Registro();
            reg.Show();
            this.Hide();
        }

        private void btnResultados_Click(object sender, EventArgs e)
        {
            Resultados res = new Resultados();
            res.Show();
            this.Hide();
        }
    }
}
