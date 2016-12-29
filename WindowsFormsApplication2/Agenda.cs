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

namespace WindowsFormsApplication2
{
    public partial class Agenda : Form
    {
        public Agenda()
        {
            InitializeComponent();

        }
   

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        
        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
             groupBox1.Visible = true;

            groupBox1.Text = "Agenda - " + monthCalendar1.SelectionStart.Day.ToString()+"/"+
                monthCalendar1.SelectionStart.Month.ToString() + "/" +
                monthCalendar1.SelectionStart.Year.ToString(); 

            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)   
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
           
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            this.Hide();

            MainADM ss = new MainADM();
            ss.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

             AgendaServico destino = new AgendaServico(monthCalendar1.SelectionStart.Day.ToString()
             + "/" +monthCalendar1.SelectionStart.Month.ToString() + "/" +
             monthCalendar1.SelectionStart.Year.ToString());
             destino.Show();
            
        }

        private void Agenda_Load(object sender, EventArgs e)
        {

        }
    }
}
