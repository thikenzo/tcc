namespace WindowsFormsApplication2
{
    partial class InstruCad
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.txtNomeEquip = new System.Windows.Forms.TextBox();
            this.radionacional = new System.Windows.Forms.RadioButton();
            this.radiointernacional = new System.Windows.Forms.RadioButton();
            this.combotipo = new System.Windows.Forms.ComboBox();
            this.txtValor = new System.Windows.Forms.MaskedTextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 215);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome Instrumento :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(112, 304);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Classificação :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(194, 390);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tipo :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(188, 504);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Valor :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(162, 56);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(904, 67);
            this.label6.TabIndex = 5;
            this.label6.Text = "CADASTRO DE INSTRUMENTO";
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(474, 637);
            this.btnAdicionar.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(150, 44);
            this.btnAdicionar.TabIndex = 6;
            this.btnAdicionar.Text = "ADICIONAR";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(666, 637);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(150, 44);
            this.btnEditar.TabIndex = 7;
            this.btnEditar.Text = "EDITAR";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(852, 637);
            this.btnExcluir.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(150, 44);
            this.btnExcluir.TabIndex = 8;
            this.btnExcluir.Text = "REMOVER";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(1036, 637);
            this.btnVoltar.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(150, 44);
            this.btnVoltar.TabIndex = 9;
            this.btnVoltar.Text = "VOLTAR";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // txtNomeEquip
            // 
            this.txtNomeEquip.Location = new System.Drawing.Point(298, 200);
            this.txtNomeEquip.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtNomeEquip.Name = "txtNomeEquip";
            this.txtNomeEquip.Size = new System.Drawing.Size(514, 31);
            this.txtNomeEquip.TabIndex = 10;
            // 
            // radionacional
            // 
            this.radionacional.AutoSize = true;
            this.radionacional.Location = new System.Drawing.Point(298, 300);
            this.radionacional.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.radionacional.Name = "radionacional";
            this.radionacional.Size = new System.Drawing.Size(127, 29);
            this.radionacional.TabIndex = 11;
            this.radionacional.TabStop = true;
            this.radionacional.Text = "Nacional";
            this.radionacional.UseVisualStyleBackColor = true;
            this.radionacional.CheckedChanged += new System.EventHandler(this.radionacional_CheckedChanged);
            // 
            // radiointernacional
            // 
            this.radiointernacional.AutoSize = true;
            this.radiointernacional.Location = new System.Drawing.Point(494, 300);
            this.radiointernacional.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.radiointernacional.Name = "radiointernacional";
            this.radiointernacional.Size = new System.Drawing.Size(166, 29);
            this.radiointernacional.TabIndex = 12;
            this.radiointernacional.TabStop = true;
            this.radiointernacional.Text = "Internacional";
            this.radiointernacional.UseVisualStyleBackColor = true;
            this.radiointernacional.CheckedChanged += new System.EventHandler(this.radiointernacional_CheckedChanged);
            // 
            // combotipo
            // 
            this.combotipo.FormattingEnabled = true;
            this.combotipo.Location = new System.Drawing.Point(298, 375);
            this.combotipo.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.combotipo.Name = "combotipo";
            this.combotipo.Size = new System.Drawing.Size(236, 33);
            this.combotipo.TabIndex = 13;
            this.combotipo.SelectedIndexChanged += new System.EventHandler(this.combotipo_SelectedIndexChanged);
            this.combotipo.Enter += new System.EventHandler(this.combotipo_Enter);
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(298, 488);
            this.txtValor.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(196, 31);
            this.txtValor.TabIndex = 14;
            // 
            // button3
            // 
            this.button3.Image = global::WindowsFormsApplication2.Properties.Resources.Bot_o_Editar_;
            this.button3.Location = new System.Drawing.Point(914, 390);
            this.button3.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(252, 77);
            this.button3.TabIndex = 17;
            this.button3.Text = "PNG";
            this.button3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Image = global::WindowsFormsApplication2.Properties.Resources.Botão_Remover;
            this.button2.Location = new System.Drawing.Point(914, 479);
            this.button2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(272, 77);
            this.button2.TabIndex = 16;
            this.button2.Text = "PNG";
            this.button2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(700, 446);
            this.button1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 44);
            this.button1.TabIndex = 18;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // InstruCad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1238, 721);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.combotipo);
            this.Controls.Add(this.radiointernacional);
            this.Controls.Add(this.radionacional);
            this.Controls.Add(this.txtNomeEquip);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InstruCad";
            this.Text = "NOAR ESTÚDIO";
            this.Load += new System.EventHandler(this.InstruCad_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnVoltar;
        public System.Windows.Forms.TextBox txtNomeEquip;
        public System.Windows.Forms.RadioButton radionacional;
        public System.Windows.Forms.RadioButton radiointernacional;
        public System.Windows.Forms.ComboBox combotipo;
        public System.Windows.Forms.MaskedTextBox txtValor;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
    }
}