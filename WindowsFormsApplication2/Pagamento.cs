using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Pagamento : Form
    {
        public Pagamento()
        {
            InitializeComponent();

            this.Height = 670; //altura
            this.Width = 970; //largura
        }

        public Pagamento(string texto, string total)
        {
            InitializeComponent();
            nomecliente.Text = texto;
            label15.Text = total;
            label14.Text = total;
            label12.Text = total;
        }
        

        private void Pagamento_Load(object sender, EventArgs e)
        {
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
                label24.Text = (N1/ 2) + "";
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
            calcula();
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
            else {
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
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            

            radioPrazo.Enabled = true;
            radioVista.Enabled = true;
            label23.Visible = false;

            if (radioPrazo.Checked)
            {
                comboBox1.Enabled = true;

               // NpgsqlCommand cmd10 = new NpgsqlCommand("INSERT INTO visual_acuity (eid, corrected, is_left_eye, value) VALUES (@eid, @corrected, @is_left_eye, @value)", conn);
                //cmd10.Parameters.AddWithValue("@is_left_eye", radioButton2.Checked);
                //cmd10.Parameters.AddWithValue("@corrected", radioButton4.Checked);
                //cmd10.ExecuteNonQuery();
            }

        }

        private void radioPrazo_CheckedChanged(object sender, EventArgs e)
        {
            if (radioPrazo.Checked)
            {
                comboBox1.Enabled = true;

                // NpgsqlCommand cmd10 = new NpgsqlCommand("INSERT INTO visual_acuity (eid, corrected, is_left_eye, value) VALUES (@eid, @corrected, @is_left_eye, @value)", conn);
                //cmd10.Parameters.AddWithValue("@is_left_eye", radioButton2.Checked);
                //cmd10.Parameters.AddWithValue("@corrected", radioButton4.Checked);
                //cmd10.ExecuteNonQuery();

               


            }





        }

        private void radioVista_CheckedChanged(object sender, EventArgs e)
        {
            label23.Text = "";
            comboBox1.Enabled = false;
            label23.Visible = false;
        }
    }
}
