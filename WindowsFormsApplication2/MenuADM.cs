using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class MenuADM : Form
    {
        public MenuADM()
        {
            InitializeComponent();
        }

        private void sair_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 ss = new Form1();
            ss.Show();
        }

        private void agendamento_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            this.Hide();
            Agenda ss = new Agenda();
            ss.Show();
        }

        private void relatorio_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            this.Hide();
            Relatorio ss = new Relatorio();
            ss.Show();
        }

        private void consala_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            this.Hide();
            ConSala ss = new ConSala();
            ss.Show();
        }

        private void Cadsala_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            this.Hide();
            SalaCad ss = new SalaCad();
            ss.Show();
        }

        private void conequip_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            this.Hide();
            ConsultaEquip ss = new ConsultaEquip();
            ss.Show();
        }

        private void cadequip_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            this.Hide();
            InstruCad ss = new InstruCad();
            ss.Show();
        }

        private void cadpessoa_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            this.Hide();
            Cad ss = new Cad();
            ss.Show();
        }

        private void conpessoa_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            this.Hide();
            Consulta ss = new Consulta();
            ss.Show();
        }
    }
}
