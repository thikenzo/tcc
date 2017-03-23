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
    public partial class InstruLista : Form
    {
        public InstruLista()
        {
            InitializeComponent();

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();

            MenuADM ss = new MenuADM();
            ss.Show();
        }

        private void btnAgenda_Click(object sender, EventArgs e)
        {
            this.Hide();
            AgendaServico ss = new AgendaServico();
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
    }
}