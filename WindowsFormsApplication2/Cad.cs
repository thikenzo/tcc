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
    public partial class Cad : XtraForm
    {
        
        static string strCn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\USERS\KENZO\DOCUMENTS\VISUALSTUDIO2015\PROJECTS\WINDOWSFORMSAPPLICATION2\BANCO.MDF;Integrated Security=True;Connect Timeout=30";
        SqlConnection conexao = new SqlConnection(strCn);
        

        public Cliente ClieteAtual { get; set; }

        public Cad()
        {
            InitializeComponent();
            DevExpress.Skins.SkinManager.EnableFormSkins();
            DevExpress.UserSkins.BonusSkins.Register();
        }



        private void voltar_Click(object sender, EventArgs e)
        {
            this.Hide();

            Maincs ss = new Maincs();
            ss.Show();
        }

        private void Cad_Load(object sender, EventArgs e)
        {
            deletar.Enabled = false;
            editar.Enabled = false;
            adicionar.Enabled = true;
        }


        void limpar()
        {
            txtNome.Clear();
            txtTelefone.Clear();
            txtCelular.Clear();
            txtEmail.Clear();
            txtEndereco.Clear();
            txtN.Clear();
            txtBairro.Clear();
            txtRg.Clear();
            txtCpf.ResetText();
        }


        private void adicionar_Click(object sender, EventArgs e)
        {
             if (txtNome.Text == "" || txtTelefone.Text == "" || txtCelular.Text == "" || txtEmail.Text == "" || txtEndereco.Text == ""
                    || txtN.Text == "" || txtBairro.Text == "" || txtRg.Text == "" || txtCpf.Text == "" || txtCpf.Text == "NOAR" || txtCpf.Text == "NOAR")
            {
                MessageBox.Show("Deve preencher todos os campos!!");
            }
            else
            {
                Cliente Cliente = new Cliente();
                Cliente.Nome = txtNome.Text;
                Cliente.Telefone = txtTelefone.Text;
                Cliente.Celular = txtCelular.Text;
                Cliente.Email = txtEmail.Text;
                Cliente.Endereco = txtEndereco.Text;
                Cliente.N = txtN.Text;
                Cliente.Bairro = txtBairro.Text;
                Cliente.Rg = txtRg.Text;
                Cliente.Cpf = txtCpf.Text;
                Cliente.Login = txtLogin.Text;
                Cliente.Senha = txtSenha.Text;
                Cliente.NivelAcesso = nivelacesso.Text;
                

                int resultado = ClienteFunc.Adicionar(Cliente);

                if (resultado > 0)
                {
                    MessageBox.Show("Dados Guardados! ");
                    limpar();

                }

                else
                {
                    MessageBox.Show("Não se pode guardar os dados, erro ao guardar");
                }
            }

        }



        private void editar_Click(object sender, EventArgs e)
        {

            Cliente pCliente = new Cliente();
            pCliente.Nome = txtNome.Text;
            pCliente.Telefone = txtTelefone.Text;
            pCliente.Celular = txtCelular.Text;
            pCliente.Email = txtEmail.Text;
            pCliente.Endereco = txtEndereco.Text;
            pCliente.N = txtN.Text;
            pCliente.Bairro = txtBairro.Text;
            pCliente.Rg = txtRg.Text;
            pCliente.Cpf = txtCpf.Text;
            pCliente.Id = ClieteAtual.Id;


            int resultado = ClienteFunc.Editar(pCliente);

            if (resultado > 0)
            {

                MessageBox.Show("Alterado dados Cliente Concluído!");
                limpar();
                //deletar.Enabled = false;
                //editar.Enabled = false;
                //adicionar.Enabled = true;
            }

            else
            {
                MessageBox.Show("Não se pode editar o Cliente, Erro!!");
            }

        }



        private void deletar_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Tem certeza que deseja exluir o Cliente??", "Tem certeza?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                int resultado = ClienteFunc.Excluir(ClieteAtual.Id);

                if (resultado > 0)
                {

                    MessageBox.Show("Cliente excluído com sucesso!", "Cliente Excluído", MessageBoxButtons.OK);
                    limpar();
                    deletar.Enabled = false;
                    editar.Enabled = false;
                    adicionar.Enabled = true;
                }

                else
                {
                    MessageBox.Show("Não se pode excluir o cliente, ocorreu um erro!!");
                }

            }
            else
                MessageBox.Show("Você cancelou a exclusão", "Cancelado");

        }

        private void consulta_Click(object sender, EventArgs e)
        {
            Consulta pConsulta = new Consulta();
            pConsulta.ShowDialog();

            if (pConsulta.ClienteSelecionado != null)
            {

                    ClieteAtual = pConsulta.ClienteSelecionado;

                    txtNome.Text = pConsulta.ClienteSelecionado.Nome;
                    //labelteste.Text = pConsulta.ClienteSelecionado.Nome;
                    txtTelefone.Text = pConsulta.ClienteSelecionado.Telefone;
                    txtCelular.Text = pConsulta.ClienteSelecionado.Celular;
                    txtEmail.Text = pConsulta.ClienteSelecionado.Email;
                    txtEndereco.Text = pConsulta.ClienteSelecionado.Endereco;
                    txtN.Text = pConsulta.ClienteSelecionado.N;
                    txtBairro.Text = pConsulta.ClienteSelecionado.Bairro;
                    txtRg.Text = pConsulta.ClienteSelecionado.Rg;
                    txtCpf.Text = pConsulta.ClienteSelecionado.Cpf;
                    nivelacesso.Text = pConsulta.ClienteSelecionado.NivelAcesso;
                
                adicionar.Enabled = false;
                editar.Enabled = true;
                deletar.Enabled = true;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            nivelacesso.Text = "";
        }

        private void nivelacesso_Enter(object sender, EventArgs e)
        {
            Validar val = new Validar();
            nivelacesso.DataSource = val.listanivel();
            nivelacesso.DisplayMember = "NivelAcesso";
        }

        private void txtEndereco_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
