namespace calculadora
{
    partial class frmCalculadora
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCalculadora));
            btn1 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            btn4 = new Button();
            btn5 = new Button();
            btn6 = new Button();
            btn9 = new Button();
            btn8 = new Button();
            btn7 = new Button();
            btn0 = new Button();
            btnLimpar = new Button();
            btnIgual = new Button();
            btnSoma = new Button();
            btnSubtracao = new Button();
            btnMultiplicacao = new Button();
            btnDivisao = new Button();
            txtResultado = new TextBox();
            txtTroca = new TextBox();
            SuspendLayout();
            // 
            // btn1
            // 
            btn1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btn1.Location = new Point(25, 119);
            btn1.Name = "btn1";
            btn1.Size = new Size(75, 32);
            btn1.TabIndex = 0;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += btn1_Click;
            // 
            // btn2
            // 
            btn2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btn2.Location = new Point(122, 119);
            btn2.Name = "btn2";
            btn2.Size = new Size(75, 32);
            btn2.TabIndex = 1;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += btn2_Click;
            // 
            // btn3
            // 
            btn3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btn3.Location = new Point(216, 119);
            btn3.Name = "btn3";
            btn3.Size = new Size(75, 32);
            btn3.TabIndex = 2;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += btn3_Click;
            // 
            // btn4
            // 
            btn4.Location = new Point(25, 157);
            btn4.Name = "btn4";
            btn4.Size = new Size(75, 32);
            btn4.TabIndex = 3;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += btn4_Click;
            // 
            // btn5
            // 
            btn5.Location = new Point(122, 157);
            btn5.Name = "btn5";
            btn5.Size = new Size(75, 32);
            btn5.TabIndex = 4;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += btn5_Click;
            // 
            // btn6
            // 
            btn6.Location = new Point(216, 157);
            btn6.Name = "btn6";
            btn6.Size = new Size(75, 32);
            btn6.TabIndex = 5;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += btn6_Click;
            // 
            // btn9
            // 
            btn9.Location = new Point(216, 199);
            btn9.Name = "btn9";
            btn9.Size = new Size(75, 28);
            btn9.TabIndex = 6;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += btn9_Click;
            // 
            // btn8
            // 
            btn8.Location = new Point(122, 195);
            btn8.Name = "btn8";
            btn8.Size = new Size(75, 32);
            btn8.TabIndex = 7;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += btn8_Click;
            // 
            // btn7
            // 
            btn7.Location = new Point(25, 195);
            btn7.Name = "btn7";
            btn7.Size = new Size(75, 32);
            btn7.TabIndex = 8;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += btn7_Click;
            // 
            // btn0
            // 
            btn0.Location = new Point(25, 233);
            btn0.Name = "btn0";
            btn0.Size = new Size(75, 28);
            btn0.TabIndex = 9;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = true;
            btn0.Click += btn0_Click;
            // 
            // btnLimpar
            // 
            btnLimpar.Location = new Point(25, 267);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(75, 38);
            btnLimpar.TabIndex = 10;
            btnLimpar.Text = "CE";
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // btnIgual
            // 
            btnIgual.Location = new Point(122, 233);
            btnIgual.Name = "btnIgual";
            btnIgual.Size = new Size(169, 42);
            btnIgual.TabIndex = 11;
            btnIgual.Text = "=";
            btnIgual.UseVisualStyleBackColor = true;
            btnIgual.Click += btnIgual_Click;
            // 
            // btnSoma
            // 
            btnSoma.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnSoma.Location = new Point(312, 119);
            btnSoma.Name = "btnSoma";
            btnSoma.Size = new Size(75, 42);
            btnSoma.TabIndex = 13;
            btnSoma.Text = "+";
            btnSoma.UseVisualStyleBackColor = true;
            btnSoma.Click += btnSoma_Click;
            // 
            // btnSubtracao
            // 
            btnSubtracao.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnSubtracao.Location = new Point(312, 167);
            btnSubtracao.Name = "btnSubtracao";
            btnSubtracao.Size = new Size(75, 42);
            btnSubtracao.TabIndex = 14;
            btnSubtracao.Text = "-";
            btnSubtracao.UseVisualStyleBackColor = true;
            btnSubtracao.Click += btnSubtracao_Click;
            // 
            // btnMultiplicacao
            // 
            btnMultiplicacao.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnMultiplicacao.Location = new Point(312, 215);
            btnMultiplicacao.Name = "btnMultiplicacao";
            btnMultiplicacao.Size = new Size(75, 42);
            btnMultiplicacao.TabIndex = 15;
            btnMultiplicacao.Text = "x";
            btnMultiplicacao.UseVisualStyleBackColor = true;
            btnMultiplicacao.Click += btnMultiplicacao_Click;
            // 
            // btnDivisao
            // 
            btnDivisao.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnDivisao.Location = new Point(312, 263);
            btnDivisao.Name = "btnDivisao";
            btnDivisao.Size = new Size(75, 42);
            btnDivisao.TabIndex = 16;
            btnDivisao.Text = "/";
            btnDivisao.UseVisualStyleBackColor = true;
            btnDivisao.Click += btnDivisao_Click;
            // 
            // txtResultado
            // 
            txtResultado.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            txtResultado.Location = new Point(122, 34);
            txtResultado.Multiline = true;
            txtResultado.Name = "txtResultado";
            txtResultado.ReadOnly = true;
            txtResultado.Size = new Size(265, 58);
            txtResultado.TabIndex = 17;
            txtResultado.TextAlign = HorizontalAlignment.Right;
            // 
            // txtTroca
            // 
            txtTroca.BackColor = SystemColors.ScrollBar;
            txtTroca.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            txtTroca.Location = new Point(25, 34);
            txtTroca.Multiline = true;
            txtTroca.Name = "txtTroca";
            txtTroca.Size = new Size(91, 58);
            txtTroca.TabIndex = 18;
            // 
            // frmCalculadora
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GrayText;
            ClientSize = new Size(423, 352);
            Controls.Add(txtTroca);
            Controls.Add(txtResultado);
            Controls.Add(btnDivisao);
            Controls.Add(btnMultiplicacao);
            Controls.Add(btnSubtracao);
            Controls.Add(btnSoma);
            Controls.Add(btnIgual);
            Controls.Add(btnLimpar);
            Controls.Add(btn0);
            Controls.Add(btn7);
            Controls.Add(btn8);
            Controls.Add(btn9);
            Controls.Add(btn6);
            Controls.Add(btn5);
            Controls.Add(btn4);
            Controls.Add(btn3);
            Controls.Add(btn2);
            Controls.Add(btn1);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmCalculadora";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculadora";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn1;
        private Button btn2;
        private Button btn3;
        private Button btn4;
        private Button btn5;
        private Button btn6;
        private Button btn9;
        private Button btn8;
        private Button btn7;
        private Button btn0;
        private Button btnLimpar;
        private Button btnIgual;
        private Button btnSoma;
        private Button btnSubtracao;
        private Button btnMultiplicacao;
        private Button btnDivisao;
        private TextBox txtResultado;
        private TextBox txtTroca;
    }
}
