using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace WindowsFormsApplication2
{
    class InstruSeleFunc
    {

        public class BDComun
        {
            public static SqlConnection ObterConexao()
            {
                SqlConnection Conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\USERS\THIAGO KOSHIBA\DESKTOP\WINDOWSFORMSAPPLICATION2\BANCO.MDF;Integrated Security=True;Connect Timeout=30");
                Conn.Open();

                return Conn;

            }




        }

        public static int btnIntru(InstruSele pInstruSele)
        {
            int retorno = 0;
            using (SqlConnection Conn = BDComun.ObterConexao())
            {
                SqlCommand Comando = new SqlCommand(string.Format("Insert Into InstruSelec (Nome, Data ) values ('{0}', '{1}')",
                    pInstruSele.Nome, pInstruSele.Data), Conn);

                retorno = Comando.ExecuteNonQuery();
                Conn.Close();


            }
            return retorno;


        }
    }
}

