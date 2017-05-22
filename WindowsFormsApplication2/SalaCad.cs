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
    public partial class SalaCad : XtraForm
    {
        public SalaCad()
        {
            InitializeComponent();

            DevExpress.Skins.SkinManager.EnableFormSkins();
            DevExpress.UserSkins.BonusSkins.Register();

            btnEditar.Enabled = false;
            
        }

        public class BDComun
        {
            public static SqlConnection ObterConexao()
            {
                SqlConnection Conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Kenzo\Documents\data.mdf;Integrated Security=True;Connect Timeout=30");
                Conn.Open();

                return Conn;

            }

        }

        static string strCn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\USERS\THIAGO KOSHIBA\DESKTOP\WINDOWSFORMSAPPLICATION2\BANCO.MDF;Integrated Security=True;Connect Timeout=30";
        SqlConnection conexao = new SqlConnection(strCn);


        public string situacao { get; set; }
        //public Cliente ClieteAtual { get; set; }
        public Sala InstrumAtual { get; set; }

        private void SalaCad_Load(object sender, EventArgs e)
        {
            this.Height = 430; //altura
            this.Width = 700; //largura

            
        }


        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (salatxt.Text == "" || identificacaotxt.Text == "" || tamanho.Text == "" || valortxt.Text == "" || situacao == "" || radioAtivo.Checked == false && radioInativo.Checked  == false)
            {
                MessageBox.Show("Deve preencher todos os campos!!");
            }
            else
            {
                Sala Instrum = new Sala();
                Instrum.NomeSala = salatxt.Text;
                Instrum.Identificacao = identificacaotxt.Text;
                Instrum.Tamanho = tamanho.Text;
                Instrum.Valor = valortxt.Text;
                Instrum.Situacao = situacao;



                int resultado = SalaFunc.Adicionar(Instrum);

                if (resultado > 0)
                {
                    MessageBox.Show("Sala Cadastrado, OK! ");
                    limpar();
                    tamanho.Text = "";
                    situacao = "";
                    radioAtivo.Checked = false;
                    radioInativo.Checked = false;

                }

                else
                {
                    MessageBox.Show("Não se pode salvar os dados, erro ao salvar!");
                }
            }
        }

        public Int64 Id { get; set; }

        private void btnEditar_Click(object sender, EventArgs e)
        {

            Sala pSala = new Sala();
            pSala.Id = Id;
            pSala.NomeSala = salatxt.Text;
            pSala.Identificacao = identificacaotxt.Text;
            pSala.Tamanho = tamanho.Text;
            pSala.Valor = valortxt.Text;
            pSala.Situacao = situacao;
            

            int resultado = SalaFunc.Editar(pSala);

            if (resultado > 0)
            {

                MessageBox.Show("Alterção dos dados da Sala Concluído!");
                limpar();
                radioInativo.Checked = false;
                radioAtivo.Checked = false;

            }

            else
            {
                MessageBox.Show("Erro ao Editar a Sala!!");
            }
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {

        }

        void limpar()
        {
            salatxt.Clear();
            identificacaotxt.Clear();
            valortxt.Clear();
            radioAtivo.Checked = false;
            radioInativo.Checked = false;

        }


        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();

            MenuADM ss = new MenuADM();
            ss.Show();
        }

        private void radioAtivo_CheckedChanged(object sender, EventArgs e)
        {
            situacao = "ATIVO";
        }

        private void radioInativo_CheckedChanged(object sender, EventArgs e)
        {
            situacao = "INATIVO";
        }

        private void tamanho_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
