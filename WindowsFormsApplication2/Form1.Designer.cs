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
            this.nivelacesso = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.logar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.tileControl1 = new DevExpress.XtraEditors.TileControl();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtusuario
            // 
            this.txtusuario.BackColor = System.Drawing.SystemColors.Menu;
            this.txtusuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtusuario.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtusuario.Location = new System.Drawing.Point(140, 169);
            this.txtusuario.Name = "txtusuario";
            this.txtusuario.Size = new System.Drawing.Size(250, 32);
            this.txtusuario.TabIndex = 0;
            // 
            // txtsenha
            // 
            this.txtsenha.BackColor = System.Drawing.SystemColors.Menu;
            this.txtsenha.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtsenha.Location = new System.Drawing.Point(140, 278);
            this.txtsenha.Name = "txtsenha";
            this.txtsenha.PasswordChar = '*';
            this.txtsenha.Size = new System.Drawing.Size(250, 34);
            this.txtsenha.TabIndex = 1;
            this.txtsenha.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtsenha_KeyDown);
            // 
            // nivelacesso
            // 
            this.nivelacesso.BackColor = System.Drawing.SystemColors.Menu;
            this.nivelacesso.Items.AddRange(new object[] {
            "ADMINISTRADOR",
            "USUÁRIO"});
            this.nivelacesso.Location = new System.Drawing.Point(230, 54);
            this.nivelacesso.Name = "nivelacesso";
            this.nivelacesso.Size = new System.Drawing.Size(250, 35);
            this.nivelacesso.TabIndex = 0;
            this.nivelacesso.SelectedIndexChanged += new System.EventHandler(this.nivelacesso_SelectedIndexChanged);
            this.nivelacesso.Enter += new System.EventHandler(this.nivelacesso_Enter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 27);
            this.label3.TabIndex = 6;
            this.label3.Text = "NÍVEL ACESSO : ";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // logar
            // 
            this.logar.BackColor = System.Drawing.Color.MidnightBlue;
            this.logar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.logar.Cursor = System.Windows.Forms.Cursors.Default;
            this.logar.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.logar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logar.ForeColor = System.Drawing.Color.White;
            this.logar.Image = ((System.Drawing.Image)(resources.GetObject("logar.Image")));
            this.logar.Location = new System.Drawing.Point(128, 400);
            this.logar.Name = "logar";
            this.logar.Size = new System.Drawing.Size(230, 94);
            this.logar.TabIndex = 7;
            this.logar.Text = "   LOGAR";
            this.logar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.logar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.logar.UseCompatibleTextRendering = true;
            this.logar.UseVisualStyleBackColor = false;
            this.logar.Click += new System.EventHandler(this.logar_Click_1);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MidnightBlue;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = global::WindowsFormsApplication2.Properties.Resources.Custom_Icon_Design_Pretty_Office_6_Logout;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(383, 400);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.button1.Size = new System.Drawing.Size(230, 94);
            this.button1.TabIndex = 7;
            this.button1.Text = "    SAIR";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseCompatibleTextRendering = true;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(30, 150);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(88, 81);
            this.button2.TabIndex = 8;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(30, 260);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(88, 81);
            this.button3.TabIndex = 9;
            this.button3.UseVisualStyleBackColor = true;
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
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(925, 219);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(235, 205);
            this.button4.TabIndex = 11;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1354, 525);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nivelacesso);
            this.Controls.Add(this.logar);
            this.Controls.Add(this.txtsenha);
            this.Controls.Add(this.txtusuario);
            this.Controls.Add(this.tileControl1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
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
        private System.Windows.Forms.ComboBox nivelacesso;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button logar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private DevExpress.XtraEditors.TileControl tileControl1;
        private System.Windows.Forms.Button button4;
    }
}

