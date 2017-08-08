namespace WindowsFormsApplication2
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtusuario = new System.Windows.Forms.TextBox();
            this.txtsenha = new System.Windows.Forms.TextBox();
            this.tileControl1 = new DevExpress.XtraEditors.TileControl();
            this.button4 = new System.Windows.Forms.Button();
            this.logar = new DevExpress.XtraEditors.SimpleButton();
            this.button1 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // txtusuario
            // 
            this.txtusuario.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtusuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtusuario.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtusuario.Location = new System.Drawing.Point(140, 141);
            this.txtusuario.Name = "txtusuario";
            this.txtusuario.Size = new System.Drawing.Size(250, 32);
            this.txtusuario.TabIndex = 0;
            this.txtusuario.TextChanged += new System.EventHandler(this.txtusuario_TextChanged);
            // 
            // txtsenha
            // 
            this.txtsenha.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtsenha.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtsenha.Location = new System.Drawing.Point(140, 250);
            this.txtsenha.Name = "txtsenha";
            this.txtsenha.PasswordChar = '*';
            this.txtsenha.Size = new System.Drawing.Size(250, 34);
            this.txtsenha.TabIndex = 1;
            this.txtsenha.TextChanged += new System.EventHandler(this.txtsenha_TextChanged);
            // 
            // tileControl1
            // 
            this.tileControl1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tileControl1.BackgroundImage")));
            this.tileControl1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tileControl1.DragSize = new System.Drawing.Size(0, 0);
            this.tileControl1.Location = new System.Drawing.Point(-1, 1);
            this.tileControl1.Name = "tileControl1";
            this.tileControl1.Size = new System.Drawing.Size(1366, 543);
            this.tileControl1.TabIndex = 10;
            this.tileControl1.Text = "tileControl1";
            this.tileControl1.Click += new System.EventHandler(this.tileControl1_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(1067, 54);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(235, 205);
            this.button4.TabIndex = 11;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // logar
            // 
            this.logar.Appearance.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.logar.Appearance.Options.UseFont = true;
            this.logar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.logar.Image = ((System.Drawing.Image)(resources.GetObject("logar.Image")));
            this.logar.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.logar.Location = new System.Drawing.Point(97, 386);
            this.logar.Name = "logar";
            this.logar.Size = new System.Drawing.Size(216, 85);
            this.logar.TabIndex = 12;
            this.logar.Text = "LOGAR";
            this.logar.Click += new System.EventHandler(this.logar_Click_1);
            // 
            // button1
            // 
            this.button1.Appearance.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.button1.Appearance.Options.UseFont = true;
            this.button1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(341, 386);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(216, 85);
            this.button1.TabIndex = 13;
            this.button1.Text = "SAIR";
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // simpleButton3
            // 
            this.simpleButton3.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton3.Image")));
            this.simpleButton3.Location = new System.Drawing.Point(44, 232);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(74, 74);
            this.simpleButton3.TabIndex = 15;
            // 
            // simpleButton4
            // 
            this.simpleButton4.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton4.Image")));
            this.simpleButton4.Location = new System.Drawing.Point(44, 125);
            this.simpleButton4.Name = "simpleButton4";
            this.simpleButton4.Size = new System.Drawing.Size(74, 74);
            this.simpleButton4.TabIndex = 16;
            // 
            // Form1
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1354, 525);
            this.Controls.Add(this.simpleButton4);
            this.Controls.Add(this.simpleButton3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.logar);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.txtsenha);
            this.Controls.Add(this.txtusuario);
            this.Controls.Add(this.tileControl1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LOGIN - NOAR ESTÚDIO";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.BackgroundImageChanged += new System.EventHandler(this.sair_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.TextBox txtusuario;
        private System.Windows.Forms.TextBox txtsenha;
        private DevExpress.XtraEditors.TileControl tileControl1;
        private System.Windows.Forms.Button button4;
        private DevExpress.XtraEditors.SimpleButton logar;
        private DevExpress.XtraEditors.SimpleButton button1;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.SimpleButton simpleButton4;
    }
}

