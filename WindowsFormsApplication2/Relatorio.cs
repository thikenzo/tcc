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
using System.Windows.Forms.DataVisualization.Charting;
using System.Data.OleDb;

using System.Configuration;
using System.Diagnostics;
using System.Globalization;

using System.Data.SqlTypes;
using Microsoft.SqlServer.Server;


namespace WindowsFormsApplication2
{
    public partial class Relatorio : XtraForm
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\USERS\THIAGO KOSHIBA\DESKTOP\WINDOWSFORMSAPPLICATION2\BANCO.MDF;Integrated Security=True;Connect Timeout=30");


        public Relatorio()
        {
            InitializeComponent();

            this.Height = 650; //altura
            this.Width = 870; //largura
            DevExpress.Skins.SkinManager.EnableFormSkins();
            DevExpress.UserSkins.BonusSkins.Register();

            comboBox1.Visible = false;
            label1.Visible = false;
            dataGridView1.Visible = false;
            simpleButton3.Visible = false;
            chartControl1.Visible = false;
            chartControl2.Visible = false;
            chartControl3.Visible = false;

            simpleButton1.Visible = false;
            comboBox2.Visible = false;
            label3.Visible = false;
        }


        private void Relatorio_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bancoDataSet2.Graph2'. Você pode movê-la ou removê-la conforme necessário.
            //this.graph2TableAdapter.Fill(this.bancoDataSet2.Graph2);
            // TODO: esta linha de código carrega dados na tabela 'bancoDataSet1.Graph1'. Você pode movê-la ou removê-la conforme necessário.
            //this.graph1TableAdapter.Fill(this.bancoDataSet1.Graph1);
            // TODO: esta linha de código carrega dados na tabela 'bancoDataSet.Graph'. Você pode movê-la ou removê-la conforme necessário.
            //this.graphTableAdapter.Fill(this.bancoDataSet.Graph);

            comboBox1.Items.Add(new Item("1", "Janeiro"));
            comboBox1.Items.Add(new Item("2", "Fevereiro"));
            comboBox1.Items.Add(new Item("3", "Março"));
            comboBox1.Items.Add(new Item("4", "Abril"));
            comboBox1.Items.Add(new Item("5", "Maio"));
            comboBox1.Items.Add(new Item("6", "Junho"));
            comboBox1.Items.Add(new Item("7", "Julho"));
            comboBox1.Items.Add(new Item("8", "Agosto"));
            comboBox1.Items.Add(new Item("9", "Setembro"));
            comboBox1.Items.Add(new Item("10", "Outubro"));
            comboBox1.Items.Add(new Item("11", "Novembro"));
            comboBox1.Items.Add(new Item("12", "Dezembro"));

