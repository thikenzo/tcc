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
    public partial class ConsultaEquip : Form
    {
        public ConsultaEquip()
        {
            InitializeComponent();
        }

        
        public Instrum InstrumSelecionado { get; set; }




        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            dataGridView2.DataSource = InstrumFunc.BuscarEquip(textBox1.Text);
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            {
                Int64 Id = Convert.ToInt64(dataGridView2.CurrentRow.Cells[0].Value);
                InstrumSelecionado = InstrumFunc.ObterEquip(Id);

                if (MessageBox.Show("Tem certeza que deseja exluir o Cliente??", "Tem certeza?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    int resultado = InstrumFunc.Excluir(InstrumSelecionado.Id);

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

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count == 1)
            {
                //Int64 Id = Convert.ToInt64(dataGridView2.CurrentRow.Cells[0].Value);
                //InstrumSelecionado = InstrumFunc.ObterEquip(Id);
                //this.Close();

                InstruCad InstruCad = new InstruCad();
                InstruCad.txtNomeEquip.Text = this.dataGridView2.CurrentRow.Cells[1].Value.ToString();
                InstruCad.classificacao = this.dataGridView2.CurrentRow.Cells[2].Value.ToString();
                InstruCad.combotipo.Text = this.dataGridView2.CurrentRow.Cells[3].Value.ToString();
                InstruCad.txtValor.Text = this.dataGridView2.CurrentRow.Cells[4].Value.ToString();
                this.Close();

                InstruCad.ShowDialog();

            }
            else
            {
                MessageBox.Show("Não selecioando nenhum Equipamento!");
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {

            this.Hide();
            MainADM ss = new MainADM();
            ss.Show();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {

            this.Hide();

            InstruCad ss = new InstruCad();
            ss.Show();
        }

        private void ConsultaEquip_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // if (e.RowIndex >= 0)
            // {
            //     DataGridViewRow row = this.dataGridView2.Rows[e.RowIndex];
            //     textBox2.Text = row.Cells[0].Value.ToString();
            //     textBox3.Text = row.Cells[1].Value.ToString();
            // }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            InstruCad InstruCad = new InstruCad();
            InstruCad.txtNomeEquip.Text = this.dataGridView2.CurrentRow.Cells[0].Value.ToString();
            ConsultaEquip consult = new ConsultaEquip();
            consult.Close();


            InstruCad.ShowDialog();
        }
    }
}
