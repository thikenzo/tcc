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
using System.Data.OleDb;

using DevExpress.XtraEditors;
using DevExpress.XtraBars;

namespace WindowsFormsApplication2
{
    public partial class Consulta : XtraForm
    {
        public Consulta()
        {
            InitializeComponent();
            this.Height = 630; //altura
            this.Width = 930; //largura


            DevExpress.Skins.SkinManager.EnableFormSkins();
            DevExpress.UserSkins.BonusSkins.Register();
        }


        public class BDComun
        {
            public static SqlConnection ObterConexao()
            {
                SqlConnection Conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\USERS\THIAGO KOSHIBA\DESKTOP\WINDOWSFORMSAPPLICATION2\BANCO.MDF;Integrated Security=True;Connect Timeout=30");
                Conn.Open();

                return Conn;

            }


        }

        public Cliente ClienteSelecionado { get; set; }


        private void Consulta_Load(object sender, EventArgs e)
        {
                
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            
            this.Hide();

            MenuADM ss = new MenuADM();
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


            if (string.IsNullOrEmpty(comboBox1.Text))
            {
                MessageBox.Show("Campo Tipo Pessoa em branco! , OBRIGATÓRIO!!", "ERRO AO LOGAR");
                comboBox1.Focus();

                return;
            }
            



            if (comboBox1.Text == "Administrador")
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * from CAD where Nome like '" + nomepesquisa.Text + "%' and NivelAcesso = 'Administrador'", conexao);
                DataTable data = new DataTable();
                da.Fill(data);
                dataGridView1.DataSource = data;


                this.dataGridView1.Columns["Id"].Visible = false;
                //this.dataGridView1.Columns["Rg"].Visible = false;
                this.dataGridView1.Columns["Cpf"].Visible = false;
                this.dataGridView1.Columns["Login"].Visible = false;
                this.dataGridView1.Columns["Senha"].Visible = false;
                this.dataGridView1.Columns["NivelAcesso"].Visible = false;
                //Id, Nome, Telefone, Celular, Email, Endereco, N, Bairro, Rg, Cpf, Login, Senha, NivelAcesso

            }
            else if (comboBox1.Text == "Usuário")
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * from CAD where Nome like '" + nomepesquisa.Text + "%' and NivelAcesso = 'Usuário'", conexao);
                DataTable data = new DataTable();
                da.Fill(data);
                dataGridView1.DataSource = data;

                this.dataGridView1.Columns["Id"].Visible = false;
                //this.dataGridView1.Columns["Rg"].Visible = false;
                this.dataGridView1.Columns["Cpf"].Visible = false;
                this.dataGridView1.Columns["Login"].Visible = false;
                this.dataGridView1.Columns["Senha"].Visible = false;
                this.dataGridView1.Columns["NivelAcesso"].Visible = false;
            }
            else if (comboBox1.Text == "Cliente")
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * from CAD where Nome like '" + nomepesquisa.Text + "%' and NivelAcesso = 'Cliente'", conexao);
                DataTable data = new DataTable();
                da.Fill(data);
                dataGridView1.DataSource = data;

                this.dataGridView1.Columns["Id"].Visible = false;
                //this.dataGridView1.Columns["Rg"].Visible = false;
                this.dataGridView1.Columns["Cpf"].Visible = false;
                this.dataGridView1.Columns["Login"].Visible = false;
                this.dataGridView1.Columns["Senha"].Visible = false;
                this.dataGridView1.Columns["NivelAcesso"].Visible = false;
            }

            if (dataGridView1.RowCount == 0) { 
            
                    MessageBox.Show("Nenhum Nome encontrado!! ", "ERRO");
                
            }

    }



        private void editarcliente_Click_1(object sender, EventArgs e)
        {
            
            if (dataGridView1.SelectedRows.Count == 1)
            {
                //Int64 Id = Convert.ToInt64(dataGridView1.CurrentRow.Cells[0].Value);
                //ClienteSelecionado = ClienteFunc.ObterCliente(Id);
                //this.Close();

                Cad Cad = new Cad();
               
                Cad.Id = Convert.ToInt64(dataGridView1.CurrentRow.Cells[0].Value);
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
                Cad.Owner = this;
                Cad.editar.Enabled = true;
                Cad.adicionar.Enabled = false;


                Cad.Show();
                this.Hide();
            }

            else
            {
                MessageBox.Show("Nenhum nome selecionado para Edição!");
            }
        }



        private void btnExcluir_Click(object sender, EventArgs e)
        {
            
            {
                if (dataGridView1.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Não se pode excluir, nenhum nome selecionado!");
                }
                else

                {
                    Int64 Id = Convert.ToInt64(dataGridView1.CurrentRow.Cells[0].Value);
                    ClienteSelecionado = ClienteFunc.ObterCliente(Id);

                    if (MessageBox.Show("Tem certeza que deseja exluir a Pessoa??", "Tem certeza?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {

                        int resultado = ClienteFunc.Excluir(ClienteSelecionado.Id);

                        if (resultado > 0)
                        {

                            MessageBox.Show("Cliente excluído com sucesso!", "Pessoa Excluído", MessageBoxButtons.OK);

                        }

                        else
                        {
                            MessageBox.Show("Não se pode excluir o pessoa, ocorreu um erro!!");
                        }

                    }
                    else
                        MessageBox.Show("Você cancelou a exclusão!", "Cancelado");
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_Enter(object sender, EventArgs e)
        {
           // Validar val = new Validar();
           // comboBox1.DataSource = val.listanivelcad();
            //comboBox1.DisplayMember = "NivelAcesso";
        }


        SqlConnection conexao = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\USERS\THIAGO KOSHIBA\DESKTOP\WINDOWSFORMSAPPLICATION2\BANCO.MDF;Integrated Security=True;Connect Timeout=30");

        private void nomepesquisa_TextChanged(object sender, EventArgs e)
        {
        }

        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dataGridView1.ClearSelection();
        }
    }
}
