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
    public partial class Relatorio1 : XtraForm
    {
        public Relatorio1()
        {
            InitializeComponent();


            this.Height = 555; //altura
            this.Width = 870; //largura
            DevExpress.Skins.SkinManager.EnableFormSkins();
            DevExpress.UserSkins.BonusSkins.Register();
        }

        private void Relatorio1_Load(object sender, EventArgs e)
        {

            // TODO: esta linha de código carrega dados na tabela 'bancoDataSet.Agenda'. Você pode movê-la ou removê-la conforme necessário.
            //this.agendaTableAdapter1.Fill(this.bancoDataSet.Agenda);
        }


        private void servico_Enter(object sender, EventArgs e)
        {

        }

        private void servico_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();

            MenuFUNC ss = new MenuFUNC();
            ss.Show();
        }
    }
}
