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
    public partial class Agenda : XtraForm
    {
        public Agenda()
        {
            InitializeComponent();
            DevExpress.Skins.SkinManager.EnableFormSkins();
            DevExpress.UserSkins.BonusSkins.Register();


            this.Height = 745; //altura
            this.Width = 870; //largura

        }

        public class BDComun
        {
            public static SqlConnection ObterConexao()
            {
                SqlConnection Conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\USERS\THIAGO KOSHIBA\DESKTOP\WINDOWSFORMSAPPLICATION2\BANCO.MDF;Integrated Security=True;Connect Timeout=30");

                Conn.Open();

                return Conn;

            }


        }






        //monthcalendar
        /*
        private void calendarControl1_DateChanged(object sender, DateRangeEventArgs e)
        {

            label23.Visible = true;
            label22.Visible = true;
            label22.Text = calendarControl1.SelectionStart.Day.ToString() + "/" +
                 calendarControl1.SelectionStart.Month.ToString() + "/" +
                calendarControl1.SelectionStart.Year.ToString();

            String dataAgendamento = calendarControl1.SelectionStart.Day.ToString() + "/" +
                calendarControl1.SelectionStart.Month.ToString() + "/" +
                calendarControl1.SelectionStart.Year.ToString();
           

            groupBox2.Visible = true;
            groupBox2.Text = "";
            label12.Text = "09:00";

            label14.Text = "Horário Disponível";
            button1.Text = "AGENDAR";
            button1.Enabled = true;

            Console.WriteLine(dataAgendamento);

            List<Agend> listaAgendamento = BuscarAgenda(dataAgendamento);

            Console.WriteLine(dataAgendamento);
            
            foreach (var agendamento in listaAgendamento)      
            {
                label22.Text = calendarControl1.SelectionStart.Day.ToString() + "/" +
                     calendarControl1.SelectionStart.Month.ToString() + "/" +
                    calendarControl1.SelectionStart.Year.ToString();

                Console.WriteLine(agendamento.Id);
                if (agendamento.Hora.Equals("09:00"))
                {
                    label14.Text = agendamento.Projeto;

                    button1.Text = "OCUPADO";
                    button1.Enabled = false;
                }

            }
            /////////////////////////////////////////
            String dataAgendamento1 = calendarControl1.SelectionStart.Day.ToString() + "/" +
     calendarControl1.SelectionStart.Month.ToString() + "/" +
     calendarControl1.SelectionStart.Year.ToString();
            

            groupBox1.Visible = true;
            groupBox1.Text = "";
            label1.Text = "10:00";

            label2.Text = "Horário Disponível";
            button2.Text = "AGENDAR";
            button2.Enabled = true;

            Console.WriteLine(dataAgendamento);

            foreach (var agendamento in listaAgendamento)
            {

                Console.WriteLine(agendamento.Id);
                if (agendamento.Hora.Equals("10:00"))
                {
                    label2.Text = agendamento.Projeto;

                    button2.Text = "OCUPADO";
                    button2.Enabled = false;
                }

            }

            /////////////////////////////////////////
            String dataAgendamento12 = calendarControl1.SelectionStart.Day.ToString() + "/" +
     calendarControl1.SelectionStart.Month.ToString() + "/" +
     calendarControl1.SelectionStart.Year.ToString();
            

            groupBox3.Visible = true;
            groupBox3.Text = "";
            label3.Text = "11:00";

            label4.Text = "Horário Disponível";
            button3.Text = "AGENDAR";
            button3.Enabled = true;

            Console.WriteLine(dataAgendamento);

            foreach (var agendamento in listaAgendamento)
            {

                Console.WriteLine(agendamento.Id);
                if (agendamento.Hora.Equals("11:00"))
                {
                    label4.Text = agendamento.Projeto;

                    button3.Text = "OCUPADO";
                    button3.Enabled = false;
                }

            }
            /////////////////////////////////////////
            String dataAgendamento123 = calendarControl1.SelectionStart.Day.ToString() + "/" +
     calendarControl1.SelectionStart.Month.ToString() + "/" +
     calendarControl1.SelectionStart.Year.ToString();

            groupBox4.Visible = true;
            groupBox4.Text = "";
            label5.Text = "12:00";

            label6.Text = "Horário Disponível";
            button4.Text = "AGENDAR";
            button4.Enabled = true;

            Console.WriteLine(dataAgendamento);
            

            foreach (var agendamento in listaAgendamento)
            {

                Console.WriteLine(agendamento.Id);
                if (agendamento.Hora.Equals("12:00"))
                {
                    label6.Text = agendamento.Projeto;

                    button4.Text = "OCUPADO";
                    button4.Enabled = false;
                }

            }
            /////////////////////////////////////////
            String dataAgendamento1234 = calendarControl1.SelectionStart.Day.ToString() + "/" +
     calendarControl1.SelectionStart.Month.ToString() + "/" +
     calendarControl1.SelectionStart.Year.ToString();

            groupBox5.Visible = true;
            groupBox5.Text = "";
            label8.Text = "13:00";

            label7.Text = "Horário Disponível";
            button5.Text = "AGENDAR";
            button5.Enabled = true;
            

            foreach (var agendamento in listaAgendamento)
            {

                Console.WriteLine(agendamento.Id);
                if (agendamento.Hora.Equals("13:00"))
                {
                    label7.Text = agendamento.Projeto;

                    button5.Text = "OCUPADO";
                    button5.Enabled = false;
                }

            }
            /////////////////////////////////////////
            String dataAgendamento12345 = calendarControl1.SelectionStart.Day.ToString() + "/" +
     calendarControl1.SelectionStart.Month.ToString() + "/" +
     calendarControl1.SelectionStart.Year.ToString();
            

            groupBox6.Visible = true;
            groupBox6.Text = "";
            label10.Text = "14:00";

            label9.Text = "Horário Disponível";
            button6.Text = "AGENDAR";
            button6.Enabled = true;
          

            foreach (var agendamento in listaAgendamento)
            {

                Console.WriteLine(agendamento.Id);
                if (agendamento.Hora.Equals("14:00"))
                {
                    label9.Text = agendamento.Projeto;

                    button6.Text = "OCUPADO";
                    button6.Enabled = false;
                }

            }
            /////////////////////////////////////////
            String dataAgendamento123456 = calendarControl1.SelectionStart.Day.ToString() + "/" +
     calendarControl1.SelectionStart.Month.ToString() + "/" +
     calendarControl1.SelectionStart.Year.ToString();

            groupBox7.Visible = true;
            groupBox7.Text = "";
            label15.Text = "15:00";

            label13.Text = "Horário Disponível";
            button7.Text = "AGENDAR";
            button7.Enabled = true;

            foreach (var agendamento in listaAgendamento)
            {

                Console.WriteLine(agendamento.Id);
                if (agendamento.Hora.Equals("15:00"))
                {
                    label13.Text = agendamento.Projeto;

                    button7.Text = "OCUPADO";
                    button7.Enabled = false;
                }

            }
            /////////////////////////////////////////
            String dataAgendamento1234567 = calendarControl1.SelectionStart.Day.ToString() + "/" +
     calendarControl1.SelectionStart.Month.ToString() + "/" +
     calendarControl1.SelectionStart.Year.ToString();
           

            groupBox8.Visible = true;
            groupBox8.Text = "";
            label17.Text = "16:00";

            label16.Text = "Horário Disponível";
            button8.Text = "AGENDAR";
            button8.Enabled = true;

            foreach (var agendamento in listaAgendamento)
            {

                Console.WriteLine(agendamento.Id);
                if (agendamento.Hora.Equals("16:00"))
                {
                    label16.Text = agendamento.Projeto;

                    button8.Text = "OCUPADO";
                    button8.Enabled = false;
                }

            }
            /////////////////////////////////////////
            String dataAgendamento12345678 = calendarControl1.SelectionStart.Day.ToString() + "/" +
     calendarControl1.SelectionStart.Month.ToString() + "/" +
     calendarControl1.SelectionStart.Year.ToString();

            groupBox9.Visible = true;
            groupBox9.Text = "";
            label19.Text = "17:00";

            label18.Text = "Horário Disponível";
            button9.Text = "AGENDAR";
            button9.Enabled = true;

            foreach (var agendamento in listaAgendamento)
            {

                Console.WriteLine(agendamento.Id);
                if (agendamento.Hora.Equals("17:00"))
                {
                    label18.Text = agendamento.Projeto;

                    button9.Text = "OCUPADO";
                    button9.Enabled = false;
                }

            }
            /////////////////////////////////////////
            String dataAgendamento123456789 = calendarControl1.SelectionStart.Day.ToString() + "/" +
     calendarControl1.SelectionStart.Month.ToString() + "/" +
     calendarControl1.SelectionStart.Year.ToString();

            groupBox10.Visible = true;
            groupBox10.Text = "";
            label21.Text = "18:00";

            label20.Text = "Horário Disponível";
            button10.Text = "AGENDAR";
            button10.Enabled = true;
            

            foreach (var agendamento in listaAgendamento)
            {

                Console.WriteLine(agendamento.Id);
                if (agendamento.Hora.Equals("18:00"))
                {
                    label20.Text = agendamento.Projeto;

                    button10.Text = "OCUPADO";
                    button10.Enabled = false;
                }

            }

        }
        
    */







        private void btnMenu_Click(object sender, EventArgs e)
        {
            this.Hide();

            MenuADM ss = new MenuADM();
            ss.Show();
        }


        private void Agenda_Load(object sender, EventArgs e)
        {
        }

        
        private static List<Agend> BuscarAgenda(String pData)
        {

            List<Agend> Lista = new List<Agend>();
            using (SqlConnection con = BDComun.ObterConexao())
            {
                SqlCommand comando = new SqlCommand(string.Format(
                    "select Id, Data, Hora, Cliente, Projeto, Servico, Sala, Descricao from Agenda where Agenda.Data = '{0}'", pData), con);

                Console.WriteLine("Data"+pData);
                Console.WriteLine(string.Format(
                    "select Id, Data, Hora, Cliente, Projeto, Servico, Sala, Descricao from Agenda where Agenda.Data = '{0}'", pData));

            
                SqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    Agend agenda = new Agend();
                    agenda.Id = reader.GetInt64(0);
                    agenda.Data = reader.GetString(1);
                    agenda.Hora = reader.GetString(2);
                    agenda.Cliente = reader.GetString(3);
                    agenda.Projeto = reader.GetString(4);
                    agenda.Servico = reader.GetString(5);
                    agenda.Sala = reader.GetString(6);
                    agenda.Descricao = reader.GetString(7);


                    Lista.Add(agenda);

                }
                con.Close();
                return Lista;

            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            
            AgendaServico novaForm = new AgendaServico(label12.Text, label22.Text, label24.Text, label25.Text, label26.Text, label27.Text, label28.Text, label29.Text);
            novaForm.Show();

        }

        

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            AgendaServico novaForm = new AgendaServico(label1.Text, label22.Text, label24.Text, label25.Text, label26.Text, label27.Text, label28.Text, label29.Text);
            novaForm.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            AgendaServico novaForm = new AgendaServico(label3.Text, label22.Text, label24.Text, label25.Text, label26.Text, label27.Text, label28.Text, label29.Text);
            novaForm.Show();

        
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            AgendaServico novaForm = new AgendaServico(label5.Text, label22.Text, label24.Text, label25.Text, label26.Text, label27.Text, label28.Text, label29.Text);
            novaForm.Show();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            AgendaServico novaForm = new AgendaServico(label8.Text, label22.Text, label24.Text, label25.Text, label26.Text, label27.Text, label28.Text, label29.Text);
            novaForm.Show();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            AgendaServico novaForm = new AgendaServico(label10.Text, label22.Text, label24.Text, label25.Text, label26.Text, label27.Text, label28.Text, label29.Text);
            novaForm.Show();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            AgendaServico novaForm = new AgendaServico(label15.Text, label22.Text, label24.Text, label25.Text, label26.Text, label27.Text, label28.Text, label29.Text);
            novaForm.Show();

        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            AgendaServico novaForm = new AgendaServico(label17.Text, label22.Text, label24.Text, label25.Text, label26.Text, label27.Text, label28.Text, label29.Text) ;
            novaForm.Show();

        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Hide();
            AgendaServico novaForm = new AgendaServico(label19.Text, label22.Text, label24.Text, label25.Text, label26.Text, label27.Text, label28.Text, label29.Text);
            novaForm.Show();

        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Hide();
            AgendaServico novaForm = new AgendaServico(label21.Text, label22.Text, label24.Text, label25.Text, label26.Text, label27.Text, label28.Text, label29.Text);
            novaForm.Show();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void calendarControl1_DateTimeChanged(object sender, EventArgs e)
        {

                {
                    label23.Visible = true;
                    label22.Visible = true;
                    label22.Text = calendarControl1.SelectionStart.Day.ToString() + "/" +
                         calendarControl1.SelectionStart.Month.ToString() + "/" +
                        calendarControl1.SelectionStart.Year.ToString();

                    String dataAgendamento = calendarControl1.SelectionStart.Day.ToString() + "/" +
                        calendarControl1.SelectionStart.Month.ToString() + "/" +
                        calendarControl1.SelectionStart.Year.ToString();


                    groupBox2.Visible = true;
                    groupBox2.Text = "";
                    label12.Text = "09:00";

                    label14.Text = "Horário Disponível";
                    button1.Text = "AGENDAR";
                    button1.Enabled = true;

                    Console.WriteLine(dataAgendamento);

                    List<Agend> listaAgendamento = BuscarAgenda(dataAgendamento);

                    Console.WriteLine(dataAgendamento);

                    foreach (var agendamento in listaAgendamento)
                    {
                        label22.Text = calendarControl1.SelectionStart.Day.ToString() + "/" +
                             calendarControl1.SelectionStart.Month.ToString() + "/" +
                            calendarControl1.SelectionStart.Year.ToString();


                        Console.WriteLine(agendamento.Id);
                        if (agendamento.Hora.Equals("09:00"))
                        {
                            label14.Text = agendamento.Projeto;

                            button1.Text = "OCUPADO";
                            button1.Enabled = false;
                        }

                    }
                    /////////////////////////////////////////
                    String dataAgendamento1 = calendarControl1.SelectionStart.Day.ToString() + "/" +
             calendarControl1.SelectionStart.Month.ToString() + "/" +
             calendarControl1.SelectionStart.Year.ToString();


                    groupBox1.Visible = true;
                    groupBox1.Text = "";
                    label1.Text = "10:00";

                    label2.Text = "Horário Disponível";
                    button2.Text = "AGENDAR";
                    button2.Enabled = true;

                    Console.WriteLine(dataAgendamento);

                    foreach (var agendamento in listaAgendamento)
                    {

                        Console.WriteLine(agendamento.Id);
                        if (agendamento.Hora.Equals("10:00"))
                        {
                            label2.Text = agendamento.Projeto;

                            button2.Text = "OCUPADO";
                            button2.Enabled = false;
                        }

                    }

                    /////////////////////////////////////////
                    String dataAgendamento12 = calendarControl1.SelectionStart.Day.ToString() + "/" +
             calendarControl1.SelectionStart.Month.ToString() + "/" +
             calendarControl1.SelectionStart.Year.ToString();


                    groupBox3.Visible = true;
                    groupBox3.Text = "";
                    label3.Text = "11:00";

                    label4.Text = "Horário Disponível";
                    button3.Text = "AGENDAR";
                    button3.Enabled = true;

                    Console.WriteLine(dataAgendamento);

                    foreach (var agendamento in listaAgendamento)
                    {

                        Console.WriteLine(agendamento.Id);
                        if (agendamento.Hora.Equals("11:00"))
                        {
                            label4.Text = agendamento.Projeto;

                            button3.Text = "OCUPADO";
                            button3.Enabled = false;
                        }

                    }
                    /////////////////////////////////////////
                    String dataAgendamento123 = calendarControl1.SelectionStart.Day.ToString() + "/" +
             calendarControl1.SelectionStart.Month.ToString() + "/" +
             calendarControl1.SelectionStart.Year.ToString();

                    groupBox4.Visible = true;
                    groupBox4.Text = "";
                    label5.Text = "12:00";

                    label6.Text = "Horário Disponível";
                    button4.Text = "AGENDAR";
                    button4.Enabled = true;

                    Console.WriteLine(dataAgendamento);


                    foreach (var agendamento in listaAgendamento)
                    {

                        Console.WriteLine(agendamento.Id);
                        if (agendamento.Hora.Equals("12:00"))
                        {
                            label6.Text = agendamento.Projeto;

                            button4.Text = "OCUPADO";
                            button4.Enabled = false;
                        }

                    }
                    /////////////////////////////////////////
                    String dataAgendamento1234 = calendarControl1.SelectionStart.Day.ToString() + "/" +
             calendarControl1.SelectionStart.Month.ToString() + "/" +
             calendarControl1.SelectionStart.Year.ToString();

                    groupBox5.Visible = true;
                    groupBox5.Text = "";
                    label8.Text = "13:00";

                    label7.Text = "Horário Disponível";
                    button5.Text = "AGENDAR";
                    button5.Enabled = true;


                    foreach (var agendamento in listaAgendamento)
                    {

                        Console.WriteLine(agendamento.Id);
                        if (agendamento.Hora.Equals("13:00"))
                        {
                            label7.Text = agendamento.Projeto;

                            button5.Text = "OCUPADO";
                            button5.Enabled = false;
                        }

                    }
                    /////////////////////////////////////////
                    String dataAgendamento12345 = calendarControl1.SelectionStart.Day.ToString() + "/" +
             calendarControl1.SelectionStart.Month.ToString() + "/" +
             calendarControl1.SelectionStart.Year.ToString();


                    groupBox6.Visible = true;
                    groupBox6.Text = "";
                    label10.Text = "14:00";

                    label9.Text = "Horário Disponível";
                    button6.Text = "AGENDAR";
                    button6.Enabled = true;


                    foreach (var agendamento in listaAgendamento)
                    {

                        Console.WriteLine(agendamento.Id);
                        if (agendamento.Hora.Equals("14:00"))
                        {
                            label9.Text = agendamento.Projeto;

                            button6.Text = "OCUPADO";
                            button6.Enabled = false;
                        }

                    }
                    /////////////////////////////////////////
                    String dataAgendamento123456 = calendarControl1.SelectionStart.Day.ToString() + "/" +
             calendarControl1.SelectionStart.Month.ToString() + "/" +
             calendarControl1.SelectionStart.Year.ToString();

                    groupBox7.Visible = true;
                    groupBox7.Text = "";
                    label15.Text = "15:00";

                    label13.Text = "Horário Disponível";
                    button7.Text = "AGENDAR";
                    button7.Enabled = true;

                    foreach (var agendamento in listaAgendamento)
                    {

                        Console.WriteLine(agendamento.Id);
                        if (agendamento.Hora.Equals("15:00"))
                        {
                            label13.Text = agendamento.Projeto;

                            button7.Text = "OCUPADO";
                            button7.Enabled = false;
                        }

                    }
                    /////////////////////////////////////////
                    String dataAgendamento1234567 = calendarControl1.SelectionStart.Day.ToString() + "/" +
             calendarControl1.SelectionStart.Month.ToString() + "/" +
             calendarControl1.SelectionStart.Year.ToString();


                    groupBox8.Visible = true;
                    groupBox8.Text = "";
                    label17.Text = "16:00";

                    label16.Text = "Horário Disponível";
                    button8.Text = "AGENDAR";
                    button8.Enabled = true;

                    foreach (var agendamento in listaAgendamento)
                    {

                        Console.WriteLine(agendamento.Id);
                        if (agendamento.Hora.Equals("16:00"))
                        {
                            label16.Text = agendamento.Projeto;

                            button8.Text = "OCUPADO";
                            button8.Enabled = false;
                        }

                    }
                    /////////////////////////////////////////
                    String dataAgendamento12345678 = calendarControl1.SelectionStart.Day.ToString() + "/" +
             calendarControl1.SelectionStart.Month.ToString() + "/" +
             calendarControl1.SelectionStart.Year.ToString();

                    groupBox9.Visible = true;
                    groupBox9.Text = "";
                    label19.Text = "17:00";

                    label18.Text = "Horário Disponível";
                    button9.Text = "AGENDAR";
                    button9.Enabled = true;

                    foreach (var agendamento in listaAgendamento)
                    {

                        Console.WriteLine(agendamento.Id);
                        if (agendamento.Hora.Equals("17:00"))
                        {
                            label18.Text = agendamento.Projeto;

                            button9.Text = "OCUPADO";
                            button9.Enabled = false;
                        }

                    }
                    /////////////////////////////////////////
                    String dataAgendamento123456789 = calendarControl1.SelectionStart.Day.ToString() + "/" +
             calendarControl1.SelectionStart.Month.ToString() + "/" +
             calendarControl1.SelectionStart.Year.ToString();

                    groupBox10.Visible = true;
                    groupBox10.Text = "";
                    label21.Text = "18:00";

                    label20.Text = "Horário Disponível";
                    button10.Text = "AGENDAR";
                    button10.Enabled = true;


                    foreach (var agendamento in listaAgendamento)
                    {

                        Console.WriteLine(agendamento.Id);
                        if (agendamento.Hora.Equals("18:00"))
                        {
                            label20.Text = agendamento.Projeto;

                            button10.Text = "OCUPADO";
                            button10.Enabled = false;
                        }

                    }
                }

            if (calendarControl1.DateTime.DayOfWeek == DayOfWeek.Sunday )
            {
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = false;
                button10.Enabled = false;
                MessageBox.Show("Não é possivel agendar fim de semana.");

            }
            if (calendarControl1.DateTime.DayOfWeek == DayOfWeek.Saturday)
            {
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = false;
                button10.Enabled = false;
                MessageBox.Show("Não é possivel agendar fim de semana.");
            }

            if (calendarControl1.SelectionStart < DateTime.Today)
            {
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = false;
                button10.Enabled = false;

            }


        }

        private void calendarControl1_Click(object sender, EventArgs e)
        {

        }

        private void calendarControl1_SelectionChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
    }
}
