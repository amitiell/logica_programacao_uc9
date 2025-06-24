using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ordenacao
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnResultado_Click(object sender, EventArgs e)
        {
            Decimal valor1 = Convert.ToDecimal(txtValor1.Text);
            Decimal valor2 = Convert.ToDecimal(txtValor2.Text);
            Decimal valor3 = Convert.ToDecimal(txtValor3.Text);

            if(valor2 > valor1 && valor2 < valor3 )
            {
                lblCrescente2.Text = valor2.ToString();
            }
            if(valor1 > valor2 && valor1 > valor3)
            {
                lblCrescente3.Text = valor1.ToString();
            }
            else
            {
                lblCrescente1.Text = valor1.ToString();
                lblCrescente3.Text = valor3.ToString();
            }
            


        }
    }
}
