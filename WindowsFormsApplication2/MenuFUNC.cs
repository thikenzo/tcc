using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using DevExpress.XtraEditors;
using DevExpress.XtraBars;

namespace WindowsFormsApplication2
{
    public partial class MenuFUNC : XtraForm
    {
        public MenuFUNC()
        {
            InitializeComponent();

            this.Height = 480; //altura
            this.Width = 900; //largura
            
            DevExpress.Skins.SkinManager.EnableFormSkins();
            DevExpress.UserSkins.BonusSkins.Register();
        }

        private void MenuFUNC_Load(object sender, EventArgs e)
        {

        }

        private void tileControl1_Click(object sender, EventArgs e)
        {

        }

        private void agendamento1_ItemClick(object sender, TileItemEventArgs e)
        {
            this.Hide();
            Agenda1 ss = new Agenda1();
            ss.Show();
        }

        private void relatorio1_ItemClick(object sender, TileItemEventArgs e)
        {
            this.Hide();
            Relatorio1 ss = new Relatorio1();
            ss.Show();
        }

        private void consala1_ItemClick(object sender, TileItemEventArgs e)
        {

        }

        private void conequip1_ItemClick(object sender, TileItemEventArgs e)
        {
            this.Hide();
            ConsultaEquip1 ss = new ConsultaEquip1();
            ss.Show();
        }

        private void conpessoa1_ItemClick(object sender, TileItemEventArgs e)
        {
            this.Hide();
            Consulta1 ss = new Consulta1();
            ss.Show();
        }

        private void cadpessoa1_ItemClick(object sender, TileItemEventArgs e)
        {
            this.Hide();
            Cad1 ss = new Cad1();
            ss.Show();
        }

        private void sair1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 ss = new Form1();
            ss.Show();
        }
    }
}
