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
            this.btnVoltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(350, 73);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(660, 67);
            this.label1.TabIndex = 13;
            this.label1.Text = "CADASTRO DE SALAS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 233);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 25);
            this.label2.TabIndex = 14;
            this.label2.Text = "NOME DA SALA :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 315);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(183, 25);
            this.label3.TabIndex = 15;
            this.label3.Text = "IDENTIFICAÇÃO :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 392);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 25);
            this.label4.TabIndex = 16;
            this.label4.Text = "TAMANHO :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(130, 469);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 25);
            this.label5.TabIndex = 17;
            this.label5.Text = "VALOR :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(930, 254);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 25);
            this.label6.TabIndex = 18;
            this.label6.Text = "SITUAÇÃO :";
            // 
            // radioAtivo
            // 
            this.radioAtivo.AutoSize = true;
            this.radioAtivo.Location = new System.Drawing.Point(946, 329);
            this.radioAtivo.Margin = new System.Windows.Forms.Padding(6);
            this.radioAtivo.Name = "radioAtivo";
            this.radioAtivo.Size = new System.Drawing.Size(105, 29);
            this.radioAtivo.TabIndex = 19;
            this.radioAtivo.TabStop = true;
            this.radioAtivo.Text = "ATIVO";
            this.radioAtivo.UseVisualStyleBackColor = true;
            this.radioAtivo.CheckedChanged += new System.EventHandler(this.radioAtivo_CheckedChanged);
            // 
            // radioInativo
            // 
            this.radioInativo.AutoSize = true;
            this.radioInativo.Location = new System.Drawing.Point(1104, 329);
            this.radioInativo.Margin = new System.Windows.Forms.Padding(6);
            this.radioInativo.Name = "radioInativo";
            this.radioInativo.Size = new System.Drawing.Size(125, 29);
            this.radioInativo.TabIndex = 20;
            this.radioInativo.TabStop = true;
            this.radioInativo.Text = "INATIVO";
            this.radioInativo.UseVisualStyleBackColor = true;
            this.radioInativo.CheckedChanged += new System.EventHandler(this.radioInativo_CheckedChanged);
            // 
            // salatxt
            // 
            this.salatxt.Location = new System.Drawing.Point(242, 217);
            this.salatxt.Margin = new System.Windows.Forms.Padding(6);
            this.salatxt.Name = "salatxt";
            this.salatxt.Size = new System.Drawing.Size(420, 31);
            this.salatxt.TabIndex = 21;
            // 
            // identificacaotxt
            // 
            this.identificacaotxt.Location = new System.Drawing.Point(242, 302);
            this.identificacaotxt.Margin = new System.Windows.Forms.Padding(6);
            this.identificacaotxt.Name = "identificacaotxt";
            this.identificacaotxt.Size = new System.Drawing.Size(420, 31);
            this.identificacaotxt.TabIndex = 22;
            // 
            // valortxt
            // 
            this.valortxt.Location = new System.Drawing.Point(242, 456);
            this.valortxt.Margin = new System.Windows.Forms.Padding(6);
            this.valortxt.Name = "valortxt";
            this.valortxt.Size = new System.Drawing.Size(240, 31);
            this.valortxt.TabIndex = 23;
            // 
            // tamanho
            // 
            this.tamanho.FormattingEnabled = true;
            this.tamanho.Location = new System.Drawing.Point(242, 375);
            this.tamanho.Margin = new System.Windows.Forms.Padding(6);
            this.tamanho.Name = "tamanho";
            this.tamanho.Size = new System.Drawing.Size(240, 33);
            this.tamanho.TabIndex = 24;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(690, 548);
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
            this.btnEditar.Location = new System.Drawing.Point(874, 548);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(6);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(150, 65);
            this.btnEditar.TabIndex = 27;
            this.btnEditar.Text = "EDITAR";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(1240, 548);
            this.btnVoltar.Margin = new System.Windows.Forms.Padding(6);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(150, 65);
            this.btnVoltar.TabIndex = 28;
            this.btnVoltar.Text = "MENU";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // SalaCad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1418, 642);
            this.Controls.Add(this.btnVoltar);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SalaCad";
            this.Text = "SalaCad";
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
        private System.Windows.Forms.Button btnVoltar;
        public System.Windows.Forms.RadioButton radioAtivo;
        public System.Windows.Forms.RadioButton radioInativo;
        public System.Windows.Forms.TextBox salatxt;
        public System.Windows.Forms.TextBox identificacaotxt;
        public System.Windows.Forms.TextBox valortxt;
        public System.Windows.Forms.ComboBox tamanho;
    }
}