            comboBox1.SelectedIndexChanged += new EventHandler(comboBox1_SelectedIndexChanged);


        }


        private void servico_Enter(object sender, EventArgs e)
        {
        }

        private void servico_SelectedIndexChanged(object sender, EventArgs e)
        {
            label10.Text = servico.SelectedItem.ToString();




            servico.Text = "";

            if (servico.SelectedIndex == 1)//equip
            {
                comboBox1.Visible = true;
                label1.Visible = true;
                simpleButton2.Visible = false;
                simpleButton3.Visible = true;
                comboBox2.Visible = true;
                label3.Visible = true;
                dataGridView1.Visible = false;
                simpleButton1.Visible = false;
                chartControl1.Visible = false;
            }
            if (servico.SelectedIndex == 2)//sala
            {

                comboBox1.Visible = true;
                label1.Visible = true;
                simpleButton2.Visible = false;
                simpleButton3.Visible = true;
                comboBox2.Visible = true;
                label3.Visible = true;

                dataGridView1.Visible = false;
                simpleButton1.Visible = false;
                chartControl2.Visible = false;
            }
            if (servico.SelectedIndex == 3)
            {
                comboBox1.Visible = true;
                label1.Visible = true;
                simpleButton2.Visible = false;
                simpleButton3.Visible = true;
                comboBox2.Visible = true;
                label3.Visible = true;
                dataGridView1.Visible = false;
                simpleButton1.Visible = false;
                chartControl2.Visible = false;
            }

            if (servico.SelectedIndex == 0)//agendamento
            {
                comboBox2.Visible = false;
                comboBox1.Visible = false;
                simpleButton3.Visible = false;
                comboBox2.Visible = false;
                label3.Visible = false;
                label1.Visible = false;
                simpleButton2.Visible = true;
                chartControl1.Visible = false;
                chartControl2.Visible = false;
                chartControl3.Visible = false;
            }


        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();

            MenuADM ss = new MenuADM();
            ss.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
        }

        public Relat RelatSelecionado { get; set; }

        private void simpleButton1_Click(object sender, EventArgs e)
        {

            {
                if (dataGridView1.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Não se pode excluir, nenhum agendamento selecionado!");
                }
                else

                {
                    Int64 Id = Convert.ToInt64(dataGridView1.CurrentRow.Cells[0].Value);
                    RelatSelecionado = RelatFunc.Obteragen(Id);

                    if (MessageBox.Show("Tem certeza que deseja exluir o Agendamento??", "Tem certeza?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {

                        int resultado = RelatFunc.Excluir1(RelatSelecionado.Id);

                        if (resultado > 0)
                        {

                            MessageBox.Show("Agendamento excluído com sucesso!", "Pessoa Excluído", MessageBoxButtons.OK);

                        }

                        else
                        {
                            MessageBox.Show("Não se pode excluir o agendamento, ocorreu um erro!!");
                        }

                    }
                    else
                        MessageBox.Show("Você cancelou a exclusão!", "Cancelado");
                }
            }
        }

        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dataGridView1.ClearSelection();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            if (servico.SelectedIndex == 0)
            {
                comboBox1.Visible = false;
                label1.Visible = false;
                dataGridView1.Visible = true;
                simpleButton1.Visible = true;
            }
            if (servico.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione um tipo de relatorio.");
            }



            dataGridView1.DataSource = RelatFunc.BuscarAgenda(servico.SelectedIndex);
            this.dataGridView1.Columns["Id"].Visible = false;
        }



        private void simpleButton3_Click(object sender, EventArgs e)
        {

            if (label10.Text == "Sala")
            {
                if (comboBox2.SelectedIndex == -1 && comboBox1.SelectedIndex == -1 && servico.SelectedIndex == 2)
            {
                MessageBox.Show("Selecione um mes e um ano.");
            }
            else
            {
                if (comboBox1.SelectedIndex == -1 && comboBox2.SelectedIndex != -1 && servico.SelectedIndex == 2)
                {
                    MessageBox.Show("Selecione um mes.");
                }
                else
                {
                    if (comboBox2.SelectedIndex == -1 && comboBox1.SelectedIndex != -1 && servico.SelectedIndex == 2)
                    {
                        MessageBox.Show("Selecione um ano.");
                    }
                    else
                    {
                        contSala();
                        //chartControl2.Visible = false;


                    }
                }
            }
        }

            /////////
            if (label10.Text == "Instrumento")
            {
                if (comboBox2.SelectedIndex == -1 && comboBox1.SelectedIndex == -1)
                {
                    MessageBox.Show("Selecione um mes e um ano.");
                }
                else
                {
                    if (comboBox1.SelectedIndex == -1 && comboBox2.SelectedIndex != -1)
                    {
                        MessageBox.Show("Selecione um mes.");
                    }
                    else
                    {
                        if (comboBox2.SelectedIndex == -1 && comboBox1.SelectedIndex != -1)
                        {
                            MessageBox.Show("Selecione um ano.");
                        }
                        else
                        {
                            contEquip();
                            //chartControl1.Visible = false;

                        }
                    }
                }

            }
            

                            if (label10.Text == "Serviço")
            {
                if (comboBox2.SelectedIndex == -1 && comboBox1.SelectedIndex == -1)
                {
                    MessageBox.Show("Selecione um mes e um ano.");
                }
                else
                {
                    if (comboBox1.SelectedIndex == -1 && comboBox2.SelectedIndex != -1)
                    {
                        MessageBox.Show("Selecione um mes.");
                    }
                    else
                    {
                        if (comboBox2.SelectedIndex == -1 && comboBox1.SelectedIndex != -1)
                        {
                            MessageBox.Show("Selecione um ano.");
                        }
                        else
                        {
                            contServico();
                            //chartControl1.Visible = false;

                        }
                    }
                }

            }



        }



        public void contSala()
        { 
        
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\USERS\THIAGO KOSHIBA\DESKTOP\WINDOWSFORMSAPPLICATION2\BANCO.MDF;Integrated Security=True;Connect Timeout=30");
            

            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.Connection = con;
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "SELECT Sala, Count(Sala) FROM Agenda where Data like '%/" + label4.Text + '/' + comboBox2.Text + "' group by Sala";


            SqlDataAdapter sqlDataAdap = new SqlDataAdapter(sqlCmd);
            DataTable dtRecord = new DataTable();
            sqlDataAdap.Fill(dtRecord);
            dataGridView2.DataSource = dtRecord;
            
            for (int i = 0; i < dataGridView2.Rows.Count; i++)
            {
                
                SqlCommand cmd = new SqlCommand("INSERT INTO Graph (Sala, Column1) values (@Sala,@Column1)", con);
                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@Sala", dataGridView2.Rows[i].Cells[0].Value.ToString());
                cmd.Parameters.AddWithValue("@Column1", Convert.ToDouble(dataGridView2.Rows[i].Cells[1].Value));
                con.Open();
                cmd.ExecuteNonQuery();
                this.graphTableAdapter.Fill(this.bancoDataSet.Graph);


                label9.Visible = false;
                chartControl2.Visible = false;
                chartControl3.Visible = false;
                chartControl1.Visible = true;
                con.Close();




            }
            for (int i1 = 0; i1 == dataGridView2.RowCount; i1++)
            {
                chartControl2.Visible = false;
                chartControl1.Visible = true;
                this.graphTableAdapter.Fill(this.bancoDataSet.Graph);
                chartControl1.Controls.Clear();
                chartControl3.Visible = false;
                label9.Visible = true;
                
                
            }


        }

        public void contEquip()
        {

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\USERS\THIAGO KOSHIBA\DESKTOP\WINDOWSFORMSAPPLICATION2\BANCO.MDF;Integrated Security=True;Connect Timeout=30");


            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.Connection = con;
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "SELECT NomeEquip, Count(NomeEquip) FROM InstruSelec where Data like '%/" + label4.Text + '/' + comboBox2.Text + "' group by NomeEquip";


            SqlDataAdapter sqlDataAdap = new SqlDataAdapter(sqlCmd);
            DataTable dtRecord = new DataTable();
            sqlDataAdap.Fill(dtRecord);
            dataGridView2.DataSource = dtRecord;

            for (int i = 0; i < dataGridView2.Rows.Count; i++)
            {

                SqlCommand cmd = new SqlCommand("INSERT INTO Graph1 (Equip, Column1) values (@Equip,@Column1)", con);
                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@Equip", dataGridView2.Rows[i].Cells[0].Value.ToString());
                cmd.Parameters.AddWithValue("@Column1", Convert.ToDouble(dataGridView2.Rows[i].Cells[1].Value));
                con.Open();
                cmd.ExecuteNonQuery();
                this.graph1TableAdapter.Fill(this.bancoDataSet1.Graph1);


                label12.Visible = false;
                chartControl2.Visible = true;
                chartControl3.Visible = false;
                chartControl1.Visible = false;
                con.Close();




            }
            for (int i1 = 0; i1 == dataGridView2.RowCount; i1++)
            {
                chartControl2.Visible = true;
                chartControl1.Visible = false;
                this.graph1TableAdapter.Fill(this.bancoDataSet1.Graph1);
                chartControl2.Controls.Clear();
                chartControl3.Visible = false;
                label12.Visible = true;


            }


        }

        public void contServico()
        {

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\USERS\THIAGO KOSHIBA\DESKTOP\WINDOWSFORMSAPPLICATION2\BANCO.MDF;Integrated Security=True;Connect Timeout=30");


            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.Connection = con;
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "SELECT Servico, Count(Servico) FROM Agenda where Data like '%/" + label4.Text + '/' + comboBox2.Text + "' group by Servico";


            SqlDataAdapter sqlDataAdap = new SqlDataAdapter(sqlCmd);
            DataTable dtRecord = new DataTable();
            sqlDataAdap.Fill(dtRecord);
            dataGridView2.DataSource = dtRecord;

            for (int i = 0; i < dataGridView2.Rows.Count; i++)
            {

                SqlCommand cmd = new SqlCommand("INSERT INTO Graph2 (Servico, Column1) values (@Servico,@Column1)", con);
                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@Servico", dataGridView2.Rows[i].Cells[0].Value.ToString());
                cmd.Parameters.AddWithValue("@Column1", Convert.ToDouble(dataGridView2.Rows[i].Cells[1].Value));
                con.Open();
                cmd.ExecuteNonQuery();
                this.graph2TableAdapter.Fill(this.bancoDataSet2.Graph2);


                label11.Visible = false;
                chartControl2.Visible = false;
                chartControl1.Visible = false;
                chartControl3.Visible = true;
                con.Close();




            }
            for (int i1 = 0; i1 == dataGridView2.RowCount; i1++)
            {
                chartControl2.Visible = false;
                chartControl1.Visible = false;
                chartControl3.Visible = true;
                this.graph2TableAdapter.Fill(this.bancoDataSet2.Graph2);
                chartControl3.Controls.Clear();

                label11.Visible = true;


            }


        }



        public class Item
        {
            public Item(string value, string text) { Value = value; Text = text; }
            public string Value { get; set; }
            public string Text { get; set; }

            public override string ToString() { return Text; }
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Item item = comboBox1.Items[comboBox1.SelectedIndex] as Item;
            label4.Text = item.Value.ToString();
            label14.Text = comboBox2.Text;


            label8.Text = comboBox1.SelectedItem.ToString();

            if (label10.Text == "Instrumento")
            {
                if (label8.Text != label4.Text || label13.Text != label14.Text)
                {
                    //chartControl1.Visible = false;

                    SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\USERS\THIAGO KOSHIBA\DESKTOP\WINDOWSFORMSAPPLICATION2\BANCO.MDF;Integrated Security=True;Connect Timeout=30");
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = "DELETE FROM Graph1 ";

                    cmd.Connection = con;
                    con.Open();
                    cmd.ExecuteNonQuery();


                    con.Close();
                }
            }

            if (label10.Text == "Sala")
            {
                if (label8.Text != label4.Text || label13.Text != label14.Text)
                {
                    //chartControl1.Visible = false;

                    SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\USERS\THIAGO KOSHIBA\DESKTOP\WINDOWSFORMSAPPLICATION2\BANCO.MDF;Integrated Security=True;Connect Timeout=30");
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = "DELETE FROM Graph ";

                    cmd.Connection = con;
                    con.Open();
                    cmd.ExecuteNonQuery();


                    con.Close();
                }
            }

            if (label10.Text == "Serviço")
            {
                if (label8.Text != label4.Text || label13.Text != label14.Text)
                {
                    //chartControl1.Visible = false;

                    SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\USERS\THIAGO KOSHIBA\DESKTOP\WINDOWSFORMSAPPLICATION2\BANCO.MDF;Integrated Security=True;Connect Timeout=30");
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = "DELETE FROM Graph2 ";

                    cmd.Connection = con;
                    con.Open();
                    cmd.ExecuteNonQuery();


                    con.Close();
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            

            
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void chartControl1_TextChanged(object sender, EventArgs e)
        {
        }

 
    }
}
