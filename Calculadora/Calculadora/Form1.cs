namespace Calculadora
{
    public partial class Form1 : Form
    {
        public decimal Resultado { get; set; }
        public decimal Valor { get; set; }

        private Operacao OperacaoSelecionada { get; set; } 

        private enum Operacao 
        {
            Adicao,
            Subtracao,
            Multiplicacao,
            Divisao,
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnZero_Click(object sender, EventArgs e) // evento clilcar no numero
        {
            txtResultao.Text += "0"; // quando clicar no numero a string "0" vai parecer no txtResultado (textBox), o += é para concatenar os numeros 
        }

        private void btnUm_Click(object sender, EventArgs e)
        {
            txtResultao.Text += "1";
        }

        private void btnDois_Click(object sender, EventArgs e)
        {
            txtResultao.Text += "2";
        }

        private void btnTres_Click(object sender, EventArgs e)
        {
            txtResultao.Text += "3";
        }

        private void btnQuatro_Click(object sender, EventArgs e)
        {
            txtResultao.Text += "4";
        }

        private void btnCinco_Click(object sender, EventArgs e)
        {
            txtResultao.Text += "5";
        }

        private void btnSeis_Click(object sender, EventArgs e)
        {
            txtResultao.Text += "6";
        }

        private void btnSete_Click(object sender, EventArgs e)
        {
            txtResultao.Text += "7";
        }

        private void btnOito_Click(object sender, EventArgs e)
        {
            txtResultao.Text += "8";
        }

        private void btnNove_Click(object sender, EventArgs e)
        {
            txtResultao.Text += "9";
        }

        private void btnAdicao_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = Operacao.Adicao;
            Valor = Convert.ToDecimal(txtResultao.Text); // converter o valor de string para decimal
            txtResultao.Text = ""; // limpa o campo apos clilcar no evento, atribui vazio para o textBox
            lblOpecao.Text = "+"; // mostra o sinal da operecao

        }

        private void btnSubtracao_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = Operacao.Subtracao;
            Valor = Convert.ToDecimal(txtResultao.Text);
            txtResultao.Text = "";
            lblOpecao.Text = "-";
        }

        private void btnMultiplicacao_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = Operacao.Multiplicacao;
            Valor = Convert.ToDecimal(txtResultao.Text);
            txtResultao.Text = "";
            lblOpecao.Text = "X";
        }

        private void btnDivisao_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = Operacao.Divisao;
            Valor = Convert.ToDecimal(txtResultao.Text);
            txtResultao.Text = "";
            lblOpecao.Text = "/";
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            switch (OperacaoSelecionada) //
            {
                case Operacao.Adicao:
                    Resultado = Valor + Convert.ToDecimal(txtResultao.Text);
                    break;
                case Operacao.Subtracao:
                    Resultado = Valor - Convert.ToDecimal(txtResultao.Text);
                    break;
                case Operacao.Multiplicacao:
                    Resultado = Valor * Convert.ToDecimal(txtResultao.Text);
                    break;
                case Operacao.Divisao:
                    if (Convert.ToDecimal(txtResultao.Text) == 0) // verificar se o divisor = 0
                    {
                        txtResultao.Text = "não é possivel dividir por zero";
                        return;
                    }
                    else
                    {
                        Resultado = Valor / Convert.ToDecimal(txtResultao.Text);
                    }
                    break;
            }

            txtResultao.Text = Convert.ToString(Resultado);
            lblOpecao.Text = "=";

        }

        private void btnVirgula_Click(object sender, EventArgs e)
        {
            if (!txtResultao.Text.Contains(",")) // se nao conter a virgula ele faz a seguinte acao
            {
                txtResultao.Text += ","; // adciona uma virgula
            }

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtResultao.Text = ""; // limpar o visor 
            lblOpecao.Text = "";
        }
    }
}
