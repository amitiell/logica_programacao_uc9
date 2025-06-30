using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Metros_para_Centimetros
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            Decimal medida_m = Convert.ToDecimal(txtMedida.Text);
            Decimal medidade_c = medida_m * 100;

                lblResultado.Text = medidade_c.ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtMedida.Text = "";
            lblResultado.Text = "0";

        }
    }
}
