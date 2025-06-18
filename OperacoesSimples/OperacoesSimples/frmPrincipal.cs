using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OperacoesSimples
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void lblSubtracao_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {

            decimal num1 = Convert.ToDecimal(txtA.Text);
            decimal num2 = Convert.ToDecimal(txtB.Text);
            decimal soma = num1 + num2;
            decimal subtracao = num1 - num2;
            decimal divisao = num1 / num2;
            decimal multiplicacao = num1 * num2;
            lblSoma.Text = $"A soma de {num1} + {num2} = {soma.ToString()}.";
            lblSubtracao.Text = $"A Subtração de {num1} - {num2} = {subtracao.ToString()}.";
            lblDivisao.Text = $"A Divisão de {num1} + {num2} = {divisao.ToString()}.";
            lblMultiplicacao.Text = $"A multiplicação de {num1} + {num2} = {multiplicacao.ToString()}.";
        }

        private void txtA_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtB_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
