using System.Data;
using System.Collections.Generic;

namespace CalculadoraForms
{
    public partial class Calculadora : Form
    {
        public Calculadora()
        {
            InitializeComponent();
        }



        private void btn_eq_Click(object sender, EventArgs e)
        {
            try
            {
                string content = label1.Text;

                if (content.Contains("/") && content.Contains("0"))
                {
                    throw new Exception();
                }

                var result = new DataTable().Compute(content, null);
                label1.Text = result.ToString();
            }
            catch
            {
                label1.Text = "Operação inválida";
            }
        }

        private void mostraDisplay(string num)
        {
            if (label1.Text == "Operação inválida" || label1.Text == "NaN")
            {
               label1.Text = "";
            }
            label1.Text += num;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            mostraDisplay("1");
        }

        private void btn_plus_Click(object sender, EventArgs e)
        {
            mostraDisplay("+");
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            mostraDisplay("2");
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            mostraDisplay("3");
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            mostraDisplay("4");
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            mostraDisplay("5");
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            mostraDisplay("6");
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            mostraDisplay("7");
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            mostraDisplay("8");
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            mostraDisplay("9");
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            label1.Text = "";
        }

        private void btn_minus_Click(object sender, EventArgs e)
        {
            mostraDisplay("-");
        }

        private void btn_multi_Click(object sender, EventArgs e)
        {
            mostraDisplay("*");
        }

        private void btn_div_Click(object sender, EventArgs e)
        {
            mostraDisplay("/");
        }

        private void btn_par1_Click(object sender, EventArgs e)
        {
            mostraDisplay("(");
        }

        private void btn_par2_Click(object sender, EventArgs e)
        {
            mostraDisplay(")");
        }
        private void btn0_Click(object sender, EventArgs e)
        {
            mostraDisplay("0");
        }
    }
}
