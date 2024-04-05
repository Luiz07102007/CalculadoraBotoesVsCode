namespace Calculadora
{
    public partial class Form1 : Form
    {
        public decimal Resultado { get; set; }
        public decimal Valor { get; set; }
        private Operacao opselect { get; set; }


        private enum Operacao
        {
            soma,
            menos,
            vezes,
            divisao

        }


        public Form1()
        {
            InitializeComponent();
        }

        private void bt_0_Click(object sender, EventArgs e)
        {
            tb_calculadora.Text += "0";
        }

        private void bt_1_Click(object sender, EventArgs e)
        {
            tb_calculadora.Text += "1";
        }

        private void bt_2_Click(object sender, EventArgs e)
        {
            tb_calculadora.Text += "2";
        }

        private void bt_3_Click(object sender, EventArgs e)
        {
            tb_calculadora.Text += "3";
        }

        private void bt_4_Click(object sender, EventArgs e)
        {
            tb_calculadora.Text += "4";
        }

        private void bt_5_Click(object sender, EventArgs e)
        {
            tb_calculadora.Text += "5";
        }

        private void bt_6_Click(object sender, EventArgs e)
        {
            tb_calculadora.Text += "6";
        }

        private void bt_7_Click(object sender, EventArgs e)
        {
            tb_calculadora.Text += "7";
        }

        private void bt_8_Click(object sender, EventArgs e)
        {
            tb_calculadora.Text += "8";
        }

        private void bt_9_Click(object sender, EventArgs e)
        {
            tb_calculadora.Text += "9";
        }

        private void bt_soma_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tb_calculadora.Text))
            {
                opselect = Operacao.soma;
                Valor = Convert.ToDecimal(tb_calculadora.Text);
                tb_calculadora.Text = "";
                lb_op.Text = "+";
            }
        }

        private void bt_menos_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tb_calculadora.Text))
            {
                opselect = Operacao.menos;
                Valor = Convert.ToDecimal(tb_calculadora.Text);
                tb_calculadora.Text = "";
                lb_op.Text = "-";
            }
        }

        private void bt_vezes_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tb_calculadora.Text))
            {
                opselect = Operacao.vezes;
                Valor = Convert.ToDecimal(tb_calculadora.Text);
                tb_calculadora.Text = "";
                lb_op.Text = "X";
            }
        }

        private void bt_divisao_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tb_calculadora.Text))
            {
                opselect = Operacao.divisao;
                Valor = Convert.ToDecimal(tb_calculadora.Text);
                tb_calculadora.Text = "";
                lb_op.Text = "/";
            }
        }

        private void bt_igual_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tb_calculadora.Text))
            {
                if (opselect == Operacao.soma)
                {
                    Resultado = Valor + Convert.ToDecimal(tb_calculadora.Text);

                }
                else if (opselect == Operacao.menos)
                {
                    Resultado = Valor - Convert.ToDecimal(tb_calculadora.Text);
                }
                else if (opselect == Operacao.vezes)
                {
                    Resultado = Valor * Convert.ToDecimal(tb_calculadora.Text);
                }
                else if (opselect == Operacao.divisao)
                {
                    Resultado = Valor / Convert.ToDecimal(tb_calculadora.Text);
                }

                tb_calculadora.Text = Convert.ToString(Resultado);
                lb_op.Text = "=";
            }
        }
        private void bt_virgula_Click(object sender, EventArgs e)
        {
            if (!tb_calculadora.Text.Contains(","))
                tb_calculadora.Text += ",";

        }

        private void bt_limpar_Click(object sender, EventArgs e)
        {
            tb_calculadora.Text = "";
            lb_op.Text = "";
        }

        private void tb_calculadora_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
