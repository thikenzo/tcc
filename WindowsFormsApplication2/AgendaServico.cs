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
    public partial class AgendaServico : XtraForm
    {

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\USERS\THIAGO KOSHIBA\DESKTOP\WINDOWSFORMSAPPLICATION2\BANCO.MDF;Integrated Security=True;Connect Timeout=30");

        public AgendaServico()
        {
            InitializeComponent();
            DevExpress.Skins.SkinManager.EnableFormSkins();
            DevExpress.UserSkins.BonusSkins.Register();

            this.Height = 555; //altura
            this.Width = 870; //largura



        }

        public AgendaServico(string texto, string label22, string nome, string valor, string desc, string proj, string projcomb, string sal)
        {
            InitializeComponent();
            datalabel.Text = texto;
            label10.Text = label22;
            clientetxt.Text = nome;
            label13.Text = valor;
            textBox1.Text = desc;
            projetotxt.Text = proj;
            servico.Text = projcomb;
            sala.Text = sal;

        }


        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Agenda novaForm = new Agenda();
            novaForm.Show();
        }

        



        private void button1_Click(object sender, EventArgs e)
        {
            if (clientetxt.Text == "" || projetotxt.Text == "" || servico.Text == "" || sala.Text == "" || textBox1.Text == "")
            {
                MessageBox.Show("Deve preencher todos os campos!!");
            }
            else
            {
                //Agend Agend = new Agend();
                //Agend.Data = label10.Text;
                //Agend.Hora = datalabel.Text;
                //Agend.Cliente = clientetxt.Text;
                //Agend.Projeto = projetotxt.Text;
                //Agend.Servico = servico.Text;
                //Agend.Sala = sala.Text;
                //Agend.Descricao = textBox1.Text;

                //int resultado = AgendFunc.btnInstrum(Agend);

                this.Hide();
                InstruLista ss = new InstruLista(label10.Text , clientetxt.Text, datalabel.Text, label13.Text, textBox1.Text, projetotxt.Text, servico.Text, sala.Text);
                ss.Show();



               // if (resultado > 0)
                //{
                    //MessageBox.Show("Dados Guardados! ");
                    //limpar();
                    //combotipo.Text = "";
                    //classificacao = "";

               // }

               // else
               // {
                    MessageBox.Show("Não se pode guardar os dados, erro ao guardar");
               // }
            }


        }

        private void sala_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlDataAdapter da1 = new SqlDataAdapter ("select * from SalaCad where Situacao = 'ATIVO' ",con);
            DataTable dt1 = new DataTable();
            da1.Fill(dt1);
            foreach (DataRow dr in dt1.Rows)
            {
                sala.Items.Add(dr["NomeSala"].ToString());
            }

            ///////////////////////////////
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from SalaCad where NomeSala = '" + sala.SelectedItem.ToString() + "' and Situacao = 'ATIVO' ";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                label13.Text = dr["Valor"].ToString();
            }
            con.Close();


        }


        private void AgendaServico_Load(object sender, EventArgs e)
        {
            linkLabel1.Visible = true;

            conectcli c = new conectcli();
            c.autocomplete(clientetxt);

            if(clientetxt.Text == "")
            {
                linkLabel1.Visible = true;
            }

            //////////////////////////////////

            con.Open();
            SqlCommand cmdA = con.CreateCommand();
            cmdA.CommandType = CommandType.Text;
            cmdA.CommandText = "Select NomeSala from SalaCad where Situacao = 'ATIVO'";
            cmdA.ExecuteNonQuery();
            DataTable dtA = new DataTable();
            SqlDataAdapter daA = new SqlDataAdapter(cmdA);
            daA.Fill(dtA);
            foreach (DataRow drA in dtA.Rows)
            {
                sala.Items.Add(drA["NomeSala"].ToString());
            }
            con.Close();

        }



        private void servico_Enter(object sender, EventArgs e)
        {
        }

        private void servico_SelectedIndexChanged(object sender, EventArgs e)
        {
            
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
                Pagamento novaForm = new Pagamento(clientetxt.Text, label13.Text, label10.Text, datalabel.Text);
                novaForm.Show();

            }
        }

        private void clientetxt_TextChanged(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\USERS\THIAGO KOSHIBA\DESKTOP\WINDOWSFORMSAPPLICATION2\BANCO.MDF;Integrated Security=True;Connect Timeout=30");
            
            SqlCommand cmd = new SqlCommand("Select * From CAD where Nome = @Nome ", con);

            cmd.Parameters.Add("@Nome", SqlDbType.VarChar).Value = clientetxt.Text;
            con.Open();

            SqlDataReader le = null;
            le = cmd.ExecuteReader();
            if (le.Read())
            {
                linkLabel1.Visible = false;

            }
            else
            {
                linkLabel1.Visible = true;
         }
            

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

        private void clientetxt_MouseClick(object sender, MouseEventArgs e)
        {
            //linkLabel1.Visible = false;

        }

        private void clientetxt_Click(object sender, EventArgs e)
        {

        }

        private void clientetxt_ModifiedChanged(object sender, EventArgs e)
        {
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show(" Irá cancelar o agendamento! ", "NOAR " );

            this.Hide();
            Cad novaForm = new Cad();
            novaForm.Show();
        }


        private void sala_Click(object sender, EventArgs e)
        {
          
        }


    }
}
