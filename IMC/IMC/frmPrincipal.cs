using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMC
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Double altura = Convert.ToDouble(txtValor.Text);
            Double peso = Convert.ToDouble(txtPeso.Text);
            Double imc = peso / (altura * altura);

            lblResultado.Text = $"O resultado do IMC é: {Math.Round(imc,2).ToString()}";

            if (imc <= 18.5)
            {
                lblPosicao.Text = "Abaixo do peso";
            }
            else if (imc <= 24.9)
            {
                lblPosicao.Text = "Peso normal";
            } 
            else if (imc <= 29.9)
            {
                lblPosicao.Text = "Sobrepeso";
            }
            else
            {
                lblPosicao.Text = "Obesidade";
            }

        }

        private void lblResultado_Click(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtValor.Text = "";
            txtPeso.Text = "";
            lblResultado.Text = "0";
            lblPosicao.Text = "0";

        }
    }
}
