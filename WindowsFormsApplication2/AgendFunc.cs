using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace WindowsFormsApplication2
{
    class AgendFunc
    {
        public class BDComun
        {
            public static SqlConnection ObterConexao()
            {
                SqlConnection Conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Thiago\Desktop\WindowsFormsApplication2\banco.mdf;Integrated Security=True;Connect Timeout=30");
                Conn.Open();

                return Conn;

            }
            
               


        }

        public static int btnInstrum(Agend pAgend)
        {
            int retorno = 0;
            using (SqlConnection Conn = BDComun.ObterConexao())
            {
                SqlCommand Comando = new SqlCommand(string.Format("Insert Into Agenda (Data, Cliente, Projeto, Servico, Sala, Descricao ) values ('{0}', '{1}','{2}','{3}','{4}','{5}')",
                    pAgend.Data, pAgend.Cliente, pAgend.Projeto, pAgend.Servico, pAgend.Sala, pAgend.Descricao), Conn);

                retorno = Comando.ExecuteNonQuery();
                Conn.Close();


            }
            return retorno;


        }
    }
}
