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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InstruCad));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNomeEquip = new System.Windows.Forms.TextBox();
            this.radionacional = new System.Windows.Forms.RadioButton();
            this.radiointernacional = new System.Windows.Forms.RadioButton();
            this.combotipo = new System.Windows.Forms.ComboBox();
            this.txtValor = new System.Windows.Forms.MaskedTextBox();
            this.btnAdicionar = new DevExpress.XtraEditors.SimpleButton();
            this.btnEditar = new DevExpress.XtraEditors.SimpleButton();
            this.btnVoltar = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(118, 268);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome Instrumento :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(120, 363);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Classificação :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(655, 469);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tipo :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(122, 473);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 29);
            this.label4.TabIndex = 3;
            this.label4.Text = "Valor :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Arabic Typesetting", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(125, 71);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(1134, 123);
            this.label6.TabIndex = 5;
            this.label6.Text = "CADASTRO DE INSTRUMENTO";
            // 
            // txtNomeEquip
            // 
            this.txtNomeEquip.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtNomeEquip.Location = new System.Drawing.Point(328, 262);
            this.txtNomeEquip.Margin = new System.Windows.Forms.Padding(6);
            this.txtNomeEquip.Name = "txtNomeEquip";
            this.txtNomeEquip.Size = new System.Drawing.Size(514, 33);
            this.txtNomeEquip.TabIndex = 10;
            // 
            // radionacional
            // 
            this.radionacional.AutoSize = true;
            this.radionacional.BackColor = System.Drawing.Color.Transparent;
            this.radionacional.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radionacional.Location = new System.Drawing.Point(350, 359);
            this.radionacional.Margin = new System.Windows.Forms.Padding(6);
            this.radionacional.Name = "radionacional";
            this.radionacional.Size = new System.Drawing.Size(134, 33);
            this.radionacional.TabIndex = 11;
            this.radionacional.TabStop = true;
            this.radionacional.Text = "Nacional";
            this.radionacional.UseVisualStyleBackColor = false;
            this.radionacional.CheckedChanged += new System.EventHandler(this.radionacional_CheckedChanged);
            // 
            // radiointernacional
            // 
            this.radiointernacional.AutoSize = true;
            this.radiointernacional.BackColor = System.Drawing.Color.Transparent;
            this.radiointernacional.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radiointernacional.Location = new System.Drawing.Point(546, 359);
            this.radiointernacional.Margin = new System.Windows.Forms.Padding(6);
            this.radiointernacional.Name = "radiointernacional";
            this.radiointernacional.Size = new System.Drawing.Size(180, 33);
            this.radiointernacional.TabIndex = 12;
            this.radiointernacional.TabStop = true;
            this.radiointernacional.Text = "Internacional";
            this.radiointernacional.UseVisualStyleBackColor = false;
            this.radiointernacional.CheckedChanged += new System.EventHandler(this.radiointernacional_CheckedChanged);
            // 
            // combotipo
            // 
            this.combotipo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.combotipo.FormattingEnabled = true;
            this.combotipo.Location = new System.Drawing.Point(750, 465);
            this.combotipo.Margin = new System.Windows.Forms.Padding(6);
            this.combotipo.Name = "combotipo";
            this.combotipo.Size = new System.Drawing.Size(236, 33);
            this.combotipo.TabIndex = 13;
            this.combotipo.SelectedIndexChanged += new System.EventHandler(this.combotipo_SelectedIndexChanged);
            this.combotipo.Enter += new System.EventHandler(this.combotipo_Enter);
            // 
            // txtValor
            // 
            this.txtValor.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtValor.Location = new System.Drawing.Point(226, 469);
            this.txtValor.Margin = new System.Windows.Forms.Padding(6);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(196, 33);
            this.txtValor.TabIndex = 14;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Appearance.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.btnAdicionar.Appearance.Options.UseFont = true;
            this.btnAdicionar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btnAdicionar.Image = ((System.Drawing.Image)(resources.GetObject("btnAdicionar.Image")));
            this.btnAdicionar.Location = new System.Drawing.Point(81, 598);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(206, 63);
            this.btnAdicionar.TabIndex = 15;
            this.btnAdicionar.Text = "INSERIR";
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Appearance.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.btnEditar.Appearance.Options.UseFont = true;
            this.btnEditar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btnEditar.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.Image")));
            this.btnEditar.Location = new System.Drawing.Point(312, 598);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(206, 63);
            this.btnEditar.TabIndex = 16;
            this.btnEditar.Text = "EDITAR";
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Appearance.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.btnVoltar.Appearance.Options.UseFont = true;
            this.btnVoltar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btnVoltar.Image = ((System.Drawing.Image)(resources.GetObject("btnVoltar.Image")));
            this.btnVoltar.Location = new System.Drawing.Point(1066, 598);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(206, 63);
            this.btnVoltar.TabIndex = 17;
            this.btnVoltar.Text = "MENU";
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // InstruCad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Stretch;
            this.BackgroundImageStore = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImageStore")));
            this.ClientSize = new System.Drawing.Size(1406, 809);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.combotipo);
            this.Controls.Add(this.radiointernacional);
            this.Controls.Add(this.radionacional);
            this.Controls.Add(this.txtNomeEquip);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InstruCad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NOAR ESTÚDIO - CADASTRAR EQUIPAMENTOS";
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
        public System.Windows.Forms.TextBox txtNomeEquip;
        public System.Windows.Forms.RadioButton radionacional;
        public System.Windows.Forms.RadioButton radiointernacional;
        public System.Windows.Forms.ComboBox combotipo;
        public System.Windows.Forms.MaskedTextBox txtValor;
        public DevExpress.XtraEditors.SimpleButton btnAdicionar;
        public DevExpress.XtraEditors.SimpleButton btnEditar;
        private DevExpress.XtraEditors.SimpleButton btnVoltar;
    }
}