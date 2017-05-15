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


//https://www.youtube.com/watch?v=D2m0OGFyufU
//https://www.youtube.com/watch?v=D2m0OGFyufU


namespace WindowsFormsApplication2
{
    public partial class Form1 : XtraForm
    {




        public static string Acesso;
        public Boolean logado = false;




        public Form1()
        {
            InitializeComponent();
            DevExpress.Skins.SkinManager.EnableFormSkins();
            DevExpress.UserSkins.BonusSkins.Register();
        }

        private void sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        bool aaa;




        public void LogarF()
        {


            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\USERS\THIAGO KOSHIBA\DESKTOP\WINDOWSFORMSAPPLICATION2\BANCO.MDF;Integrated Security=True;Connect Timeout=30");
            // funciona - SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) From Login where Username='"+ txtusuario.Text + "' and Password = '" +txtsenha.Text+ "' and NivelAcesso = @NivelAcesso ", con);

            SqlCommand cmd = new SqlCommand("Select * From CAD where LOGIN = @Login and Senha = @Senha and NivelAcesso = @NivelAcesso ", con);

            cmd.Parameters.Add("@Login", SqlDbType.VarChar).Value = txtusuario.Text;
            cmd.Parameters.Add("@Senha", SqlDbType.VarChar).Value = txtsenha.Text;
            cmd.Parameters.Add("@NivelAcesso", SqlDbType.VarChar).Value = "Administrador";
            //cmd.Parameters.Add("@NivelAcesso", SqlDbType.VarChar).Value = "Administrador";
            con.Open();

            SqlDataReader le = null;
            le = cmd.ExecuteReader();
            if (le.Read())
            {
                // SqlCommand cmd1 = new SqlCommand("Select * From CAD where NivelAcesso = 'Administrador'", con);

                this.Hide();
                MenuADM ss = new MenuADM();
                ss.Show();
                le.Close();
            }
            else
            {
                le.Close();
                SqlCommand cmd111 = new SqlCommand("Select * From CAD where LOGIN = @Login and Senha = @Senha and NivelAcesso = @NivelAcesso", con);
                cmd111.Parameters.Add("@Login", SqlDbType.VarChar).Value = txtusuario.Text;
                cmd111.Parameters.Add("@Senha", SqlDbType.VarChar).Value = txtsenha.Text;
                cmd111.Parameters.Add("@NivelAcesso", SqlDbType.VarChar).Value = "Usuário";

                le = cmd111.ExecuteReader();

                if (le.Read())
                {
                    this.Hide();
                    Maincs ss1 = new Maincs();
                    ss1.Show();
                    le.Close();
                }
                else
                {
                    MessageBox.Show("Usuário e Senha incorretos! ");
                }
            
            }
        }
        
                  



    private void logar_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtsenha.Text))
            {
                if (string.IsNullOrEmpty(txtusuario.Text))
                {
                    txtusuario.Text = "";
                    MessageBox.Show("Campo Login e Senha em branco, OBRIGATÓRIO!!", "ERRO AO LOGAR");
                    txtusuario.Focus();

                    return;

                }
                MessageBox.Show("Campo Senha em branco, OBRIGATÓRIO!!", "ERRO AO LOGAR");
                txtsenha.Focus();

                return;
            }
            else
            {
                //LogarF();
            }
                
            /////////////////////////////
            if (string.IsNullOrEmpty(txtusuario.Text))
                {
                    txtusuario.Text = "";
                    MessageBox.Show("Campo Login em branco, OBRIGATÓRIO!!", "ERRO AO LOGAR");
                    txtusuario.Focus();

                    return;
                }
                else
                {
                    LogarF();
                }
            }
        




        private void nivelacesso_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        
    

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {


            Application.Exit();

        }

        private void button4_Click(object sender, EventArgs e)
        {

            this.Hide();
            Cad ss = new Cad();
            ss.Show();
        }

        private void tileControl1_Click(object sender, EventArgs e)
        {
            
        }

    }
    
}
