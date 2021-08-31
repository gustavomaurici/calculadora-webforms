using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class txtResultado : Form
    {
        public txtResultado()
        {
            InitializeComponent();
        }

        float num1, num2;
        string operacao;


        private void btnZero_Click(object sender, EventArgs e)
        {
            txtResult.Text = txtResult.Text + "0";
        }

        private void btnUm_Click(object sender, EventArgs e)
        {
            txtResult.Text = txtResult.Text + "1";
        }

        private void btnDois_Click(object sender, EventArgs e)
        {
            txtResult.Text = txtResult.Text + "2";
        }

        private void btnTres_Click(object sender, EventArgs e)
        {
            txtResult.Text = txtResult.Text + "3";
        }

        private void btnQuatro_Click(object sender, EventArgs e)
        {
            txtResult.Text = txtResult.Text + "4";
        }

        private void btnCinco_Click(object sender, EventArgs e)
        {
            txtResult.Text = txtResult.Text + "5";
        }

        private void btnSeis_Click(object sender, EventArgs e)
        {
            txtResult.Text = txtResult.Text + "6";
        }

        private void btnSete_Click(object sender, EventArgs e)
        {
            txtResult.Text = txtResult.Text + "7";
        }

        private void btnOito_Click(object sender, EventArgs e)
        {
            txtResult.Text = txtResult.Text + "8";
        }

        private void btnNove_Click(object sender, EventArgs e)
        {
            txtResult.Text = txtResult.Text + "9";
        }

        private void btnPonto_Click(object sender, EventArgs e)
        {
            txtResult.Text = txtResult.Text + ".";
        }

        private void btnMultiplicacao_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(txtResult.Text);
            txtResult.Text = "";
            operacao = "Multiplicacao";
        }

        private void btnSoma_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(txtResult.Text);
            txtResult.Text = "";
            operacao = "Soma";
        }

        private void btnSubtracao_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(txtResult.Text);
            txtResult.Text = "";
            operacao = "Subtracao";
        }

        private void btnResultado_Click(object sender, EventArgs e)
        {
            num2 = float.Parse(txtResult.Text);
            if (operacao == "Divisao")
            {
                txtResult.Text = Convert.ToString(num1 / num2);

            }
            else if (operacao == "Multiplicacao")
            {
                txtResult.Text = Convert.ToString(num1 * num2);

            }
            else if (operacao == "Subtracao")
            {
                txtResult.Text = Convert.ToString(num1 - num2);
            } else if (operacao == "Soma")
            {
                txtResult.Text = Convert.ToString(num1 + num2);
            }
        }

        private void btnCe_Click(object sender, EventArgs e)
        {
            txtResult.Text = "";
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            txtResult.Text = "";
            num1 = 0;
        }

        private void btnDivisao_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(txtResult.Text);
            txtResult.Text = "";
            operacao = "Divisao";
        }
    }
}
