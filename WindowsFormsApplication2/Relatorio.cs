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
    public partial class Relatorio : Form
    {


        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Thiago\Desktop\WindowsFormsApplication2\banco.mdf;Integrated Security=True;Connect Timeout=30");

        public Relatorio()
        {
            InitializeComponent();
        }

    private void Relatorio_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select Dia from Tb_Dia";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                comboBox1.Items.Add(dr["Dia"].ToString());
            }
  
                servico.Items.Clear();
                //con.Open();
                SqlCommand cmda = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "Select Relatorio from Tb_Relatorio";
                cmd.ExecuteNonQuery();
                DataTable dta = new DataTable();
                SqlDataAdapter daa = new SqlDataAdapter(cmd);
                da.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    servico.Items.Add(dr["Relatorio"].ToString());
                }
                con.Close();
            
        }
     
    }
}
