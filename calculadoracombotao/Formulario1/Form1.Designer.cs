namespace Calculadora
{
    partial class Form1
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
            tb_calculadora = new TextBox();
            bt_1 = new Button();
            bt_2 = new Button();
            bt_3 = new Button();
            bt_4 = new Button();
            bt_5 = new Button();
            bt_6 = new Button();
            bt_7 = new Button();
            bt_8 = new Button();
            bt_9 = new Button();
            bt_0 = new Button();
            bt_limpar = new Button();
            bt_divisao = new Button();
            bt_vezes = new Button();
            bt_soma = new Button();
            bt_igual = new Button();
            bt_menos = new Button();
            bt_virgula = new Button();
            lb_op = new Label();
            SuspendLayout();
            // 
            // tb_calculadora
            // 
            tb_calculadora.BackColor = Color.Black;
            tb_calculadora.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            tb_calculadora.ForeColor = Color.White;
            tb_calculadora.Location = new Point(12, 66);
            tb_calculadora.Name = "tb_calculadora";
            tb_calculadora.ReadOnly = true;
            tb_calculadora.Size = new Size(261, 54);
            tb_calculadora.TabIndex = 0;
            tb_calculadora.TextAlign = HorizontalAlignment.Right;
            tb_calculadora.TextChanged += tb_calculadora_TextChanged;
            // 
            // bt_1
            // 
            bt_1.BackColor = Color.DimGray;
            bt_1.FlatStyle = FlatStyle.Popup;
            bt_1.Location = new Point(12, 360);
            bt_1.Name = "bt_1";
            bt_1.Size = new Size(59, 40);
            bt_1.TabIndex = 1;
            bt_1.Text = "1";
            bt_1.UseVisualStyleBackColor = false;
            bt_1.Click += bt_1_Click;
            // 
            // bt_2
            // 
            bt_2.BackColor = Color.DimGray;
            bt_2.FlatStyle = FlatStyle.Popup;
            bt_2.Location = new Point(77, 360);
            bt_2.Name = "bt_2";
            bt_2.Size = new Size(59, 40);
            bt_2.TabIndex = 2;
            bt_2.Text = "2";
            bt_2.UseVisualStyleBackColor = false;
            bt_2.Click += bt_2_Click;
            // 
            // bt_3
            // 
            bt_3.BackColor = Color.DimGray;
            bt_3.FlatStyle = FlatStyle.Flat;
            bt_3.Location = new Point(142, 360);
            bt_3.Name = "bt_3";
            bt_3.Size = new Size(59, 40);
            bt_3.TabIndex = 3;
            bt_3.Text = "3";
            bt_3.UseVisualStyleBackColor = false;
            bt_3.Click += bt_3_Click;
            // 
            // bt_4
            // 
            bt_4.BackColor = Color.DimGray;
            bt_4.FlatStyle = FlatStyle.Popup;
            bt_4.Location = new Point(12, 306);
            bt_4.Name = "bt_4";
            bt_4.Size = new Size(59, 40);
            bt_4.TabIndex = 4;
            bt_4.Text = "4";
            bt_4.UseVisualStyleBackColor = false;
            bt_4.Click += bt_4_Click;
            // 
            // bt_5
            // 
            bt_5.BackColor = Color.DimGray;
            bt_5.FlatStyle = FlatStyle.Popup;
            bt_5.Location = new Point(77, 306);
            bt_5.Name = "bt_5";
            bt_5.Size = new Size(59, 40);
            bt_5.TabIndex = 5;
            bt_5.Text = "5";
            bt_5.UseVisualStyleBackColor = false;
            bt_5.Click += bt_5_Click;
            // 
            // bt_6
            // 
            bt_6.BackColor = Color.DimGray;
            bt_6.FlatStyle = FlatStyle.Popup;
            bt_6.Location = new Point(142, 306);
            bt_6.Name = "bt_6";
            bt_6.Size = new Size(59, 40);
            bt_6.TabIndex = 6;
            bt_6.Text = "6";
            bt_6.UseVisualStyleBackColor = false;
            bt_6.Click += bt_6_Click;
            // 
            // bt_7
            // 
            bt_7.BackColor = Color.DimGray;
            bt_7.FlatStyle = FlatStyle.Popup;
            bt_7.Location = new Point(12, 249);
            bt_7.Name = "bt_7";
            bt_7.Size = new Size(59, 40);
            bt_7.TabIndex = 7;
            bt_7.Text = "7";
            bt_7.UseVisualStyleBackColor = false;
            bt_7.Click += bt_7_Click;
            // 
            // bt_8
            // 
            bt_8.BackColor = Color.DimGray;
            bt_8.FlatStyle = FlatStyle.Popup;
            bt_8.Location = new Point(77, 249);
            bt_8.Name = "bt_8";
            bt_8.Size = new Size(59, 40);
            bt_8.TabIndex = 8;
            bt_8.Text = "8";
            bt_8.UseVisualStyleBackColor = false;
            bt_8.Click += bt_8_Click;
            // 
            // bt_9
            // 
            bt_9.BackColor = Color.DimGray;
            bt_9.FlatStyle = FlatStyle.Popup;
            bt_9.Location = new Point(142, 249);
            bt_9.Name = "bt_9";
            bt_9.Size = new Size(59, 40);
            bt_9.TabIndex = 9;
            bt_9.Text = "9";
            bt_9.UseVisualStyleBackColor = false;
            bt_9.Click += bt_9_Click;
            // 
            // bt_0
            // 
            bt_0.BackColor = Color.DimGray;
            bt_0.FlatStyle = FlatStyle.Popup;
            bt_0.Location = new Point(77, 406);
            bt_0.Name = "bt_0";
            bt_0.Size = new Size(59, 40);
            bt_0.TabIndex = 10;
            bt_0.Text = "0";
            bt_0.UseVisualStyleBackColor = false;
            bt_0.Click += bt_0_Click;
            // 
            // bt_limpar
            // 
            bt_limpar.BackColor = Color.Black;
            bt_limpar.FlatStyle = FlatStyle.Popup;
            bt_limpar.ForeColor = Color.White;
            bt_limpar.Location = new Point(142, 201);
            bt_limpar.Name = "bt_limpar";
            bt_limpar.Size = new Size(59, 40);
            bt_limpar.TabIndex = 11;
            bt_limpar.Text = "C";
            bt_limpar.UseVisualStyleBackColor = false;
            bt_limpar.Click += bt_limpar_Click;
            // 
            // bt_divisao
            // 
            bt_divisao.BackColor = Color.Black;
            bt_divisao.FlatStyle = FlatStyle.Popup;
            bt_divisao.ForeColor = Color.White;
            bt_divisao.Location = new Point(214, 201);
            bt_divisao.Name = "bt_divisao";
            bt_divisao.Size = new Size(59, 40);
            bt_divisao.TabIndex = 12;
            bt_divisao.Text = "/";
            bt_divisao.UseVisualStyleBackColor = false;
            bt_divisao.Click += bt_divisao_Click;
            // 
            // bt_vezes
            // 
            bt_vezes.BackColor = Color.Black;
            bt_vezes.FlatStyle = FlatStyle.Popup;
            bt_vezes.ForeColor = Color.White;
            bt_vezes.Location = new Point(214, 249);
            bt_vezes.Name = "bt_vezes";
            bt_vezes.Size = new Size(59, 40);
            bt_vezes.TabIndex = 13;
            bt_vezes.Text = "X";
            bt_vezes.UseVisualStyleBackColor = false;
            bt_vezes.Click += bt_vezes_Click;
            // 
            // bt_soma
            // 
            bt_soma.BackColor = Color.Black;
            bt_soma.FlatStyle = FlatStyle.Popup;
            bt_soma.ForeColor = Color.White;
            bt_soma.Location = new Point(214, 360);
            bt_soma.Name = "bt_soma";
            bt_soma.Size = new Size(59, 40);
            bt_soma.TabIndex = 14;
            bt_soma.Text = "+";
            bt_soma.UseVisualStyleBackColor = false;
            bt_soma.Click += bt_soma_Click;
            // 
            // bt_igual
            // 
            bt_igual.BackColor = SystemColors.ActiveCaption;
            bt_igual.FlatStyle = FlatStyle.Popup;
            bt_igual.Location = new Point(142, 406);
            bt_igual.Name = "bt_igual";
            bt_igual.Size = new Size(131, 40);
            bt_igual.TabIndex = 15;
            bt_igual.Text = "=";
            bt_igual.UseVisualStyleBackColor = false;
            bt_igual.Click += bt_igual_Click;
            // 
            // bt_menos
            // 
            bt_menos.BackColor = Color.Black;
            bt_menos.FlatStyle = FlatStyle.Popup;
            bt_menos.ForeColor = Color.White;
            bt_menos.Location = new Point(214, 306);
            bt_menos.Name = "bt_menos";
            bt_menos.Size = new Size(59, 40);
            bt_menos.TabIndex = 16;
            bt_menos.Text = "-";
            bt_menos.UseVisualStyleBackColor = false;
            bt_menos.Click += bt_menos_Click;
            // 
            // bt_virgula
            // 
            bt_virgula.BackColor = Color.DimGray;
            bt_virgula.FlatStyle = FlatStyle.Popup;
            bt_virgula.Location = new Point(12, 406);
            bt_virgula.Name = "bt_virgula";
            bt_virgula.Size = new Size(59, 40);
            bt_virgula.TabIndex = 17;
            bt_virgula.Text = ",";
            bt_virgula.UseVisualStyleBackColor = false;
            bt_virgula.Click += bt_virgula_Click;
            // 
            // lb_op
            // 
            lb_op.AutoSize = true;
            lb_op.BackColor = Color.Black;
            lb_op.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            lb_op.ForeColor = Color.White;
            lb_op.Location = new Point(24, 70);
            lb_op.Name = "lb_op";
            lb_op.Size = new Size(0, 47);
            lb_op.TabIndex = 18;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(285, 505);
            Controls.Add(lb_op);
            Controls.Add(bt_virgula);
            Controls.Add(bt_menos);
            Controls.Add(bt_igual);
            Controls.Add(bt_soma);
            Controls.Add(bt_vezes);
            Controls.Add(bt_divisao);
            Controls.Add(bt_limpar);
            Controls.Add(bt_0);
            Controls.Add(bt_9);
            Controls.Add(bt_8);
            Controls.Add(bt_7);
            Controls.Add(bt_6);
            Controls.Add(bt_5);
            Controls.Add(bt_4);
            Controls.Add(bt_3);
            Controls.Add(bt_2);
            Controls.Add(bt_1);
            Controls.Add(tb_calculadora);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tb_calculadora;
        private Button bt_1;
        private Button bt_2;
        private Button bt_3;
        private Button bt_4;
        private Button bt_5;
        private Button bt_6;
        private Button bt_7;
        private Button bt_8;
        private Button bt_9;
        private Button bt_0;
        private Button bt_limpar;
        private Button bt_divisao;
        private Button bt_vezes;
        private Button bt_soma;
        private Button bt_igual;
        private Button bt_menos;
        private Button bt_virgula;
        private Label lb_op;
    }
}
