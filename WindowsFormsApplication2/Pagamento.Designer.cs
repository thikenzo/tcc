namespace WindowsFormsApplication2
{
    partial class Pagamento
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label11 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.tipopagamento = new System.Windows.Forms.ComboBox();
            this.tipodoc = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.radioVista = new System.Windows.Forms.RadioButton();
            this.radioPrazo = new System.Windows.Forms.RadioButton();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnGerar = new System.Windows.Forms.Button();
            this.btnMenu = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.nomecliente = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(642, 94);
            this.label11.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(405, 67);
            this.label11.TabIndex = 22;
            this.label11.Text = "PAGAMENTO";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(110, 225);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 25);
            this.label1.TabIndex = 23;
            this.label1.Text = "NOME CLIENTE :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(110, 323);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(212, 25);
            this.label2.TabIndex = 24;
            this.label2.Text = "TIPO PAGAMENTO :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(110, 421);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(209, 25);
            this.label3.TabIndex = 25;
            this.label3.Text = "CONTA BANCÁRIA :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(110, 513);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(267, 25);
            this.label4.TabIndex = 26;
            this.label4.Text = "DATA DE LANÇAMENTO :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(110, 613);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(250, 25);
            this.label5.TabIndex = 27;
            this.label5.Text = "TIPO DE DOCUMENTO :";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(424, 498);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(396, 31);
            this.dateTimePicker1.TabIndex = 28;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // tipopagamento
            // 
            this.tipopagamento.FormattingEnabled = true;
            this.tipopagamento.Location = new System.Drawing.Point(372, 306);
            this.tipopagamento.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tipopagamento.Name = "tipopagamento";
            this.tipopagamento.Size = new System.Drawing.Size(284, 33);
            this.tipopagamento.TabIndex = 29;
            // 
            // tipodoc
            // 
            this.tipodoc.FormattingEnabled = true;
            this.tipodoc.Location = new System.Drawing.Point(424, 598);
            this.tipodoc.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tipodoc.Name = "tipodoc";
            this.tipodoc.Size = new System.Drawing.Size(284, 33);
            this.tipodoc.TabIndex = 30;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1106, 323);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(169, 25);
            this.label6.TabIndex = 31;
            this.label6.Text = "VALOR TOTAL :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1106, 421);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(142, 25);
            this.label7.TabIndex = 32;
            this.label7.Text = "DESCONTO :";
            // 
            // radioVista
            // 
            this.radioVista.AutoSize = true;
            this.radioVista.Location = new System.Drawing.Point(1168, 519);
            this.radioVista.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.radioVista.Name = "radioVista";
            this.radioVista.Size = new System.Drawing.Size(123, 29);
            this.radioVista.TabIndex = 33;
            this.radioVista.TabStop = true;
            this.radioVista.Text = "À VISTA";
            this.radioVista.UseVisualStyleBackColor = true;
            // 
            // radioPrazo
            // 
            this.radioPrazo.AutoSize = true;
            this.radioPrazo.Location = new System.Drawing.Point(1168, 596);
            this.radioPrazo.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.radioPrazo.Name = "radioPrazo";
            this.radioPrazo.Size = new System.Drawing.Size(156, 29);
            this.radioPrazo.TabIndex = 34;
            this.radioPrazo.TabStop = true;
            this.radioPrazo.Text = "PARCELAR";
            this.radioPrazo.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(1344, 588);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(238, 33);
            this.comboBox1.TabIndex = 35;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(110, 719);
            this.label8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(256, 25);
            this.label8.TabIndex = 36;
            this.label8.Text = "OBSERVAÇÕES FINAIS :";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(116, 771);
            this.textBox1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(780, 223);
            this.textBox1.TabIndex = 37;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(1166, 942);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(150, 77);
            this.btnSalvar.TabIndex = 38;
            this.btnSalvar.Text = "SALVAR";
            this.btnSalvar.UseVisualStyleBackColor = true;
            // 
            // btnGerar
            // 
            this.btnGerar.Location = new System.Drawing.Point(1368, 942);
            this.btnGerar.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnGerar.Name = "btnGerar";
            this.btnGerar.Size = new System.Drawing.Size(150, 77);
            this.btnGerar.TabIndex = 39;
            this.btnGerar.Text = "GERAR PDF";
            this.btnGerar.UseVisualStyleBackColor = true;
            // 
            // btnMenu
            // 
            this.btnMenu.Location = new System.Drawing.Point(1566, 942);
            this.btnMenu.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(150, 77);
            this.btnMenu.TabIndex = 40;
            this.btnMenu.Text = "MENU";
            this.btnMenu.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(372, 406);
            this.textBox2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(284, 31);
            this.textBox2.TabIndex = 41;
            // 
            // nomecliente
            // 
            this.nomecliente.AutoSize = true;
            this.nomecliente.Location = new System.Drawing.Point(372, 225);
            this.nomecliente.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.nomecliente.Name = "nomecliente";
            this.nomecliente.Size = new System.Drawing.Size(70, 25);
            this.nomecliente.TabIndex = 42;
            this.nomecliente.Text = "label9";
            this.nomecliente.Click += new System.EventHandler(this.nomecliente_Click);
            // 
            // Pagamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1798, 1063);
            this.Controls.Add(this.nomecliente);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.btnGerar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.radioPrazo);
            this.Controls.Add(this.radioVista);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tipodoc);
            this.Controls.Add(this.tipopagamento);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label11);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Pagamento";
            this.Text = "NOAR ESTÚDIO";
            this.Load += new System.EventHandler(this.Pagamento_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox tipopagamento;
        private System.Windows.Forms.ComboBox tipodoc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton radioVista;
        private System.Windows.Forms.RadioButton radioPrazo;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnGerar;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label nomecliente;
    }
}