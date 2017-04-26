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
    public partial class AgendaServico : XtraForm
    {

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\USERS\THIAGO KOSHIBA\DESKTOP\WINDOWSFORMSAPPLICATION2\BANCO.MDF;Integrated Security=True;Connect Timeout=30");

        public AgendaServico()
        {
            InitializeComponent();
            DevExpress.Skins.SkinManager.EnableFormSkins();
            DevExpress.UserSkins.BonusSkins.Register();

            this.Height = 570; //altura
            this.Width = 870; //largura
        }

        public AgendaServico(string texto, string label22)
        {
            InitializeComponent();
            datalabel.Text = texto;
            label10.Text = label22;
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
                Agend.Data = label10.Text;
                Agend.Hora = datalabel.Text;
                Agend.Cliente = clientetxt.Text;
                Agend.Projeto = projetotxt.Text;
                Agend.Servico = servico.Text;
                Agend.Sala = sala.Text;
                Agend.Descricao = textBox1.Text;

                int resultado = AgendFunc.btnInstrum(Agend);

                this.Hide();
                InstruLista ss = new InstruLista(label10.Text , clientetxt.Text, datalabel.Text);
                ss.Show();



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
           sala.Text = "";

            
        }

        


        private void AgendaServico_Load(object sender, EventArgs e)
        {
            conectcli c = new conectcli();
            c.autocomplete(clientetxt);

            
           
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
                Agend.Data = label10.Text;
                Agend.Hora = datalabel.Text;
                Agend.Cliente = clientetxt.Text;
                Agend.Projeto = projetotxt.Text;
                Agend.Servico = servico.Text;
                Agend.Sala = sala.Text;
                Agend.Descricao = textBox1.Text;

                int resultado = AgendFunc.btnInstrum(Agend);


                this.Hide();
                Pagamento novaForm = new Pagamento(clientetxt.Text);
                novaForm.Show();

            }
        }

        private void clientetxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void datalabel_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show(" Agendamento não será salvo! Deseja sair?", "NOAR ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                this.Hide();

                MenuADM ss = new MenuADM();
                ss.Show();
            }
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
