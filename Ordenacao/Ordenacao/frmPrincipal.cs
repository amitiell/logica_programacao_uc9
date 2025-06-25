using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
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

            if (valor1 <= valor2 && valor1 <= valor3)
            {
                if (valor2 <= valor3)
                {
                    lblCrescente1.Text = valor1.ToString();
                    lblCrescente2.Text = valor2.ToString();
                    lblCrescente3.Text = valor3.ToString();
                }
                else
                {
                    lblCrescente1.Text = valor1.ToString();
                    lblCrescente2.Text = valor3.ToString();
                    lblCrescente3.Text = valor2.ToString();
                }
            }
            else if (valor2 <= valor1 && valor2 <= valor3)
            {

                if (valor1 <= valor3)
                {
                    lblCrescente1.Text = valor2.ToString();
                    lblCrescente2.Text = valor1.ToString();
                    lblCrescente3.Text = valor3.ToString();
                }
                else
                {
                    lblCrescente1.Text = valor2.ToString();
                    lblCrescente2.Text = valor3.ToString();
                    lblCrescente3.Text = valor1.ToString();
                }
            }
            else // valor3 é menor
            {
                if (valor1 <= valor2)
                {
                    lblCrescente1.Text = valor3.ToString();
                    lblCrescente2.Text = valor1.ToString();
                    lblCrescente3.Text = valor2.ToString();
                }
                else
                {
                    lblCrescente1.Text = valor3.ToString();
                    lblCrescente2.Text = valor2.ToString();
                    lblCrescente3.Text = valor1.ToString();
                }
            }
            if (valor1 >= valor2 && valor1 >= valor3)
            {
                if (valor2 >= valor3)
                {
                    lblDecrescente1.Text = valor1.ToString();
                    lblDecrescente2.Text = valor2.ToString();
                    lblDecrescente3.Text = valor3.ToString();
                }
                else
                {
                    lblDecrescente1.Text = valor1.ToString();
                    lblDecrescente2.Text = valor3.ToString();
                    lblDecrescente3.Text = valor2.ToString();
                }
            }
            else if (valor2 >= valor1 && valor2 >= valor3)
            {

                if (valor1 >= valor3)
                {
                    lblDecrescente1.Text = valor2.ToString();
                    lblDecrescente2.Text = valor1.ToString();
                    lblDecrescente3.Text = valor3.ToString();
                }
                else
                {
                    lblDecrescente1.Text = valor2.ToString();
                    lblDecrescente2.Text = valor3.ToString();
                    lblDecrescente3.Text = valor1.ToString();
                }
            }
            else // valor3 é maior
            {
                if (valor1 >= valor2)
                {
                    lblDecrescente1.Text = valor3.ToString();
                    lblDecrescente2.Text = valor1.ToString();
                    lblDecrescente3.Text = valor2.ToString();
                }
                else
                {
                    lblDecrescente1.Text = valor3.ToString();
                    lblDecrescente2.Text = valor2.ToString();
                    lblDecrescente3.Text = valor1.ToString();
                }
            }

        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}
