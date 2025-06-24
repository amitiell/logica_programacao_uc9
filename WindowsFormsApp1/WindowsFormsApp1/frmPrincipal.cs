using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            Decimal m1 = Convert.ToDecimal(txtValor1.Text);
            Decimal m2 = Convert.ToDecimal(txtValor2.Text);
            Decimal m3 = Convert.ToDecimal(txtValor3.Text);

            Decimal media = (m1 + m2 + m3) / 3;

            MessageBox.Show("A média é " + media.ToString());

            if (m1 > media) 
            {
                txtValor1.ForeColor = Color.Blue;            
            }
            if (m2 > media)
            {
                txtValor2.ForeColor = Color.Blue;
            }
            if (m3 > media) 
            {
                txtValor3.ForeColor = Color.Blue;
            }



        }
    }
}
