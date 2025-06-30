using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculo_Área
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            Decimal lado = Convert.ToDecimal(txtValor.Text);
            Decimal area = lado * lado;
            Decimal dobro_area = area * area;

            lblArea.Text = area.ToString();
            lblDobro.Text = dobro_area.ToString();   
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtValor.Text = "";
            lblArea.Text = "0";
            lblDobro.Text = "0";
        }

        private void txtValor_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
