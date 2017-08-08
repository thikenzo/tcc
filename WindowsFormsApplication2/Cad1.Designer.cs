namespace WindowsFormsApplication2
{
    partial class Cad1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cad1));
            this.voltar = new DevExpress.XtraEditors.SimpleButton();
            this.editar = new DevExpress.XtraEditors.SimpleButton();
            this.adicionar = new DevExpress.XtraEditors.SimpleButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.nivelacesso = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.Login = new System.Windows.Forms.Label();
            this.txtCpf = new System.Windows.Forms.MaskedTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtRg = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtN = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCelular = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTelefone = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.NOME = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // voltar
            // 
            this.voltar.Appearance.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.voltar.Appearance.Options.UseFont = true;
            this.voltar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.voltar.Image = ((System.Drawing.Image)(resources.GetObject("voltar.Image")));
            this.voltar.Location = new System.Drawing.Point(767, 1111);
            this.voltar.Name = "voltar";
            this.voltar.Size = new System.Drawing.Size(206, 63);
            this.voltar.TabIndex = 70;
            this.voltar.Text = "MENU";
            this.voltar.Click += new System.EventHandler(this.voltar_Click_1);
            // 
            // editar
            // 
            this.editar.Appearance.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.editar.Appearance.Options.UseFont = true;
            this.editar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.editar.Enabled = false;
            this.editar.Image = ((System.Drawing.Image)(resources.GetObject("editar.Image")));
            this.editar.Location = new System.Drawing.Point(269, 1111);
            this.editar.Name = "editar";
            this.editar.Size = new System.Drawing.Size(206, 63);
            this.editar.TabIndex = 69;
            this.editar.Text = "EDITAR";
            this.editar.Click += new System.EventHandler(this.editar_Click);
            // 
            // adicionar
            // 
            this.adicionar.Appearance.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.adicionar.Appearance.Options.UseFont = true;
            this.adicionar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.adicionar.Image = ((System.Drawing.Image)(resources.GetObject("adicionar.Image")));
            this.adicionar.Location = new System.Drawing.Point(28, 1111);
            this.adicionar.Name = "adicionar";
            this.adicionar.Size = new System.Drawing.Size(206, 63);
            this.adicionar.TabIndex = 68;
            this.adicionar.Text = "INSERIR";
            this.adicionar.Click += new System.EventHandler(this.adicionar_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(1124, 66);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 33);
            this.textBox1.TabIndex = 67;
            // 
            // nivelacesso
            // 
            this.nivelacesso.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.nivelacesso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.nivelacesso.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nivelacesso.FormattingEnabled = true;
            this.nivelacesso.Location = new System.Drawing.Point(333, 322);
            this.nivelacesso.Margin = new System.Windows.Forms.Padding(6);
            this.nivelacesso.Name = "nivelacesso";
            this.nivelacesso.Size = new System.Drawing.Size(312, 34);
            this.nivelacesso.TabIndex = 66;
            this.nivelacesso.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.nivelacesso.Click += new System.EventHandler(this.voltar_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label11.Location = new System.Drawing.Point(59, 330);
            this.label11.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(209, 29);
            this.label11.TabIndex = 65;
            this.label11.Text = "NIVEL DE ACESSO :";
            // 
            // txtLogin
            // 
            this.txtLogin.Location = new System.Drawing.Point(1152, 94);
            this.txtLogin.Margin = new System.Windows.Forms.Padding(6);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.ReadOnly = true;
            this.txtLogin.Size = new System.Drawing.Size(72, 33);
            this.txtLogin.TabIndex = 64;
            this.txtLogin.Text = "NOAR";
            // 
            // Login
            // 
            this.Login.AutoSize = true;
            this.Login.Location = new System.Drawing.Point(1078, 102);
            this.Login.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(73, 25);
            this.Login.TabIndex = 63;
            this.Login.Text = "LOGIN";
            // 
            // txtCpf
            // 
            this.txtCpf.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtCpf.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCpf.Location = new System.Drawing.Point(558, 762);
            this.txtCpf.Margin = new System.Windows.Forms.Padding(6);
            this.txtCpf.Mask = "000.000.000.00";
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(208, 32);
            this.txtCpf.TabIndex = 62;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(473, 768);
            this.label10.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 26);
            this.label10.TabIndex = 61;
            this.label10.Text = "CPF :";
            // 
            // txtRg
            // 
            this.txtRg.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtRg.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRg.Location = new System.Drawing.Point(135, 762);
            this.txtRg.Margin = new System.Windows.Forms.Padding(6);
            this.txtRg.Mask = "00000000-0";
            this.txtRg.Name = "txtRg";
            this.txtRg.Size = new System.Drawing.Size(206, 32);
            this.txtRg.TabIndex = 60;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(51, 768);
            this.label9.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 26);
            this.label9.TabIndex = 59;
            this.label9.Text = "RG :";
            // 
            // txtBairro
            // 
            this.txtBairro.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtBairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBairro.Location = new System.Drawing.Point(197, 994);
            this.txtBairro.Margin = new System.Windows.Forms.Padding(6);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(278, 32);
            this.txtBairro.TabIndex = 58;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(41, 1000);
            this.label8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(117, 26);
            this.label8.TabIndex = 57;
            this.label8.Text = "BAIRRO :";
            // 
            // txtN
            // 
            this.txtN.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtN.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtN.Location = new System.Drawing.Point(825, 875);
            this.txtN.Margin = new System.Windows.Forms.Padding(6);
            this.txtN.Name = "txtN";
            this.txtN.Size = new System.Drawing.Size(114, 32);
            this.txtN.TabIndex = 56;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(746, 881);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 26);
            this.label7.TabIndex = 55;
            this.label7.Text = "Nº :";
            // 
            // txtEndereco
            // 
            this.txtEndereco.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtEndereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEndereco.Location = new System.Drawing.Point(213, 875);
            this.txtEndereco.Margin = new System.Windows.Forms.Padding(6);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(460, 32);
            this.txtEndereco.TabIndex = 54;
            this.txtEndereco.TextChanged += new System.EventHandler(this.txtEndereco_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(41, 883);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(160, 26);
            this.label6.TabIndex = 53;
            this.label6.Text = "ENDEREÇO :";
            // 
            // txtCelular
            // 
            this.txtCelular.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtCelular.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCelular.Location = new System.Drawing.Point(751, 530);
            this.txtCelular.Margin = new System.Windows.Forms.Padding(6);
            this.txtCelular.Mask = "(00)0000 0000";
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(206, 32);
            this.txtCelular.TabIndex = 52;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(592, 536);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 26);
            this.label5.TabIndex = 51;
            this.label5.Text = "CELULAR :";
            // 
            // txtTelefone
            // 
            this.txtTelefone.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefone.Location = new System.Drawing.Point(223, 533);
            this.txtTelefone.Margin = new System.Windows.Forms.Padding(6);
            this.txtTelefone.Mask = "(00)0000 0000";
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(206, 32);
            this.txtTelefone.TabIndex = 50;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arabic Typesetting", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label2.Location = new System.Drawing.Point(276, 137);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(451, 123);
            this.label2.TabIndex = 49;
            this.label2.Text = "CADASTRO";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(1152, 129);
            this.txtSenha.Margin = new System.Windows.Forms.Padding(6);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.ReadOnly = true;
            this.txtSenha.Size = new System.Drawing.Size(74, 33);
            this.txtSenha.TabIndex = 48;
            this.txtSenha.Text = "NOAR";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1076, 137);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 25);
            this.label1.TabIndex = 47;
            this.label1.Text = "SENHA";
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(171, 650);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(6);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(460, 32);
            this.txtEmail.TabIndex = 46;
            // 
            // txtNome
            // 
            this.txtNome.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(171, 439);
            this.txtNome.Margin = new System.Windows.Forms.Padding(6);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(460, 32);
            this.txtNome.TabIndex = 45;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(51, 656);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 26);
            this.label4.TabIndex = 44;
            this.label4.Text = "EMAIL :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(51, 539);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 26);
            this.label3.TabIndex = 43;
            this.label3.Text = "TELEFONE :";
            // 
            // NOME
            // 
            this.NOME.AutoSize = true;
            this.NOME.BackColor = System.Drawing.Color.Transparent;
            this.NOME.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NOME.Location = new System.Drawing.Point(57, 445);
            this.NOME.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.NOME.Name = "NOME";
            this.NOME.Size = new System.Drawing.Size(96, 26);
            this.NOME.TabIndex = 42;
            this.NOME.Text = "NOME :";
            // 
            // Cad1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Stretch;
            this.BackgroundImageStore = global::WindowsFormsApplication2.Properties.Resources.fundo4;
            this.ClientSize = new System.Drawing.Size(1254, 1241);
            this.Controls.Add(this.voltar);
            this.Controls.Add(this.editar);
            this.Controls.Add(this.adicionar);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.nivelacesso);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtLogin);
            this.Controls.Add(this.Login);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Cad1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cad1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton voltar;
        public DevExpress.XtraEditors.SimpleButton editar;
        public DevExpress.XtraEditors.SimpleButton adicionar;
        private System.Windows.Forms.TextBox textBox1;
        public System.Windows.Forms.ComboBox nivelacesso;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.Label Login;
        public System.Windows.Forms.MaskedTextBox txtCpf;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.MaskedTextBox txtRg;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.TextBox txtN;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.MaskedTextBox txtCelular;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.MaskedTextBox txtTelefone;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtEmail;
        public System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label NOME;
    }
}