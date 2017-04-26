namespace WindowsFormsApplication2
{
    partial class Cad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cad));
            this.adicionar = new System.Windows.Forms.Button();
            this.voltar = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.NOME = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTelefone = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCelular = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtN = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtRg = new System.Windows.Forms.MaskedTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtCpf = new System.Windows.Forms.MaskedTextBox();
            this.editar = new System.Windows.Forms.Button();
            this.Login = new System.Windows.Forms.Label();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.nivelacesso = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // adicionar
            // 
            this.adicionar.BackColor = System.Drawing.Color.MidnightBlue;
            this.adicionar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.adicionar.FlatAppearance.BorderSize = 2;
            this.adicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.adicionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adicionar.ForeColor = System.Drawing.Color.White;
            this.adicionar.Image = ((System.Drawing.Image)(resources.GetObject("adicionar.Image")));
            this.adicionar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.adicionar.Location = new System.Drawing.Point(80, 1073);
            this.adicionar.Margin = new System.Windows.Forms.Padding(6);
            this.adicionar.Name = "adicionar";
            this.adicionar.Size = new System.Drawing.Size(242, 63);
            this.adicionar.TabIndex = 0;
            this.adicionar.Text = "    ADICIONAR";
            this.adicionar.UseVisualStyleBackColor = false;
            this.adicionar.Click += new System.EventHandler(this.adicionar_Click);
            // 
            // voltar
            // 
            this.voltar.BackColor = System.Drawing.Color.MidnightBlue;
            this.voltar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.voltar.FlatAppearance.BorderSize = 2;
            this.voltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.voltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.voltar.ForeColor = System.Drawing.Color.White;
            this.voltar.Image = ((System.Drawing.Image)(resources.GetObject("voltar.Image")));
            this.voltar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.voltar.Location = new System.Drawing.Point(974, 1073);
            this.voltar.Margin = new System.Windows.Forms.Padding(6);
            this.voltar.Name = "voltar";
            this.voltar.Size = new System.Drawing.Size(196, 63);
            this.voltar.TabIndex = 2;
            this.voltar.Text = "     MENU";
            this.voltar.UseVisualStyleBackColor = false;
            this.voltar.Click += new System.EventHandler(this.voltar_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.SystemColors.Menu;
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(220, 596);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(6);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(460, 32);
            this.txtEmail.TabIndex = 15;
            // 
            // txtNome
            // 
            this.txtNome.BackColor = System.Drawing.SystemColors.Menu;
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(220, 385);
            this.txtNome.Margin = new System.Windows.Forms.Padding(6);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(460, 32);
            this.txtNome.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(100, 602);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 26);
            this.label4.TabIndex = 11;
            this.label4.Text = "EMAIL :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(100, 485);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 26);
            this.label3.TabIndex = 10;
            this.label3.Text = "TELEFONE :";
            // 
            // NOME
            // 
            this.NOME.AutoSize = true;
            this.NOME.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NOME.Location = new System.Drawing.Point(106, 391);
            this.NOME.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.NOME.Name = "NOME";
            this.NOME.Size = new System.Drawing.Size(96, 26);
            this.NOME.TabIndex = 9;
            this.NOME.Text = "NOME :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(822, 255);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 25);
            this.label1.TabIndex = 16;
            this.label1.Text = "SENHA";
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(948, 241);
            this.txtSenha.Margin = new System.Windows.Forms.Padding(6);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.ReadOnly = true;
            this.txtSenha.Size = new System.Drawing.Size(196, 33);
            this.txtSenha.TabIndex = 17;
            this.txtSenha.Text = "NOAR";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkRed;
            this.label2.Location = new System.Drawing.Point(460, 92);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(367, 69);
            this.label2.TabIndex = 18;
            this.label2.Text = "CADASTRO";
            // 
            // txtTelefone
            // 
            this.txtTelefone.BackColor = System.Drawing.SystemColors.Menu;
            this.txtTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefone.Location = new System.Drawing.Point(272, 479);
            this.txtTelefone.Margin = new System.Windows.Forms.Padding(6);
            this.txtTelefone.Mask = "(00)0000 0000";
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(206, 32);
            this.txtTelefone.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(641, 482);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 26);
            this.label5.TabIndex = 20;
            this.label5.Text = "CELULAR :";
            // 
            // txtCelular
            // 
            this.txtCelular.BackColor = System.Drawing.SystemColors.Menu;
            this.txtCelular.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCelular.Location = new System.Drawing.Point(800, 476);
            this.txtCelular.Margin = new System.Windows.Forms.Padding(6);
            this.txtCelular.Mask = "(00)0000 0000";
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(206, 32);
            this.txtCelular.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(90, 829);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(160, 26);
            this.label6.TabIndex = 22;
            this.label6.Text = "ENDEREÇO :";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // txtEndereco
            // 
            this.txtEndereco.BackColor = System.Drawing.SystemColors.Menu;
            this.txtEndereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEndereco.Location = new System.Drawing.Point(262, 821);
            this.txtEndereco.Margin = new System.Windows.Forms.Padding(6);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(460, 32);
            this.txtEndereco.TabIndex = 23;
            this.txtEndereco.TextChanged += new System.EventHandler(this.txtEndereco_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(795, 827);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 26);
            this.label7.TabIndex = 24;
            this.label7.Text = "Nº :";
            // 
            // txtN
            // 
            this.txtN.BackColor = System.Drawing.SystemColors.Menu;
            this.txtN.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtN.Location = new System.Drawing.Point(874, 821);
            this.txtN.Margin = new System.Windows.Forms.Padding(6);
            this.txtN.Name = "txtN";
            this.txtN.Size = new System.Drawing.Size(114, 32);
            this.txtN.TabIndex = 25;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(90, 946);
            this.label8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(117, 26);
            this.label8.TabIndex = 26;
            this.label8.Text = "BAIRRO :";
            // 
            // txtBairro
            // 
            this.txtBairro.BackColor = System.Drawing.SystemColors.Menu;
            this.txtBairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBairro.Location = new System.Drawing.Point(246, 940);
            this.txtBairro.Margin = new System.Windows.Forms.Padding(6);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(278, 32);
            this.txtBairro.TabIndex = 27;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(100, 714);
            this.label9.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 26);
            this.label9.TabIndex = 28;
            this.label9.Text = "RG :";
            // 
            // txtRg
            // 
            this.txtRg.BackColor = System.Drawing.SystemColors.Menu;
            this.txtRg.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRg.Location = new System.Drawing.Point(184, 708);
            this.txtRg.Margin = new System.Windows.Forms.Padding(6);
            this.txtRg.Mask = "00000000-0";
            this.txtRg.Name = "txtRg";
            this.txtRg.Size = new System.Drawing.Size(206, 32);
            this.txtRg.TabIndex = 29;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(522, 714);
            this.label10.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 26);
            this.label10.TabIndex = 30;
            this.label10.Text = "CPF :";
            // 
            // txtCpf
            // 
            this.txtCpf.BackColor = System.Drawing.SystemColors.Menu;
            this.txtCpf.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCpf.Location = new System.Drawing.Point(607, 708);
            this.txtCpf.Margin = new System.Windows.Forms.Padding(6);
            this.txtCpf.Mask = "000.000.000.00";
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(208, 32);
            this.txtCpf.TabIndex = 31;
            // 
            // editar
            // 
            this.editar.BackColor = System.Drawing.Color.MidnightBlue;
            this.editar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.editar.FlatAppearance.BorderSize = 2;
            this.editar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editar.ForeColor = System.Drawing.Color.White;
            this.editar.Image = ((System.Drawing.Image)(resources.GetObject("editar.Image")));
            this.editar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.editar.Location = new System.Drawing.Point(368, 1073);
            this.editar.Margin = new System.Windows.Forms.Padding(6);
            this.editar.Name = "editar";
            this.editar.Size = new System.Drawing.Size(242, 63);
            this.editar.TabIndex = 32;
            this.editar.Text = "     EDITAR";
            this.editar.UseVisualStyleBackColor = false;
            this.editar.Click += new System.EventHandler(this.editar_Click);
            // 
            // Login
            // 
            this.Login.AutoSize = true;
            this.Login.Location = new System.Drawing.Point(824, 184);
            this.Login.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(73, 25);
            this.Login.TabIndex = 34;
            this.Login.Text = "LOGIN";
            // 
            // txtLogin
            // 
            this.txtLogin.Location = new System.Drawing.Point(950, 170);
            this.txtLogin.Margin = new System.Windows.Forms.Padding(6);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.ReadOnly = true;
            this.txtLogin.Size = new System.Drawing.Size(196, 33);
            this.txtLogin.TabIndex = 35;
            this.txtLogin.Text = "NOAR";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(108, 276);
            this.label11.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(241, 26);
            this.label11.TabIndex = 36;
            this.label11.Text = "NIVEL DE ACESSO :";
            // 
            // nivelacesso
            // 
            this.nivelacesso.BackColor = System.Drawing.SystemColors.Menu;
            this.nivelacesso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.nivelacesso.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nivelacesso.FormattingEnabled = true;
            this.nivelacesso.Location = new System.Drawing.Point(382, 268);
            this.nivelacesso.Margin = new System.Windows.Forms.Padding(6);
            this.nivelacesso.Name = "nivelacesso";
            this.nivelacesso.Size = new System.Drawing.Size(312, 34);
            this.nivelacesso.TabIndex = 37;
            this.nivelacesso.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.nivelacesso.Enter += new System.EventHandler(this.nivelacesso_Enter);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(139, 119);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 33);
            this.textBox1.TabIndex = 38;
            // 
            // Cad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Stretch;
            this.BackgroundImageStore = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImageStore")));
            this.ClientSize = new System.Drawing.Size(1254, 1171);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.nivelacesso);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtLogin);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.editar);
            this.Controls.Add(this.txtCpf);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtRg);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtBairro);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtN);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtEndereco);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtCelular);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.NOME);
            this.Controls.Add(this.voltar);
            this.Controls.Add(this.adicionar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Cad";
            this.Text = "NOAR ESTÚDIO - CADASTRAR";
            this.Load += new System.EventHandler(this.Cad_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button voltar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label NOME;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label Login;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.Label label11;
        public System.Windows.Forms.TextBox txtEmail;
        public System.Windows.Forms.TextBox txtNome;
        public System.Windows.Forms.MaskedTextBox txtTelefone;
        public System.Windows.Forms.MaskedTextBox txtCelular;
        public System.Windows.Forms.TextBox txtEndereco;
        public System.Windows.Forms.TextBox txtN;
        public System.Windows.Forms.TextBox txtBairro;
        public System.Windows.Forms.MaskedTextBox txtRg;
        public System.Windows.Forms.MaskedTextBox txtCpf;
        public System.Windows.Forms.ComboBox nivelacesso;
        public System.Windows.Forms.Button adicionar;
        public System.Windows.Forms.Button editar;
        private System.Windows.Forms.TextBox textBox1;
    }
}