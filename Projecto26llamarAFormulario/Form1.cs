using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projecto26llamarAFormulario
{
    public partial class FrmBienvenida : Form
    {
        public FrmBienvenida()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ha realizado su primera aplicacion en C#");
            this.Close();

        }

        private void btnContinuar_Click(object sender, EventArgs e)
        {
            FrmAplicacion MiFormulario = new FrmAplicacion();
            MessageBox.Show("Bienvenido a su primera aplicacion ");
            MiFormulario.Show();

        }
    }
}
