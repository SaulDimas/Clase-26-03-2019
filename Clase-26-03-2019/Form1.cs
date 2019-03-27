using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Operaciones;

namespace Clase_26_03_2019
{
    public partial class frmOperacion : Form
    {
        Operacion ingreso;
        public frmOperacion()
        {
            InitializeComponent();
           
        }

        private void frmOperacion_Load(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            ingreso = new Operacion();
            ingreso.v1 = double.Parse(txtValA.Text);
            ingreso.v2 = double.Parse(txtValA.Text);
           
            lblResul.Text = ingreso.Calcular().ToString();
        }
    }
}
