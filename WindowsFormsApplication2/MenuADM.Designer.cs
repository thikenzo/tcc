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
            DevExpress.XtraEditors.TileItemElement tileItemElement10 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement11 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement12 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement13 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement14 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement15 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement16 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement17 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement18 = new DevExpress.XtraEditors.TileItemElement();
            this.tileControl1 = new DevExpress.XtraEditors.TileControl();
            this.tileGroup2 = new DevExpress.XtraEditors.TileGroup();
            this.tileItem8 = new DevExpress.XtraEditors.TileItem();
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
            this.sair = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tileControl1
            // 
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
            this.tileControl1.MaxId = 12;
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
            this.tileGroup2.Items.Add(this.tileItem8);
            this.tileGroup2.Items.Add(this.agendamento);
            this.tileGroup2.Name = "tileGroup2";
            // 
            // tileItem8
            // 
            tileItemElement10.Text = "tileItem8";
            this.tileItem8.Elements.Add(tileItemElement10);
            this.tileItem8.Id = 8;
            this.tileItem8.ItemSize = DevExpress.XtraEditors.TileItemSize.Medium;
            this.tileItem8.Name = "tileItem8";
            // 
            // agendamento
            // 
            tileItemElement11.Text = "Agendamento";
            this.agendamento.Elements.Add(tileItemElement11);
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
            tileItemElement12.Text = "Consultar Sala";
            this.consala.Elements.Add(tileItemElement12);
            this.consala.Id = 4;
            this.consala.ItemSize = DevExpress.XtraEditors.TileItemSize.Medium;
            this.consala.Name = "consala";
            this.consala.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.consala_ItemClick);
            // 
            // Cadsala
            // 
            tileItemElement13.Text = "Cadastrar Sala";
            this.Cadsala.Elements.Add(tileItemElement13);
            this.Cadsala.Id = 7;
            this.Cadsala.ItemSize = DevExpress.XtraEditors.TileItemSize.Medium;
            this.Cadsala.Name = "Cadsala";
            this.Cadsala.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.Cadsala_ItemClick);
            // 
            // conequip
            // 
            tileItemElement14.Text = "Consultar Equipamento";
            this.conequip.Elements.Add(tileItemElement14);
            this.conequip.Id = 9;
            this.conequip.ItemSize = DevExpress.XtraEditors.TileItemSize.Medium;
            this.conequip.Name = "conequip";
            this.conequip.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.conequip_ItemClick);
            // 
            // cadequip
            // 
            tileItemElement15.Text = "Cadastrar Equipamento";
            this.cadequip.Elements.Add(tileItemElement15);
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
            tileItemElement16.Text = "Relatorio";
            this.relatorio.Elements.Add(tileItemElement16);
            this.relatorio.Id = 5;
            this.relatorio.ItemSize = DevExpress.XtraEditors.TileItemSize.Wide;
            this.relatorio.Name = "relatorio";
            this.relatorio.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.relatorio_ItemClick);
            // 
            // cadpessoa
            // 
            tileItemElement17.Text = "Cadastrar Nome";
            this.cadpessoa.Elements.Add(tileItemElement17);
            this.cadpessoa.Id = 2;
            this.cadpessoa.ItemSize = DevExpress.XtraEditors.TileItemSize.Medium;
            this.cadpessoa.Name = "cadpessoa";
            this.cadpessoa.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.cadpessoa_ItemClick);
            // 
            // conpessoa
            // 
            tileItemElement18.Text = "Consultar Nome";
            this.conpessoa.Elements.Add(tileItemElement18);
            this.conpessoa.Id = 3;
            this.conpessoa.ItemSize = DevExpress.XtraEditors.TileItemSize.Medium;
            this.conpessoa.Name = "conpessoa";
            this.conpessoa.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.conpessoa_ItemClick);
            // 
            // sair
            // 
            this.sair.Location = new System.Drawing.Point(1531, 759);
            this.sair.Name = "sair";
            this.sair.Size = new System.Drawing.Size(163, 63);
            this.sair.TabIndex = 1;
            this.sair.Text = "SAIR";
            this.sair.UseVisualStyleBackColor = true;
            this.sair.Click += new System.EventHandler(this.sair_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(747, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 73);
            this.label1.TabIndex = 2;
            this.label1.Text = "MENU";
            // 
            // MenuADM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1736, 857);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sair);
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
        private DevExpress.XtraEditors.TileItem tileItem8;
        private DevExpress.XtraEditors.TileGroup tileGroup3;
        private DevExpress.XtraEditors.TileItem agendamento;
        private DevExpress.XtraEditors.TileItem consala;
        private DevExpress.XtraEditors.TileGroup tileGroup4;
        private DevExpress.XtraEditors.TileItem cadpessoa;
        private DevExpress.XtraEditors.TileItem conpessoa;
        private DevExpress.XtraEditors.TileItem conequip;
        private System.Windows.Forms.Button sair;
        private System.Windows.Forms.Label label1;
    }
}