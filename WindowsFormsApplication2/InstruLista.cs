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
    public partial class InstruLista : XtraForm
    {



        public InstruLista()
        {
            InitializeComponent();
            this.Height = 670; //altura
            this.Width = 880; //largura

            DevExpress.Skins.SkinManager.EnableFormSkins();
            DevExpress.UserSkins.BonusSkins.Register();
        }

        public InstruLista(string texto, string label22, string hora, string valor, string desc, string proj, string projcom, string sal)
        {
            InitializeComponent();

            label4.Text = texto;
            label5.Text = label22;
            label6.Text = hora;
            label7.Text = valor;
            label9.Text = desc;
            label10.Text = proj;
            label11.Text = projcom;
            label12.Text = sal;

        }

        private void btnAgenda_Click(object sender, EventArgs e)
        {
            this.Hide();
            AgendaServico ss = new AgendaServico(label4.Text, label6.Text, label5.Text, label7.Text, label9.Text, label10.Text, label11.Text, label12.Text);
            ss.Show();

   

            }

        private void btnInternacional_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = InstrumFunc.BuscarEquip1(btnInternacional.Text);
        }

        private void btnNacional_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = InstrumFunc.BuscarEquip2(btnNacional.Text);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (this.dataGridView2.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow item in this.dataGridView2.SelectedRows)
                {
                    dataGridView2.Rows.Remove(item);
                }

            }
            else
            {
                MessageBox.Show(" Nenhuma linha selecionada!", "NOAR ", MessageBoxButtons.OK);
            }
        }

        private void InstruLista_Load(object sender, EventArgs e)
        {
            this.Height = 670; //altura
            this.Width = 880; //largura

            //label4.Visible = false;
            //label5.Visible = false;
            //label6.Visible = false;
            //label7.Visible = false;


            // add some row to datagridview
            // true the checkBox Is checked
            // false the checkBox Is Not checked
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AllowUserToAddRows = false;


            // columns for dataGridView2
            DataGridViewTextBoxColumn dgvcId2 = new DataGridViewTextBoxColumn();
            dgvcId2.HeaderText = "Nome Equipamento";
            DataGridViewTextBoxColumn dgvcFn2 = new DataGridViewTextBoxColumn();
            dgvcFn2.HeaderText = "Tipo";
            DataGridViewTextBoxColumn dgvcLn2 = new DataGridViewTextBoxColumn();
            dgvcLn2.HeaderText = "Valor";
            dataGridView2.Columns.Add(dgvcId2);
            dataGridView2.Columns.Add(dgvcFn2);
            dataGridView2.Columns.Add(dgvcLn2);
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.AllowUserToAddRows = false;
        }

        private void btnAdicina_Click(object sender, EventArgs e)
        {
            // loop to check if the checkbox cell is checked
            for (int i = 0; i <= dataGridView1.Rows.Count - 1; i++)
            {
                // rowAlreadyExist => if the row already exist on dataGridView2
                bool rowAlreadyExist = false;
                bool checkedCell = (bool)dataGridView1.Rows[i].Selected;
                if (checkedCell == true)
                {
                    DataGridViewRow row = dataGridView1.Rows[i];

                    // the dataGridView2 have one row or more
                    if (dataGridView2.Rows.Count != 0)
                    {
                        // loop to see if the row already exist on dataGridView2
                        for (int j = 0; j <= dataGridView2.Rows.Count - 1; j++)
                        {
                            if (row.Cells[0].Value.ToString() == dataGridView2.Rows[j].Cells[0].Value.ToString())
                            {
                                rowAlreadyExist = true;
                                break;
                            }
                        }

                        // add if the row ont exist on dataGridView2
                        if (rowAlreadyExist == false)
                        {
                            dataGridView2.Rows.Add(row.Cells[0].Value.ToString(),
                                                   row.Cells[1].Value.ToString(),
                                                   row.Cells[2].Value.ToString()
                                                   );
                        }
                    }

                    // add if the dataGridView2 have no row 
                    else
                    {
                        dataGridView2.Rows.Add(row.Cells[0].Value.ToString(),
                                                   row.Cells[1].Value.ToString(),
                                                   row.Cells[2].Value.ToString()
                                                   );
                    }


                }

            }
        }

        private void Calcular()
        {
            if (dataGridView2.Rows.Count > 0 && dataGridView2.Rows[0].Cells.Count < 2) return;

            int sum = 0;
            for (int i = 0; i < dataGridView2.Rows.Count; i++)
            {
                sum += Convert.ToInt32(dataGridView2.Rows[i].Cells[2].Value);
            }

            label2.Text = sum.ToString();
        }

        private void dataGridView2_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            Calcular();
        }

        private void dataGridView2_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            Calcular();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void btnProximo_Click(object sender, EventArgs e)
        {
            if (dataGridView2.RowCount == 0)
            {
                MessageBox.Show("Necessário escolher algum instrumneto!");
            }
            else
            {

                for (int i = 0; i < dataGridView2.Rows.Count; i++)
                {
                    //InstruSele Agend = new InstruSele();
                    //Agend.Nome = label5.Text;
                    //Agend.Data = label4.Text;
                    //int resultado = InstruSeleFunc.btnIntru(Agend);

                    SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\USERS\THIAGO KOSHIBA\DESKTOP\WINDOWSFORMSAPPLICATION2\BANCO.MDF;Integrated Security=True;Connect Timeout=30");
                    SqlCommand cmd = new SqlCommand("INSERT INTO InstruSelec (Nome, Data, Hora, NomeEquip,Tipo,Valor) values (@Nome, @Data, @Hora, @NomeEquip, @Tipo,@valor)", con);

                    cmd.Parameters.AddWithValue("@Nome", label5.Text);
                    cmd.Parameters.AddWithValue("@Data", label4.Text);
                    cmd.Parameters.AddWithValue("@Hora", label6.Text);
                    cmd.Parameters.AddWithValue("@NomeEquip", dataGridView2.Rows[i].Cells[0].Value);
                    cmd.Parameters.AddWithValue("@Tipo", dataGridView2.Rows[i].Cells[1].Value);
                    cmd.Parameters.AddWithValue("@Valor", dataGridView2.Rows[i].Cells[2].Value);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();

                    label8.Text = (Convert.ToDecimal(label7.Text) + Convert.ToDecimal(label2.Text)).ToString();
                }



                Agend Agend = new Agend();
                Agend.Data = label4.Text;
                Agend.Hora = label6.Text;
                Agend.Cliente = label5.Text;
                Agend.Projeto = label10.Text;
                Agend.Servico = label11.Text;
                Agend.Sala = label12.Text;
                Agend.Descricao = label9.Text;

                int resultado = AgendFunc.btnInstrum(Agend);
                
                if (resultado > 0)
                {
                    this.Hide();
                    Pagamento novaForm = new Pagamento(label5.Text, label8.Text, label4.Text, label6.Text);
                    novaForm.Show();
                }


            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dataGridView1.ClearSelection();
        }

        private void dataGridView2_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dataGridView2.ClearSelection();
        }







        /*

        public void SalvarDados()
        {
            try
            {
                if (dataGridView2.Rows.Count > 1)
                {
                    for (int i = 0; i <= dataGridView2.Rows.Count - 1; i++)
                    {
                        //int col1 = Convert.ToInt32(dataGridView2.Rows[i].Cells[0].Value); //id
                        string col2 = dataGridView2.Rows[i].Cells[0].Value.ToString(); //Descricao 
                        string col3 = dataGridView2.Rows[i].Cells[1].Value.ToString(); //Quantidade
                        string col4 = dataGridView2.Rows[i].Cells[2].Value.ToString();

                        using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings[dataGridView2.ToString()].ConnectionString))
                        {
                            string insert = "INSERT INTO IntruSele (NomeEquip, Tipo, Valor) VALUES (@NomeEquip, @Tipo, @Valor)";
                            con.Open();
                            SqlCommand cmd = new SqlCommand(insert, con);
                            //cmd.Parameters.AddWithValue("@Id", col1);
                            cmd.Parameters.AddWithValue("@NomeEquip", col2);
                            cmd.Parameters.AddWithValue("@Tipo", col3);
                            cmd.Parameters.AddWithValue("@Valor", col4);
                            cmd.ExecuteNonQuery();
                            con.Close();
                        }
                    }
                }
                MessageBox.Show("Dados incluídos com sucesso !!", "Inclusão", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                ex.Message.ToString();
            }
        }



    */

    }
}