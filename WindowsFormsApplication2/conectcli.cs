using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    class conectcli
    {
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter dr;


        public class BDComun
        {
            public static SqlConnection ObterConexao()
            {
                SqlConnection Conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\USERS\THIAGO KOSHIBA\DESKTOP\WINDOWSFORMSAPPLICATION2\BANCO.MDF;Integrated Security=True;Connect Timeout=30");
                Conn.Open();

                return Conn;

            }

        }
            public void autocomplete(TextBox atxt)
        {
            using (SqlConnection conn = BDComun.ObterConexao())
            {
                SqlCommand cmd = new SqlCommand("Select Nome from CAD", conn);

                SqlDataReader reader1 = cmd.ExecuteReader();

                while (reader1.Read())
                {
                    atxt.AutoCompleteCustomSource.Add(reader1["Nome"].ToString());
                }
            }
        }
    }
}
