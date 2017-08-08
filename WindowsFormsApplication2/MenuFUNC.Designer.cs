namespace WindowsFormsApplication2
{
    partial class MenuFUNC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuFUNC));
            DevExpress.XtraEditors.TileItemElement tileItemElement51 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement52 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement53 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement54 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement55 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement56 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement57 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement58 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement59 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement60 = new DevExpress.XtraEditors.TileItemElement();
            this.tileControl1 = new DevExpress.XtraEditors.TileControl();
            this.tileGroup2 = new DevExpress.XtraEditors.TileGroup();
            this.agendamento1 = new DevExpress.XtraEditors.TileItem();
            this.tileGroup3 = new DevExpress.XtraEditors.TileGroup();
            this.consala1 = new DevExpress.XtraEditors.TileItem();
            this.conequip1 = new DevExpress.XtraEditors.TileItem();
            this.conpessoa1 = new DevExpress.XtraEditors.TileItem();
            this.tileGroup4 = new DevExpress.XtraEditors.TileGroup();
            this.cadpessoa1 = new DevExpress.XtraEditors.TileItem();
            this.relatorio1 = new DevExpress.XtraEditors.TileItem();
            this.label1 = new System.Windows.Forms.Label();
            this.sair1 = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // tileControl1
            // 
            this.tileControl1.AppearanceItem.Normal.Font = new System.Drawing.Font("Tahoma", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tileControl1.AppearanceItem.Normal.Options.UseFont = true;
            this.tileControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.tileControl1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tileControl1.BackgroundImage")));
            this.tileControl1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tileControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.tileControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tileControl1.DragSize = new System.Drawing.Size(0, 0);
            this.tileControl1.Groups.Add(this.tileGroup2);
            this.tileControl1.Groups.Add(this.tileGroup3);
            this.tileControl1.Groups.Add(this.tileGroup4);
            this.tileControl1.ItemSize = 240;
            this.tileControl1.Location = new System.Drawing.Point(0, 0);
            this.tileControl1.MaxId = 14;
            this.tileControl1.Name = "tileControl1";
            this.tileControl1.OptionsAdaptiveLayout.ItemMinSize = new System.Drawing.Size(200, 200);
            this.tileControl1.Padding = new System.Windows.Forms.Padding(18, 70, 18, 18);
            this.tileControl1.Size = new System.Drawing.Size(1772, 863);
            this.tileControl1.TabIndex = 1;
            this.tileControl1.Text = "tileControl1";
            this.tileControl1.Click += new System.EventHandler(this.tileControl1_Click);
            // 
            // tileGroup2
            // 
            this.tileGroup2.Items.Add(this.agendamento1);
            this.tileGroup2.Name = "tileGroup2";
            // 
            // agendamento1
            // 
            this.agendamento1.AppearanceItem.Normal.BackColor = System.Drawing.Color.MidnightBlue;
            this.agendamento1.AppearanceItem.Normal.Options.UseBackColor = true;
            tileItemElement51.Image = ((System.Drawing.Image)(resources.GetObject("tileItemElement51.Image")));
            tileItemElement51.ImageLocation = new System.Drawing.Point(153, 35);
            tileItemElement51.Text = "Agendamento";
            this.agendamento1.Elements.Add(tileItemElement51);
            this.agendamento1.Id = 1;
            this.agendamento1.ItemSize = DevExpress.XtraEditors.TileItemSize.Wide;
            this.agendamento1.Name = "agendamento1";
            this.agendamento1.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.agendamento1_ItemClick);
            // 
            // tileGroup3
            // 
            this.tileGroup3.Items.Add(this.consala1);
            this.tileGroup3.Items.Add(this.conequip1);
            this.tileGroup3.Items.Add(this.conpessoa1);
            this.tileGroup3.Name = "tileGroup3";
            // 
            // consala1
            // 
            this.consala1.AppearanceItem.Normal.BackColor = System.Drawing.Color.MidnightBlue;
            this.consala1.AppearanceItem.Normal.Options.UseBackColor = true;
            tileItemElement52.Image = ((System.Drawing.Image)(resources.GetObject("tileItemElement52.Image")));
            tileItemElement52.ImageLocation = new System.Drawing.Point(40, -25);
            tileItemElement52.Text = "Consultar";
            tileItemElement52.TextLocation = new System.Drawing.Point(45, 0);
            tileItemElement53.Text = "Sala";
            tileItemElement53.TextLocation = new System.Drawing.Point(-62, 180);
            this.consala1.Elements.Add(tileItemElement52);
            this.consala1.Elements.Add(tileItemElement53);
            this.consala1.Id = 4;
            this.consala1.ItemSize = DevExpress.XtraEditors.TileItemSize.Medium;
            this.consala1.Name = "consala1";
            this.consala1.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.consala1_ItemClick);
            // 
            // conequip1
            // 
            this.conequip1.AppearanceItem.Normal.BackColor = System.Drawing.Color.MidnightBlue;
            this.conequip1.AppearanceItem.Normal.Options.UseBackColor = true;
            tileItemElement54.Image = ((System.Drawing.Image)(resources.GetObject("tileItemElement54.Image")));
            tileItemElement54.ImageLocation = new System.Drawing.Point(40, -25);
            tileItemElement54.Text = "Consultar ";
            tileItemElement54.TextLocation = new System.Drawing.Point(50, 0);
            tileItemElement55.Text = "Equipamento";
            tileItemElement55.TextLocation = new System.Drawing.Point(-8, 180);
            this.conequip1.Elements.Add(tileItemElement54);
            this.conequip1.Elements.Add(tileItemElement55);
            this.conequip1.Id = 9;
            this.conequip1.ItemSize = DevExpress.XtraEditors.TileItemSize.Medium;
            this.conequip1.Name = "conequip1";
            this.conequip1.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.conequip1_ItemClick);
            // 
            // conpessoa1
            // 
            this.conpessoa1.AppearanceItem.Normal.BackColor = System.Drawing.Color.MidnightBlue;
            this.conpessoa1.AppearanceItem.Normal.Options.UseBackColor = true;
            tileItemElement56.Image = ((System.Drawing.Image)(resources.GetObject("tileItemElement56.Image")));
            tileItemElement56.ImageLocation = new System.Drawing.Point(45, -25);
            tileItemElement56.Text = "Consultar";
            tileItemElement56.TextLocation = new System.Drawing.Point(50, 0);
            tileItemElement57.Text = "Nome";
            tileItemElement57.TextLocation = new System.Drawing.Point(-50, 180);
            this.conpessoa1.Elements.Add(tileItemElement56);
            this.conpessoa1.Elements.Add(tileItemElement57);
            this.conpessoa1.Id = 3;
            this.conpessoa1.ItemSize = DevExpress.XtraEditors.TileItemSize.Medium;
            this.conpessoa1.Name = "conpessoa1";
            this.conpessoa1.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.conpessoa1_ItemClick);
            // 
            // tileGroup4
            // 
            this.tileGroup4.Items.Add(this.cadpessoa1);
            this.tileGroup4.Items.Add(this.relatorio1);
            this.tileGroup4.Name = "tileGroup4";
            // 
            // cadpessoa1
            // 
            this.cadpessoa1.AppearanceItem.Normal.BackColor = System.Drawing.Color.MidnightBlue;
            this.cadpessoa1.AppearanceItem.Normal.Options.UseBackColor = true;
            tileItemElement58.Image = ((System.Drawing.Image)(resources.GetObject("tileItemElement58.Image")));
            tileItemElement58.ImageLocation = new System.Drawing.Point(45, -25);
            tileItemElement58.Text = "Cadastrar";
            tileItemElement58.TextLocation = new System.Drawing.Point(50, 0);
            tileItemElement59.Text = "Nome";
            tileItemElement59.TextLocation = new System.Drawing.Point(-50, 180);
            this.cadpessoa1.Elements.Add(tileItemElement58);
            this.cadpessoa1.Elements.Add(tileItemElement59);
            this.cadpessoa1.Id = 2;
            this.cadpessoa1.ItemSize = DevExpress.XtraEditors.TileItemSize.Medium;
            this.cadpessoa1.Name = "cadpessoa1";
            this.cadpessoa1.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.cadpessoa1_ItemClick);
            // 
            // relatorio1
            // 
            this.relatorio1.AppearanceItem.Hovered.BackColor = System.Drawing.Color.White;
            this.relatorio1.AppearanceItem.Hovered.Font = new System.Drawing.Font("Tahoma", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.relatorio1.AppearanceItem.Hovered.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.relatorio1.AppearanceItem.Hovered.Options.UseBackColor = true;
            this.relatorio1.AppearanceItem.Hovered.Options.UseFont = true;
            this.relatorio1.AppearanceItem.Hovered.Options.UseForeColor = true;
            this.relatorio1.AppearanceItem.Normal.BackColor = System.Drawing.Color.MidnightBlue;
            this.relatorio1.AppearanceItem.Normal.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.relatorio1.AppearanceItem.Normal.Options.UseBackColor = true;
            this.relatorio1.AppearanceItem.Normal.Options.UseFont = true;
            tileItemElement60.Height = -1;
            tileItemElement60.Image = ((System.Drawing.Image)(resources.GetObject("tileItemElement60.Image")));
            tileItemElement60.ImageLocation = new System.Drawing.Point(140, 30);
            tileItemElement60.Text = "Relatório";
            this.relatorio1.Elements.Add(tileItemElement60);
            this.relatorio1.Id = 5;
            this.relatorio1.ItemSize = DevExpress.XtraEditors.TileItemSize.Wide;
            this.relatorio1.Name = "relatorio1";
            this.relatorio1.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.relatorio1_ItemClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arabic Typesetting", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(733, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(273, 123);
            this.label1.TabIndex = 3;
            this.label1.Text = "MENU";
            // 
            // sair1
            // 
            this.sair1.Appearance.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.sair1.Appearance.Options.UseFont = true;
            this.sair1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.sair1.Image = ((System.Drawing.Image)(resources.GetObject("sair1.Image")));
            this.sair1.Location = new System.Drawing.Point(1485, 759);
            this.sair1.Name = "sair1";
            this.sair1.Size = new System.Drawing.Size(206, 63);
            this.sair1.TabIndex = 4;
            this.sair1.Text = "SAIR";
            this.sair1.Click += new System.EventHandler(this.sair1_Click);
            // 
            // MenuFUNC
            // 
            this.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Stretch;
            this.BackgroundImageStore = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImageStore")));
            this.ClientSize = new System.Drawing.Size(1772, 863);
            this.Controls.Add(this.sair1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tileControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MenuFUNC";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NOAR ESTÚDIO - MENU";
            this.Load += new System.EventHandler(this.MenuFUNC_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TileControl tileControl1;
        private DevExpress.XtraEditors.TileGroup tileGroup2;
        private DevExpress.XtraEditors.TileItem agendamento1;
        private DevExpress.XtraEditors.TileItem relatorio1;
        private DevExpress.XtraEditors.TileGroup tileGroup3;
        private DevExpress.XtraEditors.TileItem consala1;
        private DevExpress.XtraEditors.TileItem conequip1;
        private DevExpress.XtraEditors.TileGroup tileGroup4;
        private DevExpress.XtraEditors.TileItem cadpessoa1;
        private DevExpress.XtraEditors.TileItem conpessoa1;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton sair1;
    }
}