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
using System.Configuration;
using DevExpress.XtraEditors;
using DevExpress.XtraBars;


using System.Collections;
using DevExpress.XtraReports.UI;
using DevExpress.LookAndFeel;
using DevExpress.XtraReports.UserDesigner;
using DevExpress.XtraPrinting;
using DevExpress.XtraPrinting.Preview;


namespace WindowsFormsApplication2
{
    public partial class Pagamento : XtraForm
    {
        static string strCn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\USERS\THIAGO KOSHIBA\DESKTOP\WINDOWSFORMSAPPLICATION2\BANCO.MDF;Integrated Security=True;Connect Timeout=30";
        SqlCommand com;
        public String cartao { get; set; }
        public String tipocartao { get; set; }

        public Pagamento()
        {
            InitializeComponent();

            this.Height = 670; //altura
            this.Width = 970; //largura

            DevExpress.Skins.SkinManager.EnableFormSkins();
            DevExpress.UserSkins.BonusSkins.Register();
        }

        public Pagamento(string texto, string total, string data, string hora)
        {
            InitializeComponent();
            nomecliente.Text = texto;
            label15.Text = total;
            label14.Text = total;
            label12.Text = total;
            label26.Text = data;
            label28.Text = hora;
            label30.Text = total;
        }


        private void Pagamento_Load(object sender, EventArgs e)
        {
            btnGerar.Enabled = true;
            btnSalvar.Enabled = false;

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void nomecliente_Click(object sender, EventArgs e)
        {

        }

        private void tipopagamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            tipopagamento.Text = "";



            if (tipopagamento.SelectedIndex == 0)
            {
                groupBox1.Visible = true;
                groupBox1.Location = new Point(540, 130);
            }
            else
            {
                groupBox1.Visible = false;
            }
            if (tipopagamento.SelectedIndex == 1)
            {
                groupBox2.Visible = true;
                groupBox2.Location = new Point(500, 130);
            }
            else
            {
                groupBox2.Visible = false;
            }

            if (tipopagamento.SelectedIndex == 2)
            {
                groupBox3.Visible = true;
                groupBox3.Location = new Point(540, 130);
            }
            else
            {
                groupBox3.Visible = false;
            }



        }

        private void tipopagamento_Enter(object sender, EventArgs e)
        {
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox1.Text = "";
            double N1 = Convert.ToDouble(label12.Text);

            if (comboBox1.SelectedIndex == 0)
            {
                label23.Text = "1x";
                label23.Visible = true;
                label24.Visible = true;
                label24.Text = label12.Text + "";
            }
            if (comboBox1.SelectedIndex == 1)
            {
                label23.Text = "2x";
                label23.Visible = true;
                label24.Visible = true;
                label24.Text = (N1 / 2) + "";
            }
            if (comboBox1.SelectedIndex == 2)
            {
                label23.Text = "3x";
                label23.Visible = true;
                label24.Visible = true;
                label24.Text = (N1 / 3) + "";
            }
            if (comboBox1.SelectedIndex == 3)
            {
                label23.Text = "4x";
                label23.Visible = true;
                label24.Visible = true;
                label24.Text = (N1 / 4) + "";
            }

        }

        private void comboBox1_Enter(object sender, EventArgs e)
        {
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (textBox3.Enabled == false)
            {
                //textBox3.AppendText("Hello");
            }
            else
            {
                calcula();
            }
        }


        public void calcula()
        {
                double N1, Prod, Red, res;
                double N2;
                label20.Text = "SEM DESCONTO";

                if (string.IsNullOrEmpty(textBox3.Text))
                {
                    N2 = 0;

                }
                else
                {
                    N2 = Convert.ToDouble(textBox3.Text);
                    label20.Visible = true;
                }
                N1 = Convert.ToDouble(label15.Text);
                if (string.IsNullOrEmpty(textBox3.Text))
                {
                    label20.Text = "SEM DESCONTO";
                }
                else
                {
                    label20.Text = N1 * (1 - (N2 / 100)) + "";

                }

                

        }
        



        private void textBox3_Enter(object sender, EventArgs e)
        {
        }

        

        private void groupBox2_Enter(object sender, EventArgs e)
        {
        }

        private void radioButton1_Click(object sender, EventArgs e)
        {
            radioVista.Enabled = true;
            radioPrazo.Enabled = false;
            comboBox1.Enabled = false;
            label23.Visible = false;
            label24.Visible = false;
            comboBox1.Text = "";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            cartao = "Crédito";

            radioPrazo.Enabled = true;
            radioVista.Enabled = true;
            label23.Visible = false;
            label24.Visible = false;
            comboBox1.Text = "";

            if (radioPrazo.Checked)
            {
                comboBox1.Enabled = true;
                comboBox1.Text = "";

                // NpgsqlCommand cmd10 = new NpgsqlCommand("INSERT INTO visual_acuity (eid, corrected, is_left_eye, value) VALUES (@eid, @corrected, @is_left_eye, @value)", conn);
                //cmd10.Parameters.AddWithValue("@is_left_eye", radioButton2.Checked);
                //cmd10.Parameters.AddWithValue("@corrected", radioButton4.Checked);
                //cmd10.ExecuteNonQuery();
            }
            else
            {
                comboBox1.Text = "";
            }

        }

