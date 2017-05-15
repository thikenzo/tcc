namespace WindowsFormsApplication2
{
    partial class MenuADM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuADM));
            DevExpress.XtraEditors.TileItemElement tileItemElement15 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement16 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement17 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement18 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement19 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement20 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement21 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement22 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement23 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement24 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement25 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement26 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement27 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement28 = new DevExpress.XtraEditors.TileItemElement();
            this.tileControl1 = new DevExpress.XtraEditors.TileControl();
            this.tileGroup2 = new DevExpress.XtraEditors.TileGroup();
            this.agendamento = new DevExpress.XtraEditors.TileItem();
            this.tileGroup3 = new DevExpress.XtraEditors.TileGroup();
            this.consala = new DevExpress.XtraEditors.TileItem();
            this.Cadsala = new DevExpress.XtraEditors.TileItem();
            this.conequip = new DevExpress.XtraEditors.TileItem();
            this.cadequip = new DevExpress.XtraEditors.TileItem();
            this.tileGroup4 = new DevExpress.XtraEditors.TileGroup();
            this.relatorio = new DevExpress.XtraEditors.TileItem();
            this.cadpessoa = new DevExpress.XtraEditors.TileItem();
            this.conpessoa = new DevExpress.XtraEditors.TileItem();
            this.label1 = new System.Windows.Forms.Label();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
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
            this.tileControl1.MaxId = 13;
            this.tileControl1.Name = "tileControl1";
            this.tileControl1.OptionsAdaptiveLayout.ItemMinSize = new System.Drawing.Size(200, 200);
            this.tileControl1.Padding = new System.Windows.Forms.Padding(18, 70, 18, 18);
            this.tileControl1.Size = new System.Drawing.Size(1736, 857);
            this.tileControl1.TabIndex = 0;
            this.tileControl1.Text = "tileControl1";
            this.tileControl1.Click += new System.EventHandler(this.tileControl1_Click);
            // 
            // tileGroup2
            // 
            this.tileGroup2.Items.Add(this.agendamento);
            this.tileGroup2.Name = "tileGroup2";
            // 
            // agendamento
            // 
            this.agendamento.AppearanceItem.Normal.BackColor = System.Drawing.Color.MidnightBlue;
            this.agendamento.AppearanceItem.Normal.Options.UseBackColor = true;
            tileItemElement15.Image = ((System.Drawing.Image)(resources.GetObject("tileItemElement15.Image")));
            tileItemElement15.ImageLocation = new System.Drawing.Point(153, 35);
            tileItemElement15.Text = "Agendamento";
            this.agendamento.Elements.Add(tileItemElement15);
            this.agendamento.Id = 1;
            this.agendamento.ItemSize = DevExpress.XtraEditors.TileItemSize.Wide;
            this.agendamento.Name = "agendamento";
            this.agendamento.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.agendamento_ItemClick);
            // 
            // tileGroup3
            // 
            this.tileGroup3.Items.Add(this.consala);
            this.tileGroup3.Items.Add(this.Cadsala);
            this.tileGroup3.Items.Add(this.conequip);
            this.tileGroup3.Items.Add(this.cadequip);
            this.tileGroup3.Name = "tileGroup3";
            // 
            // consala
            // 
            this.consala.AppearanceItem.Normal.BackColor = System.Drawing.Color.MidnightBlue;
            this.consala.AppearanceItem.Normal.Options.UseBackColor = true;
            tileItemElement16.Image = ((System.Drawing.Image)(resources.GetObject("tileItemElement16.Image")));
            tileItemElement16.ImageLocation = new System.Drawing.Point(40, -25);
            tileItemElement16.Text = "Consultar";
            tileItemElement16.TextLocation = new System.Drawing.Point(45, 0);
            tileItemElement17.Text = "Sala";
            tileItemElement17.TextLocation = new System.Drawing.Point(-62, 180);
            this.consala.Elements.Add(tileItemElement16);
            this.consala.Elements.Add(tileItemElement17);
            this.consala.Id = 4;
            this.consala.ItemSize = DevExpress.XtraEditors.TileItemSize.Medium;
            this.consala.Name = "consala";
            this.consala.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.consala_ItemClick);
            // 
            // Cadsala
            // 
            this.Cadsala.AppearanceItem.Normal.BackColor = System.Drawing.Color.MidnightBlue;
            this.Cadsala.AppearanceItem.Normal.Options.UseBackColor = true;
            tileItemElement18.Image = ((System.Drawing.Image)(resources.GetObject("tileItemElement18.Image")));
            tileItemElement18.ImageLocation = new System.Drawing.Point(45, -25);
            tileItemElement18.Text = "Cadastrar ";
            tileItemElement18.TextLocation = new System.Drawing.Point(45, 0);
            tileItemElement19.Text = "Sala";
            tileItemElement19.TextLocation = new System.Drawing.Point(-62, 180);
            this.Cadsala.Elements.Add(tileItemElement18);
            this.Cadsala.Elements.Add(tileItemElement19);
            this.Cadsala.Id = 7;
            this.Cadsala.ItemSize = DevExpress.XtraEditors.TileItemSize.Medium;
            this.Cadsala.Name = "Cadsala";
            this.Cadsala.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.Cadsala_ItemClick);
            // 
            // conequip
            // 
            this.conequip.AppearanceItem.Normal.BackColor = System.Drawing.Color.MidnightBlue;
            this.conequip.AppearanceItem.Normal.Options.UseBackColor = true;
            tileItemElement20.Image = ((System.Drawing.Image)(resources.GetObject("tileItemElement20.Image")));
            tileItemElement20.ImageLocation = new System.Drawing.Point(40, -25);
            tileItemElement20.Text = "Consultar ";
            tileItemElement20.TextLocation = new System.Drawing.Point(50, 0);
            tileItemElement21.Text = "Equipamento";
            tileItemElement21.TextLocation = new System.Drawing.Point(-8, 180);
            this.conequip.Elements.Add(tileItemElement20);
            this.conequip.Elements.Add(tileItemElement21);
            this.conequip.Id = 9;
            this.conequip.ItemSize = DevExpress.XtraEditors.TileItemSize.Medium;
            this.conequip.Name = "conequip";
            this.conequip.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.conequip_ItemClick);
            // 
            // cadequip
            // 
            this.cadequip.AppearanceItem.Normal.BackColor = System.Drawing.Color.MidnightBlue;
            this.cadequip.AppearanceItem.Normal.Options.UseBackColor = true;
            tileItemElement22.Image = ((System.Drawing.Image)(resources.GetObject("tileItemElement22.Image")));
            tileItemElement22.ImageLocation = new System.Drawing.Point(45, -25);
            tileItemElement22.Text = "Cadastrar";
            tileItemElement22.TextLocation = new System.Drawing.Point(50, 0);
            tileItemElement23.Text = "Equipamento";
            tileItemElement23.TextLocation = new System.Drawing.Point(-8, 180);
            this.cadequip.Elements.Add(tileItemElement22);
            this.cadequip.Elements.Add(tileItemElement23);
            this.cadequip.Id = 6;
            this.cadequip.ItemSize = DevExpress.XtraEditors.TileItemSize.Medium;
            this.cadequip.Name = "cadequip";
            this.cadequip.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.cadequip_ItemClick);
            // 
            // tileGroup4
            // 
            this.tileGroup4.Items.Add(this.relatorio);
            this.tileGroup4.Items.Add(this.cadpessoa);
            this.tileGroup4.Items.Add(this.conpessoa);
            this.tileGroup4.Name = "tileGroup4";
            // 
            // relatorio
            // 
            this.relatorio.AppearanceItem.Hovered.BackColor = System.Drawing.Color.White;
            this.relatorio.AppearanceItem.Hovered.Font = new System.Drawing.Font("Tahoma", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.relatorio.AppearanceItem.Hovered.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.relatorio.AppearanceItem.Hovered.Options.UseBackColor = true;
            this.relatorio.AppearanceItem.Hovered.Options.UseFont = true;
            this.relatorio.AppearanceItem.Hovered.Options.UseForeColor = true;
            this.relatorio.AppearanceItem.Normal.BackColor = System.Drawing.Color.MidnightBlue;
            this.relatorio.AppearanceItem.Normal.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.relatorio.AppearanceItem.Normal.Options.UseBackColor = true;
            this.relatorio.AppearanceItem.Normal.Options.UseFont = true;
            tileItemElement24.Height = -1;
            tileItemElement24.Image = ((System.Drawing.Image)(resources.GetObject("tileItemElement24.Image")));
            tileItemElement24.ImageLocation = new System.Drawing.Point(140, 30);
            tileItemElement24.Text = "Relatório";
            this.relatorio.Elements.Add(tileItemElement24);
            this.relatorio.Id = 5;
            this.relatorio.ItemSize = DevExpress.XtraEditors.TileItemSize.Wide;
            this.relatorio.Name = "relatorio";
            this.relatorio.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.relatorio_ItemClick);
            // 
            // cadpessoa
            // 
            this.cadpessoa.AppearanceItem.Normal.BackColor = System.Drawing.Color.MidnightBlue;
            this.cadpessoa.AppearanceItem.Normal.Options.UseBackColor = true;
            tileItemElement25.Image = ((System.Drawing.Image)(resources.GetObject("tileItemElement25.Image")));
            tileItemElement25.ImageLocation = new System.Drawing.Point(45, -25);
            tileItemElement25.Text = "Cadastrar";
            tileItemElement25.TextLocation = new System.Drawing.Point(50, 0);
            tileItemElement26.Text = "Nome";
            tileItemElement26.TextLocation = new System.Drawing.Point(-50, 180);
            this.cadpessoa.Elements.Add(tileItemElement25);
            this.cadpessoa.Elements.Add(tileItemElement26);
            this.cadpessoa.Id = 2;
            this.cadpessoa.ItemSize = DevExpress.XtraEditors.TileItemSize.Medium;
            this.cadpessoa.Name = "cadpessoa";
            this.cadpessoa.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.cadpessoa_ItemClick);
            // 
            // conpessoa
            // 
            this.conpessoa.AppearanceItem.Normal.BackColor = System.Drawing.Color.MidnightBlue;
            this.conpessoa.AppearanceItem.Normal.Options.UseBackColor = true;
            tileItemElement27.Image = ((System.Drawing.Image)(resources.GetObject("tileItemElement27.Image")));
            tileItemElement27.ImageLocation = new System.Drawing.Point(45, -25);
            tileItemElement27.Text = "Consultar";
            tileItemElement27.TextLocation = new System.Drawing.Point(50, 0);
            tileItemElement28.Text = "Nome";
            tileItemElement28.TextLocation = new System.Drawing.Point(-50, 180);
            this.conpessoa.Elements.Add(tileItemElement27);
            this.conpessoa.Elements.Add(tileItemElement28);
            this.conpessoa.Id = 3;
            this.conpessoa.ItemSize = DevExpress.XtraEditors.TileItemSize.Medium;
            this.conpessoa.Name = "conpessoa";
            this.conpessoa.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.conpessoa_ItemClick);
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
            this.label1.TabIndex = 2;
            this.label1.Text = "MENU";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.simpleButton1.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(1485, 759);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(206, 63);
            this.simpleButton1.TabIndex = 3;
            this.simpleButton1.Text = "SAIR";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // MenuADM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1736, 857);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tileControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MenuADM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NOAR ESTÚDIO";
            this.Load += new System.EventHandler(this.MenuADM_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TileControl tileControl1;
        private DevExpress.XtraEditors.TileGroup tileGroup2;
        private DevExpress.XtraEditors.TileItem relatorio;
        private DevExpress.XtraEditors.TileItem cadequip;
        private DevExpress.XtraEditors.TileItem Cadsala;
        private DevExpress.XtraEditors.TileGroup tileGroup3;
        private DevExpress.XtraEditors.TileItem agendamento;
        private DevExpress.XtraEditors.TileItem consala;
        private DevExpress.XtraEditors.TileGroup tileGroup4;
        private DevExpress.XtraEditors.TileItem cadpessoa;
        private DevExpress.XtraEditors.TileItem conpessoa;
        private DevExpress.XtraEditors.TileItem conequip;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
    }
}