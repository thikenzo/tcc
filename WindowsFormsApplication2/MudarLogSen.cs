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
using System.Diagnostics;

using DevExpress.XtraEditors;
using DevExpress.XtraBars;

namespace WindowsFormsApplication2
{
    public partial class MudarLogSen : XtraForm
    {
        public MudarLogSen()
        {
            InitializeComponent();
            DevExpress.Skins.SkinManager.EnableFormSkins();
            DevExpress.UserSkins.BonusSkins.Register();

            this.Height = 460; //altura
            this.Width = 520; //largura
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
                if (textBox1.Text == "NOAR")
                {
                    label9.Visible = true;
                }
                else
                {
                    label9.Visible = false;
                }
                if (textBox1.Text == "")
                {
                    label15.Visible = true;
                }
                else
                {
                    label15.Visible = false;
                }

            if (textBox6.Text == "")
            {
                label17.Visible = true;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text != "" && textBox5.Text == "")
            {
                //label13.Visible = true;
                label10.Visible = false;
            }

            if (textBox2.Text == textBox5.Text)
            {
                label12.Visible = true;
                label20.Visible = false;
            }
            else
            {
                label10.Visible = true;
                label12.Visible = false;
                label13.Visible = false;
            }

            if (textBox2.Text == "NOAR")
            {
                label11.Visible = true;
            }
            else
            {
                label11.Visible = false;
            }

            if (textBox2.Text == "")
            {
                label14.Visible = true;
            }
            else
            {
                label14.Visible = false;
            }

            if (textBox6.Text == "")
            {
                label17.Visible = true;
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            if (textBox5.Text == "")
            {
                label10.Visible = false;
                label13.Visible = true;
                //label20.Visible = true;
            }
            if (textBox5.Text == "" && textBox2.Text == "")
            {
                label13.Visible = true;
                label12.Visible = false;
                //label20.Visible = true;
            }

            if (textBox5.Text == textBox2.Text)
            {
                label12.Visible = true;
                label20.Visible = false;
            }
            else
            {
                label10.Visible = true;
                label12.Visible = false;
                label13.Visible = false;
            }

            if (textBox5.Text != textBox2.Text)
            {
                label10.Visible = true;
            }
            else
            {
                label12.Visible = true;
                label10.Visible = false;
                label13.Visible = false;
            }

            
            if (textBox6.Text == "")
            {
                label17.Visible = true;
            }

            
        }

        private void MudarLogSen_Load(object sender, EventArgs e)
        {
            label12.Visible = false;
            label11.Visible = false;
            label10.Visible = false;
            label9.Visible = false;
            label17.Visible = false;

        }
        

        private void simpleButton1_Click(object sender, EventArgs e)
        {

            if (textBox1.Text.Any(ch => char.IsUpper(ch)) && textBox1.Text.Any(ch => char.IsLower(ch)) && textBox2.Text.Any(ch => char.IsUpper(ch)) && textBox2.Text.Any(ch => char.IsLower(ch)))
            {

            }
            else
            {
                label18.Visible = true;
                    //MessageBox.Show("Letra Maiúscula e Minúscula obrigatório em Login e Senha!");
            }
            textBox6.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;

            if (textBox1.Text == "" || textBox2.Text == "" || textBox5.Text == "" || textBox6.Text == "")
                {


                if (textBox6.Text == "")
                    {
                        label17.Visible = true;
                    }


                    if (textBox1.Text == "")
                    {
                        label15.Visible = true;
                }


                if (textBox2.Text == "")
                    {
                        label14.Visible = true;
                    label12.Visible = false;
                }

                if (textBox5.Text == "")
                {
                    label20.Visible = false;
                    label13.Visible = true;
                }

                if (textBox2.Text == "" && textBox5.Text == "")
                    {
                    //label10.Visible = false;
                    label20.Visible = false;
                    label12.Visible = false;
                    }


                if (textBox5.Text != textBox2.Text)
                {
                    label10.Visible = true;
                    label13.Visible = true;
                }

                label19.Visible = true;
                    //MessageBox.Show("Campos Obrigatórios * ");
                }
                else
                {
                    //////////////////////////////////////////////////////////
                    SqlCommand COC = new SqlCommand();
                    SqlCommand COC1 = new SqlCommand();
                    SqlConnection AAAA = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\USERS\THIAGO KOSHIBA\DESKTOP\WINDOWSFORMSAPPLICATION2\BANCO.MDF;Integrated Security=True;Connect Timeout=30");
                    ChangeInBDcs changePass = new ChangeInBDcs();
                    string strCmd22 = "update CAD set Senha='" + textBox5.Text + "' where Rg='" + textBox7.Text + "'";
                    string strCmd23 = "update CAD set Login='" + textBox1.Text + "' where Rg='" + textBox7.Text + "'";
                    if (changePass.login(textBox7.Text, textBox4.Text) == true)
                    {
                        if (textBox2.Text == textBox5.Text)
                        {
                            try
                            {
                                AAAA.Open();
                                COC.Connection = AAAA;
                                COC1.Connection = AAAA;
                                COC.CommandText = strCmd22;
                                COC1.CommandText = strCmd23;
                                COC.ExecuteNonQuery();
                                COC1.ExecuteNonQuery();

                                this.Hide();
                                Form1 ss = new Form1();
                                ss.Show();


                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.ToString());
                            }
                        }
                        else
                        {
                            //MessageBox.Show("/////////////////");

                        }
                    }

                }
            

        }

        private void textBox6_MaskChanged(object sender, EventArgs e)
        {
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            if (textBox6.Text == "")
            {
                label17.Visible = true;
            }
            else
            {
                label17.Visible = false;
            }
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            textBox6.Text = textBox7.Text;
        }

        private void textBox6_Leave(object sender, EventArgs e)
        {
            textBox7.Text = textBox6.Text;
        }

        private void textBox7_Enter(object sender, EventArgs e)
        {
            textBox7.Text = textBox6.Text;
        }
    }
    
}