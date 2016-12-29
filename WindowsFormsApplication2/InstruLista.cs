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

            LocInstrum ss = new LocInstrum();
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

        private void btnAdicina_Click(object sender, EventArgs e)
        {
            List<object> destList = new List<object>();
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                destList.Add(row.DataBoundItem);
            dataGridView2.DataSource = destList;
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {

        }


        private void InstruLista_Load(object sender, EventArgs e)
        {
            // create a text columns
            //DataGridViewTextBoxColumn dgvcId = new DataGridViewTextBoxColumn();
            //dgvcId.HeaderText = "Id";
            //DataGridViewTextBoxColumn dgvcFn = new DataGridViewTextBoxColumn();
            //dgvcFn.HeaderText = "First Name";
            //DataGridViewTextBoxColumn dgvcLn = new DataGridViewTextBoxColumn();
            //dgvcLn.HeaderText = "Last Name";

            // create checkbox column
            DataGridViewCheckBoxColumn dgvcCheckBox = new DataGridViewCheckBoxColumn();
            dgvcCheckBox.HeaderText = "Selecionar";

            // add columns to datagridview

           dataGridView1.Columns.Add(dgvcCheckBox);

            // add some row to datagridview
            // true the checkBox Is checked
            // false the checkBox Is Not checked

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AllowUserToAddRows = false;


            // create checkbox column
            DataGridViewCheckBoxColumn dgvcCheckBox1 = new DataGridViewCheckBoxColumn();
            dgvcCheckBox.HeaderText = "Selecionar";

            // columns for dataGridView2
            //DataGridViewTextBoxColumn dgvcId2 = new DataGridViewTextBoxColumn();
            //dgvcId2.HeaderText = "Id";
            //DataGridViewTextBoxColumn dgvcFn2 = new DataGridViewTextBoxColumn();
            //dgvcFn2.HeaderText = "First Name";
            //DataGridViewTextBoxColumn dgvcLn2 = new DataGridViewTextBoxColumn();
            //dgvcLn2.HeaderText = "Last Name";
            //dataGridView2.Columns.Add(dgvcId2);
            //dataGridView2.Columns.Add(dgvcFn2);
            //dataGridView2.Columns.Add(dgvcLn2);
            dataGridView2.Columns.Add(dgvcCheckBox1);
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            //dataGridView2.AllowUserToAddRows = false;
        }

        

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (this.dataGridView2.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow item in this.dataGridView2.SelectedRows)
                {
                    //dataGridView2.Rows.RemoveAt(dataGridView2.CurrentRow.Index);
                    dataGridView2.Rows.Remove(item);
                    //dataGridView2.Rows.RemoveAt(item.Index);
                }
            }
        }

        private void dataGridView2_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //funciona
            //textBox1.Text = dataGridView2.SelectedRows[0].Cells["NomeEquip"].Value.ToString();

            //textBox1.Text = dataGridView2.SelectedRows[0].Cells["NomeEquip"].Value.ToString();
            //label2.Text = dataGridView2.SelectedRows[0].Cells["Tipo"].Value.ToString();


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sum = 0;
            for (int i = 0; i < dataGridView2.Rows.Count; ++i)
            {
                sum += Convert.ToInt32(dataGridView2.Rows[i].Cells[3].Value);
            }
            textBox1.Text = sum.ToString();
        }

      
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
