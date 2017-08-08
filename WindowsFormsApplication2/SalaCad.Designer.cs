namespace WindowsFormsApplication2
{
    partial class SalaCad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SalaCad));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.radioAtivo = new System.Windows.Forms.RadioButton();
            this.radioInativo = new System.Windows.Forms.RadioButton();
            this.salatxt = new System.Windows.Forms.TextBox();
            this.identificacaotxt = new System.Windows.Forms.TextBox();
            this.valortxt = new System.Windows.Forms.TextBox();
            this.btnAdicionar = new DevExpress.XtraEditors.SimpleButton();
            this.btnEditar = new DevExpress.XtraEditors.SimpleButton();
            this.btnVoltar = new DevExpress.XtraEditors.SimpleButton();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tamanho1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arabic Typesetting", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(258, 79);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(809, 123);
            this.label1.TabIndex = 13;
            this.label1.Text = "CADASTRO DE SALAS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(122, 301);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 29);
            this.label2.TabIndex = 14;
            this.label2.Text = "NOME DA SALA :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(122, 396);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(190, 29);
            this.label3.TabIndex = 15;
            this.label3.Text = "IDENTIFICAÇÃO :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(122, 484);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 29);
            this.label4.TabIndex = 16;
            this.label4.Text = "TAMANHO :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(122, 573);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 29);
            this.label5.TabIndex = 17;
            this.label5.Text = "VALOR(R$) :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(902, 392);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 29);
            this.label6.TabIndex = 18;
            this.label6.Text = "SITUAÇÃO :";
            // 
            // radioAtivo
            // 
            this.radioAtivo.AutoSize = true;
            this.radioAtivo.BackColor = System.Drawing.Color.Transparent;
            this.radioAtivo.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold);
            this.radioAtivo.Location = new System.Drawing.Point(976, 441);
            this.radioAtivo.Margin = new System.Windows.Forms.Padding(6);
            this.radioAtivo.Name = "radioAtivo";
            this.radioAtivo.Size = new System.Drawing.Size(111, 33);
            this.radioAtivo.TabIndex = 19;
            this.radioAtivo.Text = "ATIVO";
            this.radioAtivo.UseVisualStyleBackColor = false;
            this.radioAtivo.CheckedChanged += new System.EventHandler(this.radioAtivo_CheckedChanged);
            // 
            // radioInativo
            // 
            this.radioInativo.AutoSize = true;
            this.radioInativo.BackColor = System.Drawing.Color.Transparent;
            this.radioInativo.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold);
            this.radioInativo.Location = new System.Drawing.Point(1134, 441);
            this.radioInativo.Margin = new System.Windows.Forms.Padding(6);
            this.radioInativo.Name = "radioInativo";
            this.radioInativo.Size = new System.Drawing.Size(135, 33);
            this.radioInativo.TabIndex = 20;
            this.radioInativo.Text = "INATIVO";
            this.radioInativo.UseVisualStyleBackColor = false;
            this.radioInativo.CheckedChanged += new System.EventHandler(this.radioInativo_CheckedChanged);
            // 
            // salatxt
            // 
            this.salatxt.Location = new System.Drawing.Point(322, 297);
            this.salatxt.Margin = new System.Windows.Forms.Padding(6);
            this.salatxt.Name = "salatxt";
            this.salatxt.Size = new System.Drawing.Size(420, 33);
            this.salatxt.TabIndex = 21;
            this.salatxt.TextChanged += new System.EventHandler(this.salatxt_TextChanged);
            // 
            // identificacaotxt
            // 
            this.identificacaotxt.Location = new System.Drawing.Point(322, 392);
            this.identificacaotxt.Margin = new System.Windows.Forms.Padding(6);
            this.identificacaotxt.Name = "identificacaotxt";
            this.identificacaotxt.Size = new System.Drawing.Size(420, 33);
            this.identificacaotxt.TabIndex = 22;
            this.identificacaotxt.TextChanged += new System.EventHandler(this.identificacaotxt_TextChanged);
            // 
            // valortxt
            // 
            this.valortxt.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold);
            this.valortxt.Location = new System.Drawing.Point(274, 567);
            this.valortxt.Margin = new System.Windows.Forms.Padding(6);
            this.valortxt.Name = "valortxt";
            this.valortxt.Size = new System.Drawing.Size(240, 35);
            this.valortxt.TabIndex = 23;
            this.valortxt.TextChanged += new System.EventHandler(this.valortxt_TextChanged);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Appearance.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.btnAdicionar.Appearance.Options.UseFont = true;
            this.btnAdicionar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btnAdicionar.Image = ((System.Drawing.Image)(resources.GetObject("btnAdicionar.Image")));
            this.btnAdicionar.Location = new System.Drawing.Point(602, 658);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(206, 63);
            this.btnAdicionar.TabIndex = 29;
            this.btnAdicionar.Text = "INSERIR";
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Appearance.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.btnEditar.Appearance.Options.UseFont = true;
            this.btnEditar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btnEditar.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.Image")));
            this.btnEditar.Location = new System.Drawing.Point(856, 658);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(206, 63);
            this.btnEditar.TabIndex = 30;
            this.btnEditar.Text = "EDITAR";
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Appearance.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.btnVoltar.Appearance.Options.UseFont = true;
            this.btnVoltar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btnVoltar.Image = ((System.Drawing.Image)(resources.GetObject("btnVoltar.Image")));
            this.btnVoltar.Location = new System.Drawing.Point(1112, 658);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(206, 63);
            this.btnVoltar.TabIndex = 31;
            this.btnVoltar.Text = "MENU";
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(955, 259);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(232, 25);
            this.label7.TabIndex = 32;
            this.label7.Text = "Campos Obrigatórios * ";
            this.label7.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Tahoma", 8F);
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(746, 287);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(24, 27);
            this.label8.TabIndex = 33;
            this.label8.Text = "*";
            this.label8.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Tahoma", 8F);
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(748, 380);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(24, 27);
            this.label9.TabIndex = 34;
            this.label9.Text = "*";
            this.label9.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Tahoma", 8F);
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(518, 470);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(24, 27);
            this.label10.TabIndex = 35;
            this.label10.Text = "*";
            this.label10.Visible = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Tahoma", 8F);
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(521, 550);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(24, 27);
            this.label11.TabIndex = 36;
            this.label11.Text = "*";
            this.label11.Visible = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Tahoma", 8F);
            this.label12.ForeColor = System.Drawing.Color.Red;
            this.label12.Location = new System.Drawing.Point(1038, 380);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(24, 27);
            this.label12.TabIndex = 37;
            this.label12.Text = "*";
            this.label12.Visible = false;
            // 
            // tamanho1
            // 
            this.tamanho1.Location = new System.Drawing.Point(271, 480);
            this.tamanho1.Name = "tamanho1";
            this.tamanho1.Size = new System.Drawing.Size(240, 33);
            this.tamanho1.TabIndex = 38;
            this.tamanho1.TextChanged += new System.EventHandler(this.tamanho_TextChanged);
            // 
            // SalaCad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Stretch;
            this.BackgroundImageStore = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImageStore")));
            this.ClientSize = new System.Drawing.Size(1610, 784);
            this.Controls.Add(this.tamanho1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.valortxt);
            this.Controls.Add(this.identificacaotxt);
            this.Controls.Add(this.salatxt);
            this.Controls.Add(this.radioInativo);
            this.Controls.Add(this.radioAtivo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SalaCad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NOAR ESTÚDIO - CADASTRAR SALAS";
            this.Load += new System.EventHandler(this.SalaCad_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.RadioButton radioAtivo;
        public System.Windows.Forms.RadioButton radioInativo;
        public System.Windows.Forms.TextBox salatxt;
        public System.Windows.Forms.TextBox identificacaotxt;
        public System.Windows.Forms.TextBox valortxt;
        public DevExpress.XtraEditors.SimpleButton btnAdicionar;
        public DevExpress.XtraEditors.SimpleButton btnEditar;
        private DevExpress.XtraEditors.SimpleButton btnVoltar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        public System.Windows.Forms.TextBox tamanho1;
    }
}