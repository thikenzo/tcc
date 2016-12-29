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
    public partial class Maincs : Form
    {
        public Maincs()
        {
            InitializeComponent();
        }

        public Cliente ClienteAtual { get; set; }

        private void cadastrar_Click(object sender, EventArgs e)
        {

            this.Hide();

            Cad ss = new Cad();
            ss.Show();
        }

        private void sair_Click(object sender, EventArgs e)
        {
            this.Hide();

            Form1 ss = new Form1();
            ss.Show();
        }

        private void consultar_Click(object sender, EventArgs e)
        {
            this.Hide();

            Consulta ss = new Consulta();
            ss.Show();
        }

        private void equipamento_Click(object sender, EventArgs e)
        {
            this.Hide();

            InstruLista ss = new InstruLista();
            ss.Show();
        }

        private void Maincs_Load(object sender, EventArgs e)
        {

        }
    }

}

