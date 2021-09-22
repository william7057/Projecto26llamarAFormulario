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
    public partial class FrmAplicacion : Form
    {
        public FrmAplicacion()
        {
            InitializeComponent();
        }

        private void FrmAplicacion_Load(object sender, EventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        int x = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            
            x = x + 1;
            label5.Text = x.ToString();

        }
    }
}
