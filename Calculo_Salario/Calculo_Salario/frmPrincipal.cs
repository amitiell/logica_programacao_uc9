using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculo_Salario
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            Decimal horas_trabalhadas = Convert.ToDecimal(txtHorasTrabalhadas.Text);
            Decimal valor_hora = Convert.ToDecimal(txtValorHora.Text);
            Decimal resultado = horas_trabalhadas *valor_hora;

            lblResultado.Text = resultado.ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtHorasTrabalhadas.Text = "";
            txtValorHora.Text = "";
            lblResultado.Text = "0";
        }
    }
}
