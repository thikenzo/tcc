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
    public partial class ConSala : XtraForm
    {
        public ConSala()
        {
            InitializeComponent();
            DevExpress.Skins.SkinManager.EnableFormSkins();
            DevExpress.UserSkins.BonusSkins.Register();
        }


        public Sala InstrumSelecionado { get; set; }


        private void btnMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuADM ss = new MenuADM();
            ss.Show();
        }

        private void btnAgenda_Click(object sender, EventArgs e)
        {
            this.Hide();
            Agenda ss = new Agenda();
            ss.Show();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            this.Hide();
            SalaCad ss = new SalaCad();
            ss.Show();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            {
                Int64 Id = Convert.ToInt64(dataGridView2.CurrentRow.Cells[0].Value);
                InstrumSelecionado = SalaFunc.ObterEquip(Id);

                if (MessageBox.Show("Tem certeza que deseja exluir o Cliente??", "Tem certeza?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    int resultado = SalaFunc.Excluir(InstrumSelecionado.Id);

                    if (resultado > 0)
                    {

                        MessageBox.Show("Cliente excluído com sucesso!", "Cliente Excluído", MessageBoxButtons.OK);

                    }

                    else
                    {
                        MessageBox.Show("Não se pode excluir o cliente, ocorreu um erro!!");
                    }

                }
                else
                    MessageBox.Show("Você cancelou a exclusão", "Cancelado");

            }
        }

        private void btnPesquisa_Click(object sender, EventArgs e)
        {
            dataGridView2.DataSource = SalaFunc.BuscarEquip(textBox1.Text);
            this.dataGridView2.Columns["Id"].Visible = false;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            this.dataGridView2.Columns["Id"].Visible = false;
            SalaCad salaC = new SalaCad();
            salaC.salatxt.Text = this.dataGridView2.CurrentRow.Cells[1].Value.ToString();
            salaC.identificacaotxt.Text = this.dataGridView2.CurrentRow.Cells[2].Value.ToString();
            salaC.tamanho.Text = this.dataGridView2.CurrentRow.Cells[3].Value.ToString();
            salaC.valortxt.Text = this.dataGridView2.CurrentRow.Cells[4].Value.ToString();
            salaC.situacao = this.dataGridView2.CurrentRow.Cells[5].Value.ToString();
            this.Close();
            salaC.ShowDialog();
        }

        private void ConSala_Load(object sender, EventArgs e)
        {
            
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
