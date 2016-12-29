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
    public partial class AgendaServico : Form
    {

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Thiago\Desktop\WindowsFormsApplication2\banco.mdf;Integrated Security=True;Connect Timeout=30");

        public AgendaServico()
        {
            InitializeComponent();
        }

        public AgendaServico(string texto)
        {
            InitializeComponent();
            datalabel.Text = texto;
        }



        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();

            Agenda ss = new Agenda();
            ss.Show();
        }




        private void button1_Click(object sender, EventArgs e)
        {
            if (clientetxt.Text == "" || projetotxt.Text == "" || servico.Text == "" || sala.Text == "" || textBox1.Text == "")
            {
                MessageBox.Show("Deve preencher todos os campos!!");
            }
            else
            {
                Agend Agend = new Agend();
                Agend.Data = datalabel.Text;
                Agend.Cliente = clientetxt.Text;
                Agend.Projeto = projetotxt.Text;
                Agend.Servico = servico.Text;
                Agend.Sala = sala.Text;
                Agend.Descricao = textBox1.Text;

                int resultado = AgendFunc.btnInstrum(Agend);

                InstruLista ss = new InstruLista();
                ss.Show();

                //this.Hide();
                //InstruLista ss = new InstruLista();
                //ss.Show();


                if (resultado > 0)
                {
                    //MessageBox.Show("Dados Guardados! ");
                    //limpar();
                    //combotipo.Text = "";
                    //classificacao = "";

                }

                else
                {
                    MessageBox.Show("Não se pode guardar os dados, erro ao guardar");
                }
            }


        }

        private void sala_SelectedIndexChanged(object sender, EventArgs e)
        {
        }



        private void AgendaServico_Load(object sender, EventArgs e)
        {
            sala.Items.Clear();
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select NomeSala from SalaCad";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                sala.Items.Add(dr["NomeSala"].ToString());
            }
            con.Close();

        }

        private void servico_Enter(object sender, EventArgs e)
        {
            Validar val = new Validar();
            servico.DataSource = val.listanivel2();
            servico.DisplayMember = "Servico";
        }

        private void servico_SelectedIndexChanged(object sender, EventArgs e)
        {
            servico.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (clientetxt.Text == "" || projetotxt.Text == "" || servico.Text == "" || sala.Text == "" || textBox1.Text == "")
            {
                MessageBox.Show("Deve preencher todos os campos!!");
            }
            else
            {
                Agend Agend = new Agend();
                Agend.Data = datalabel.Text;
                Agend.Cliente = clientetxt.Text;
                Agend.Projeto = projetotxt.Text;
                Agend.Servico = servico.Text;
                Agend.Sala = sala.Text;
                Agend.Descricao = textBox1.Text;

                int resultado = AgendFunc.btnInstrum(Agend);



                Pagamento destino = new Pagamento(clientetxt.Text);
                destino.Show();

            }
        }

        private void clientetxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void datalabel_Click(object sender, EventArgs e)
        {

        }
    }
}