        private void radioPrazo_CheckedChanged(object sender, EventArgs e)
        {
            tipocartao = "Parcelado";

            if (radioPrazo.Checked)
            {
                comboBox1.Enabled = true;
                comboBox1.Text = "";

                // NpgsqlCommand cmd10 = new NpgsqlCommand("INSERT INTO visual_acuity (eid, corrected, is_left_eye, value) VALUES (@eid, @corrected, @is_left_eye, @value)", conn);
                //cmd10.Parameters.AddWithValue("@is_left_eye", radioButton2.Checked);
                //cmd10.Parameters.AddWithValue("@corrected", radioButton4.Checked);
                //cmd10.ExecuteNonQuery();




            }





        }

        private void radioVista_CheckedChanged(object sender, EventArgs e)
        {
            tipocartao = "À Vista";

            label23.Text = "";
            comboBox1.Enabled = false;
            label23.Visible = false;
            label24.Visible = false;
            comboBox1.Text = "";
        }


        
        private void btnGerar_Click(object sender, EventArgs e)
        {


            if (tipopagamento.SelectedIndex == -1 || textBox1.Text == "")
            {
                MessageBox.Show("Deve preencher todos os dados !");
            }
            else
            {
                btnSalvar.Enabled = true;

                tipopagamento.Enabled = false;
                textBox1.Enabled = false;
                btnGerar.Enabled = false;

            }

                if (tipopagamento.SelectedIndex == 0)
            {

                string sql = "INSERT INTO PgtoDin (Nome, Data, Hora, Valor, Desconto, VLDesconto, Obs) "

                          + "VALUES ('" + nomecliente.Text + "', '" + label26.Text + "', '"
                          + label28.Text + "', '" + label15.Text + "', '" + textBox3.Text + "','"
                          + label20.Text + "', '" + textBox1.Text + "')";

                SqlConnection con = new SqlConnection(strCn);
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.CommandType = CommandType.Text;
                con.Open();
                try
                {
                    int i = cmd.ExecuteNonQuery();

                    ReportNOAR a = new ReportNOAR();
                    //FormRepost a = new FormRepost();
                    a.ShowPreviewDialog();
                }
                catch (Exception ex)
                {
                }
                
            }
            if(tipopagamento.SelectedIndex == 2)
            {
                string sql = "INSERT INTO PgtoCheq (Nome, Data, Hora, Valor, NumCheq, Conta, Agencia, Obs) "

                          + "VALUES ('" + nomecliente.Text + "', '" + label26.Text + "', '"
                          + label28.Text + "', '" + label14.Text + "', '" + textBox4.Text + "','"
                          + textBox5.Text + "', '" + textBox6.Text + "', '" + textBox1.Text + "')";

                SqlConnection con = new SqlConnection(strCn);
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.CommandType = CommandType.Text;
                con.Open();
                try
                {
                    int i = cmd.ExecuteNonQuery();

                    ReportNOAR1 a = new ReportNOAR1();
                    //FormRepost a = new FormRepost();
                    a.ShowPreview();

                }
                catch (Exception ex)
                {
                }

            }


            

            if (tipopagamento.SelectedIndex == 1)
            {
                string sql = "INSERT INTO PgtoCartao (Nome, Data, Hora, Valor, Cartao, TipoCartao, Parcela, VlParcela, NumCartao, Cod, Obs) "

                          + "VALUES ('" + nomecliente.Text + "', '" + label26.Text + "', '"
                          + label28.Text + "', '" + label12.Text + "', '" + cartao + "', '" + tipocartao + "','" + label23.Text + "','"
                          + label24.Text + "', '" + textBox2.Text + "', '" + textBox7.Text + "', '" + textBox1.Text + "')";

                SqlConnection con = new SqlConnection(strCn);
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.CommandType = CommandType.Text;
                con.Open();
                try
                {
                    int i = cmd.ExecuteNonQuery();

                    ReportNOAR2 a = new ReportNOAR2();
                    //FormRepost a = new FormRepost();
                    a.ShowPreviewDialog();
                }
                catch (Exception ex)
                {
                }

                
            }

           

        }



        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            cartao = "Débito";
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            this.Hide();

            MenuADM ss = new MenuADM();
            ss.Show();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Se a tecla digitada não for número e nem backspace
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                //Atribui True no Handled para cancelar o evento
                e.Handled = true;
            }
        }

        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Se a tecla digitada não for número e nem backspace
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                //Atribui True no Handled para cancelar o evento
                e.Handled = true;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Se a tecla digitada não for número e nem backspace
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                //Atribui True no Handled para cancelar o evento
                e.Handled = true;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            string.IsNullOrEmpty(textBox3.Text = "");

            if (checkBox1.Checked == true)
            {
                textBox3.Enabled = false;

                textBox3.AppendText("SEM DESCONTO");
            }

            if (checkBox1.Checked == false)
            {
                string.IsNullOrEmpty(textBox3.Text = "");
                textBox3.Enabled = true;
            }

        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Se a tecla digitada não for número e nem backspace
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                //Atribui True no Handled para cancelar o evento
                e.Handled = true;
            }
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Se a tecla digitada não for número e nem backspace
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                //Atribui True no Handled para cancelar o evento
                e.Handled = true;
            }
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Se a tecla digitada não for número e nem backspace
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                //Atribui True no Handled para cancelar o evento
                e.Handled = true;
            }
        }

        private void label24_Click(object sender, EventArgs e)
        {

        }
    }
}
