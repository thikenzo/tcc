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
            this.tamanho = new System.Windows.Forms.ComboBox();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.btnVoltar = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arabic Typesetting", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(301, 79);
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
            this.label5.Size = new System.Drawing.Size(97, 29);
            this.label5.TabIndex = 17;
            this.label5.Text = "VALOR :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(900, 292);
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
            this.radioAtivo.Location = new System.Drawing.Point(974, 341);
            this.radioAtivo.Margin = new System.Windows.Forms.Padding(6);
            this.radioAtivo.Name = "radioAtivo";
            this.radioAtivo.Size = new System.Drawing.Size(111, 33);
            this.radioAtivo.TabIndex = 19;
            this.radioAtivo.TabStop = true;
            this.radioAtivo.Text = "ATIVO";
            this.radioAtivo.UseVisualStyleBackColor = false;
            this.radioAtivo.CheckedChanged += new System.EventHandler(this.radioAtivo_CheckedChanged);
            // 
            // radioInativo
            // 
            this.radioInativo.AutoSize = true;
            this.radioInativo.BackColor = System.Drawing.Color.Transparent;
            this.radioInativo.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold);
            this.radioInativo.Location = new System.Drawing.Point(1132, 341);
            this.radioInativo.Margin = new System.Windows.Forms.Padding(6);
            this.radioInativo.Name = "radioInativo";
            this.radioInativo.Size = new System.Drawing.Size(135, 33);
            this.radioInativo.TabIndex = 20;
            this.radioInativo.TabStop = true;
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
            // 
            // identificacaotxt
            // 
            this.identificacaotxt.Location = new System.Drawing.Point(322, 392);
            this.identificacaotxt.Margin = new System.Windows.Forms.Padding(6);
            this.identificacaotxt.Name = "identificacaotxt";
            this.identificacaotxt.Size = new System.Drawing.Size(420, 33);
            this.identificacaotxt.TabIndex = 22;
            // 
            // valortxt
            // 
            this.valortxt.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold);
            this.valortxt.Location = new System.Drawing.Point(244, 565);
            this.valortxt.Margin = new System.Windows.Forms.Padding(6);
            this.valortxt.Name = "valortxt";
            this.valortxt.Size = new System.Drawing.Size(240, 35);
            this.valortxt.TabIndex = 23;
            // 
            // tamanho
            // 
            this.tamanho.FormattingEnabled = true;
            this.tamanho.Location = new System.Drawing.Point(286, 480);
            this.tamanho.Margin = new System.Windows.Forms.Padding(6);
            this.tamanho.Name = "tamanho";
            this.tamanho.Size = new System.Drawing.Size(240, 33);
            this.tamanho.TabIndex = 24;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(700, 628);
            this.btnAdicionar.Margin = new System.Windows.Forms.Padding(6);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(150, 65);
            this.btnAdicionar.TabIndex = 25;
            this.btnAdicionar.Text = "ADICIONAR";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(884, 628);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(6);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(150, 65);
            this.btnEditar.TabIndex = 27;
            this.btnEditar.Text = "EDITAR";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.simpleButton1.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(672, 537);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(206, 63);
            this.simpleButton1.TabIndex = 29;
            this.simpleButton1.Text = "INSERIR";
            // 
            // simpleButton2
            // 
            this.simpleButton2.Appearance.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.simpleButton2.Appearance.Options.UseFont = true;
            this.simpleButton2.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.simpleButton2.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.Image")));
            this.simpleButton2.Location = new System.Drawing.Point(926, 537);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(206, 63);
            this.simpleButton2.TabIndex = 30;
            this.simpleButton2.Text = "EDITAR";
            // 
            // btnVoltar
            // 
            this.btnVoltar.Appearance.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.btnVoltar.Appearance.Options.UseFont = true;
            this.btnVoltar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btnVoltar.Image = ((System.Drawing.Image)(resources.GetObject("btnVoltar.Image")));
            this.btnVoltar.Location = new System.Drawing.Point(1106, 628);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(206, 63);
            this.btnVoltar.TabIndex = 31;
            this.btnVoltar.Text = "MENU";
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // SalaCad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Stretch;
            this.BackgroundImageStore = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImageStore")));
            this.ClientSize = new System.Drawing.Size(1610, 784);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.tamanho);
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
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Button btnEditar;
        public System.Windows.Forms.RadioButton radioAtivo;
        public System.Windows.Forms.RadioButton radioInativo;
        public System.Windows.Forms.TextBox salatxt;
        public System.Windows.Forms.TextBox identificacaotxt;
        public System.Windows.Forms.TextBox valortxt;
        public System.Windows.Forms.ComboBox tamanho;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton btnVoltar;
    }
}