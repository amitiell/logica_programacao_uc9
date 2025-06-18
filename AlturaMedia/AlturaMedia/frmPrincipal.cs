using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlturaMedia
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            Decimal alt1 = Convert.ToDecimal(txtA1.Text);
            Decimal alt2 = Convert.ToDecimal(txtA2.Text);
            Decimal alt3 = Convert.ToDecimal(txtA3.Text);

            Decimal media = (alt1 + alt2 + alt3) / 3;

            lblmedia.Text = Math.Round(media,1).ToString();

            
        }
    }
}
