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
    public partial class Consulta : Form
    {
        public Consulta()
        {
            InitializeComponent();
        }

        public Cliente ClienteSelecionado { get; set; }


        private void Consulta_Load(object sender, EventArgs e)
        {

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {

            this.Hide();

            Maincs ss = new Maincs();
            ss.Show();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            this.Hide();

            Cad ss = new Cad();
            ss.Show();

        }

        private void pesquisa_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ClienteFunc.BuscarCliente(nomepesquisa.Text);
        }

       
     private void editarcliente_Click_1(object sender, EventArgs e)
        {
            
            if (dataGridView1.SelectedRows.Count == 1)
            {
                //Int64 Id = Convert.ToInt64(dataGridView1.CurrentRow.Cells[0].Value);
                //ClienteSelecionado = ClienteFunc.ObterCliente(Id);
                //this.Close();

                Cad Cad = new Cad();
                Cad.txtNome.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
                Cad.txtTelefone.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
                Cad.txtCelular.Text = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
                Cad.txtEmail.Text = this.dataGridView1.CurrentRow.Cells[4].Value.ToString();
                Cad.txtEndereco.Text = this.dataGridView1.CurrentRow.Cells[5].Value.ToString();
                Cad.txtN.Text = this.dataGridView1.CurrentRow.Cells[6].Value.ToString();
                Cad.txtBairro.Text = this.dataGridView1.CurrentRow.Cells[7].Value.ToString();
                Cad.txtRg.Text = this.dataGridView1.CurrentRow.Cells[8].Value.ToString();
                Cad.txtCpf.Text = this.dataGridView1.CurrentRow.Cells[9].Value.ToString();
                Cad.nivelacesso.Text = this.dataGridView1.CurrentRow.Cells[10].Value.ToString();
                this.Close();

                Cad.ShowDialog();

                //Cad.deletar.Enabled = true;
                //Cad.editar.Enabled = true;
                //Cad.adicionar.Enabled = false;
                
            }

            else
            {
                MessageBox.Show("Nenhum cliente selecionado!");
            }
        }



        private void btnExcluir_Click(object sender, EventArgs e)
        {
            
            {
                Int64 Id = Convert.ToInt64(dataGridView1.CurrentRow.Cells[0].Value);
                ClienteSelecionado = ClienteFunc.ObterCliente(Id);

                if (MessageBox.Show("Tem certeza que deseja exluir o Cliente??", "Tem certeza?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    int resultado = ClienteFunc.Excluir(ClienteSelecionado.Id);

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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
