namespace calculadora
{
    public partial class frmCalculadora : Form
    {
        public frmCalculadora()
        {
            InitializeComponent();
        }

        Calculadora calc = new Calculadora();

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtResultado.Clear();
            txtTroca.Clear();
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "0";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "9";
        }

        private void btnSoma_Click(object sender, EventArgs e)
        {
            calc.v1 = Convert.ToDouble(txtResultado.Text);
            calc.operacao = '+';

            txtTroca.Text = txtResultado.Text + calc.operacao;
            txtResultado.Clear();
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            calc.v2 = Convert.ToDouble(txtResultado.Text);

            txtResultado.Clear();
            calc.Calcular();
            txtResultado.Text = calc.resultado.ToString();
        }

        private void btnSubtracao_Click(object sender, EventArgs e)
        {
            calc.v1 = Convert.ToDouble(txtResultado.Text);
            calc.operacao = '-';

            txtTroca.Text = txtResultado.Text + calc.operacao;
            txtResultado.Clear();
            
        }

        private void btnMultiplicacao_Click(object sender, EventArgs e)
        {
            calc.v1 = Convert.ToDouble(txtResultado.Text);
            calc.operacao = '*';

            txtTroca.Text = txtResultado.Text + calc.operacao;
            txtResultado.Clear();
        }

        private void btnDivisao_Click(object sender, EventArgs e)
        {
            calc.v1 = Convert.ToDouble(txtResultado.Text);
            calc.operacao = '/';

            txtTroca.Text = txtResultado.Text + calc.operacao;
            txtResultado.Clear();
        }
    }
}
