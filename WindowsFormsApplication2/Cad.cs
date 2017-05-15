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
        

        static string strCn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\USERS\THIAGO KOSHIBA\DESKTOP\WINDOWSFORMSAPPLICATION2\BANCO.MDF;Integrated Security=True;Connect Timeout=30";
        //bool novo;
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
            this.Height = 640; //altura
            this.Width = 550; //largura

            editar.Enabled = false; 
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

            if (nivelacesso.Text == "" || txtNome.Text == "" || txtTelefone.Text == "" || txtCelular.Text == "" || txtEmail.Text == "" || txtEndereco.Text == ""
                   || txtN.Text == "" || txtBairro.Text == "" || txtRg.Text == "" || txtCpf.Text == "" || txtCpf.Text == "NOAR" || txtCpf.Text == "NOAR")
            {
                MessageBox.Show("Deve preencher todos os campos!!");
            }
            else
            {
                string sql = "INSERT INTO CAD (Nome, Telefone, Celular ,Email, Endereco, N, Bairro, Rg, Cpf, Login, Senha, NivelAcesso) "

                      + "VALUES ('" + txtNome.Text + "', '" + txtTelefone.Text + "', '"
                      + txtCelular.Text + "', '" + txtEmail.Text + "', '" + txtEndereco.Text + "','"
                      + txtN.Text + "', '" + txtBairro.Text
                      + "', '" + txtRg.Text + "', '" + txtCpf.Text + "', '"
                      + txtLogin.Text + "', '" + txtSenha.Text + "', '" + nivelacesso.Text + "')";

                SqlConnection con = new SqlConnection(strCn);
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.CommandType = CommandType.Text;
                con.Open();
                try
                {
                    int i = cmd.ExecuteNonQuery();
                    if (i > 0)
                        MessageBox.Show("Cadastro realizado com sucesso!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.ToString());
                }
                finally
                {
                    txtNome.Text = "";
                    txtN.Text = "";
                    txtRg.Text = "";
                    txtTelefone.Text = "";
                    txtEndereco.Text = "";
                    txtBairro.Text = "";
                    txtCelular.Text = "";
                    txtCpf.Text = "";
                    txtEmail.Text = "";
                    nivelacesso.Text = "";

                    con.Close();
                }
            }


        }

        public Int64 Id { get; set; }

        private void editar_Click(object sender, EventArgs e)
        {

            Cliente pCliente = new Cliente();

            pCliente.Id = Id;
            pCliente.Nome = txtNome.Text;
            pCliente.Telefone = txtTelefone.Text;
            pCliente.Celular = txtCelular.Text;
            pCliente.Email = txtEmail.Text;
            pCliente.Endereco = txtEndereco.Text;
            pCliente.N = txtN.Text;
            pCliente.Bairro = txtBairro.Text;
            pCliente.Rg = txtRg.Text;
            pCliente.Cpf = txtCpf.Text;
            pCliente.NivelAcesso = nivelacesso.Text;
            //pCliente.Id = ClieteAtual.Id;


            int resultado = ClienteFunc.Editar(pCliente);

            if (resultado > 0)
            {

                MessageBox.Show("Alterado dados Cliente Concluído!");
                limpar();
            }

            else
            {
                MessageBox.Show("Não se pode editar o Cliente, Erro!!");
            }

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
                
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            nivelacesso.Text = "";
        }

        private void nivelacesso_Enter(object sender, EventArgs e)
        {
            Validar val = new Validar();
            nivelacesso.DataSource = val.listanivelcad();
            nivelacesso.DisplayMember = "Nivel";
        }

        private void txtEndereco_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
