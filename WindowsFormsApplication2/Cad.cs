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

            editar.Enabled = false;
        }



        private void voltar_Click(object sender, EventArgs e)
        {
            this.Hide();

            MenuADM ss = new MenuADM();
            ss.Show();
        }

        private void Cad_Load(object sender, EventArgs e)
        {
            this.Height = 590; //altura
            this.Width = 550; //largura
            
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
            txtTelefone.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            txtCelular.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            txtRg.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            txtCpf.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;

            if (nivelacesso.Text == "" || txtNome.Text == "" || txtTelefone.Text == "" || txtCelular.Text == "" || txtEmail.Text == "" || txtEndereco.Text == ""
                   || txtN.Text == "" || txtBairro.Text == "" || txtRg.Text == "" || txtCpf.Text == ""  )
            {
                // MessageBox.Show("Deve preencher todos os campos!!");
                label12.Visible = true;


                if(nivelacesso.Text =="")
                {
                    label13.Visible = true;
                }

                if (txtNome.Text == "")
                {
                    label14.Visible = true;
                }

                if (txtTelefone.Text == "")
                {
                    label15.Visible = true;
                }

                if (txtCelular.Text == "")
                {
                    label16.Visible = true;
                }

                if (txtEmail.Text == "")
                {
                    label17.Visible = true;
                }

                if (txtRg.Text == "")
                {
                    label18.Visible = true;
                }

                if (txtCpf.Text == "")
                {
                    label19.Visible = true;
                }

                if (txtEndereco.Text == "")
                {
                    label20.Visible = true;
                }

                if (txtN.Text == "")
                {
                    label21.Visible = true;
                }

                if (txtBairro.Text == "")
                {
                    label22.Visible = true;
                }
                
                
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
                    nivelacesso.SelectedIndex = -1;

                    label12.Visible = false;
                    label13.Visible = false;
                    label14.Visible = false;
                    label15.Visible = false;
                    label16.Visible = false;
                    label17.Visible = false;
                    label18.Visible = false;
                    label19.Visible = false;
                    label20.Visible = false;
                    label21.Visible = false;
                    label22.Visible = false;

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
            if (nivelacesso.Text == "")
            {
                label13.Visible = true;
            }
            else
            {
                label13.Visible = false;
            }

        }

        private void nivelacesso_Enter(object sender, EventArgs e)
        {
            Validar val = new Validar();
            nivelacesso.DataSource = val.listanivelcad();
            nivelacesso.DisplayMember = "Nivel";
        }

        private void txtEndereco_TextChanged(object sender, EventArgs e)
        {
            if (txtEndereco.Text == "")
            {
                label20.Visible = true;
            }
            else
            {
                label20.Visible = false;
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            if (txtNome.Text == "")
            {
                label14.Visible = true;
            }
            else
            {
                label14.Visible = false;
            }
        }

        private void txtTelefone_TextChanged(object sender, EventArgs e)
        {
            if (txtTelefone.Text == "")
            {
                label15.Visible = true;
            }
            else
            {
                label15.Visible = false;
            }
        }

        private void txtCelular_TextChanged(object sender, EventArgs e)
        {
            if (txtCelular.Text == "")
            {
                label16.Visible = true;
            }
            else
            {
                label16.Visible = false;
            }
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            if (txtEmail.Text == "")
            {
                label17.Visible = true;
            }
            else
            {
                label17.Visible = false;
            }
        }

        private void txtRg_TextChanged(object sender, EventArgs e)
        {
            if (txtRg.Text == "")
            {
                label18.Visible = true;
            }
            else
            {
                label18.Visible = false;
            }
        }

        private void txtCpf_TextChanged(object sender, EventArgs e)
        {
            if (txtCpf.Text == "")
            {
                label19.Visible = true;
            }
            else
            {
                label19.Visible = false;
            }
        }

        private void txtN_TextChanged(object sender, EventArgs e)
        {
            if (txtN.Text == "")
            {
                label21.Visible = true;
            }
            else
            {
                label21.Visible = false;
            }
        }

        private void txtBairro_TextChanged(object sender, EventArgs e)
        {
            if (txtBairro.Text == "")
            {
                label22.Visible = true;
            }
            else
            {
                label22.Visible = false;
            }
        }
    }
}
