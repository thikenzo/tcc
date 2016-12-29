using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraBars;



namespace WindowsFormsApplication2
{
    public partial class MainADM : XtraForm
    {

        public Cliente ClieteAtual { get; set; }


        public MainADM()
        {
            InitializeComponent();
            DevExpress.Skins.SkinManager.EnableFormSkins();
            DevExpress.UserSkins.BonusSkins.Register();
        }

        private void cadastrar_Click(object sender, EventArgs e)
        {
            this.Hide();

            Cad ss = new Cad();
            ss.Show();
        }

        private void consultar_Click(object sender, EventArgs e)
        {
            this.Hide();

            Consulta ss = new Consulta();
            ss.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Cadquip1_Click(object sender, EventArgs e)
        {
            this.Hide();

            InstruCad ss = new InstruCad();
            ss.Show();


        }

        private void CadSala1_Click(object sender, EventArgs e)
        {
            this.Hide();

            SalaCad ss = new SalaCad();
            ss.Show();
        }

        private void equipamento_Click(object sender, EventArgs e)
        {
            this.Hide();

            InstruLista ss = new InstruLista();
            ss.Show();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 ss = new Form1();
            ss.Show();
        }

        private void btnConsultaEquip_Click(object sender, EventArgs e)
        {
            this.Hide();
            ConsultaEquip ss = new ConsultaEquip();
            ss.Show();
        }

        private void MainADM_Load(object sender, EventArgs e)
        {

        }

        private void salas_Click(object sender, EventArgs e)
        {
            this.Hide();
            ConSala ss = new ConSala();
            ss.Show();
        }

        private void relatorio_Click(object sender, EventArgs e)
        {
            this.Hide();
            Relatorio ss = new Relatorio();
            ss.Show();
        }


        private void tileItem2_ItemClick(object sender, TileItemEventArgs e)
        {
            this.Hide();
            ConsultaEquip ss = new ConsultaEquip();
            ss.Show();
        }


        private void tileItem3_ItemClick(object sender, TileItemEventArgs e)
        {
            this.Hide();

            InstruCad ss = new InstruCad();
            ss.Show();
        }

        private void tileItem4_ItemClick(object sender, TileItemEventArgs e)
        {

            this.Hide();

            SalaCad ss = new SalaCad();
            ss.Show();
        }

        private void tileItem5_ItemClick(object sender, TileItemEventArgs e)
        {
            this.Hide();
            Agenda ss = new Agenda();
            ss.Show();
        }



        private void tileControl1_Click(object sender, EventArgs e)
        {

        }

        private void tileItem7_ItemClick(object sender, TileItemEventArgs e)
        {
            this.Hide();

            Consulta ss = new Consulta();
            ss.Show();
        }

        private void tileItem8_ItemClick(object sender, TileItemEventArgs e)
        {
            this.Hide();

            Cad ss = new Cad();
            ss.Show();
        }

        private void tileItem9_ItemClick(object sender, TileItemEventArgs e)
        {
            this.Hide();
            Relatorio ss = new Relatorio();
            ss.Show();
        }

        private void tileItem10_ItemClick(object sender, TileItemEventArgs e)
        {
            this.Hide();

            InstruLista ss = new InstruLista();
            ss.Show();
        }

        private void tileItem11_ItemClick(object sender, TileItemEventArgs e)
        {
            this.Hide();
            Agenda ss = new Agenda();
            ss.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form1 ss = new Form1();
            ss.Show();
        }

        private void tileItem1_ItemClick(object sender, TileItemEventArgs e)
        {
            this.Hide();
            ConSala ss = new ConSala();
            ss.Show();
        }
    }
    
}
