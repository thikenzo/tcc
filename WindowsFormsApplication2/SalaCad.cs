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


namespace WindowsFormsApplication2
{
    public partial class SalaCad : Form
    {
        public SalaCad()
        {
            InitializeComponent();
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

        static string strCn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Thiago\Desktop\WindowsFormsApplication2\banco.mdf;Integrated Security=True;Connect Timeout=30";
        SqlConnection conexao = new SqlConnection(strCn);


        public string situacao { get; set; }
        //public Cliente ClieteAtual { get; set; }
        public Sala InstrumAtual { get; set; }

        private void SalaCad_Load(object sender, EventArgs e)
        {
            btnDeletar.Enabled = false;
            btnEditar.Enabled = false;
            btnAdicionar.Enabled = true;
        }


        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (salatxt.Text == "" || identificacaotxt.Text == "" || tamanho.Text == "" || valortxt.Text == "" || situacao == "")
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
                    MessageBox.Show("Dados Guardados! ");
                    limpar();
                    tamanho.Text = "";
                    situacao = "";

                }

                else
                {
                    MessageBox.Show("Não se pode guardar os dados, erro ao guardar");
                }
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

            Sala pSala = new Sala();
            pSala.NomeSala = salatxt.Text;
            pSala.Identificacao = identificacaotxt.Text;
            pSala.Tamanho = tamanho.Text;
            pSala.Valor = valortxt.Text;
            pSala.Situacao = situacao;
            

            int resultado = SalaFunc.Editar(pSala);

            if (resultado > 0)
            {

                MessageBox.Show("Alterado dados da Sala Concluído!");
                limpar();
                btnDeletar.Enabled = false;
                btnEditar.Enabled = false;
                btnAdicionar.Enabled = true;
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

        }


        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();

            MainADM ss = new MainADM();
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
    }
}
