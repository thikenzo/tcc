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






        public void LogarF()
        {

                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Thiago\Desktop\WindowsFormsApplication2\banco.mdf;Integrated Security=True;Connect Timeout=30");
            // funciona - SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) From Login where Username='"+ txtusuario.Text + "' and Password = '" +txtsenha.Text+ "' and NivelAcesso = @NivelAcesso ", con);

           SqlCommand cmd = new SqlCommand("Select * From CAD where LOGIN = @Login  ", con);
           

            cmd.Parameters.Add("@Login", SqlDbType.VarChar).Value = txtusuario.Text;
            cmd.Parameters.Add("@Senha", SqlDbType.VarChar).Value = txtsenha.Text;
            //cmd.Parameters.Add("@NivelAcesso", SqlDbType.VarChar).Value = nivelacesso.Text;
            con.Open();
            
            SqlDataReader le = null;
            le = cmd.ExecuteReader();
            if (le.Read())
            {
                this.Hide();
                
                if(nivelacesso.SelectedIndex == 1)
                {
                    
                    this.Hide();
                    Maincs cc = new Maincs();
                    cc.Show();
                }
                else
                
                {
                    this.Hide();
                    MainADM cc = new MainADM();
                    cc.Show();
                }
                }
                else
                {
                    MessageBox.Show("Nivel de acesso ou senha INCORRETOS!", "ERRO AO LOGAR");
                    logado = false;
                }
            
        }
        
            


        private void logar_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtsenha.Text))
            {
                MessageBox.Show("Campo senha em branco, OBRIGATÓRIO!!", "ERRO AO LOGAR");
                txtsenha.Focus();

                return;
            }
            else {
                LogarF();
            }
        }







        private void nivelacesso_SelectedIndexChanged(object sender, EventArgs e)
        {
            nivelacesso.Text = "";
        }

        private void txtsenha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                LogarF();
            }
        }

        private void nivelacesso_Enter(object sender, EventArgs e)
        {
            Validar val = new Validar();
            nivelacesso.DataSource = val.listanivel();
            nivelacesso.DisplayMember = "NivelAcesso";

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
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
    }
}
