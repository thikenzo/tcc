using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace WindowsFormsApplication2
{
    class RelatFunc
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

            public static List<Relat> BuscarAgenda(Int64 Pid)
            {

                List<Relat> Lista = new List<Relat>();
                using (SqlConnection co = BDComun.ObterConexao())
                {
                    SqlCommand comandoo = new SqlCommand(string.Format(
                        "Select Id, Data, Hora, Cliente, Projeto, Servico, Sala, Descricao from Agenda where Data like '%{0}%'", Pid), co);

                    SqlDataReader reader1 = comandoo.ExecuteReader();

                    while (reader1.Read())
                    {
                        Relat pRelat = new Relat();
                        pRelat.Id = reader1.GetInt64(0);
                        pRelat.Data = reader1.GetString(1);
                        pRelat.Hora = reader1.GetString(2);
                          pRelat.Cliente = reader1.GetString(3);
                         pRelat.Projeto = reader1.GetString(4);
                          pRelat.Servico = reader1.GetString(5);
                         pRelat.Sala = reader1.GetString(6);
                        pRelat.Descricao = reader1.GetString(7);

                        Lista.Add(pRelat);

                    }
                    co.Close();
                    return Lista;

                }

            }


            public static int Excluir1(Int64 pId)
        {
            int retorno = 0;
            using (SqlConnection conec = BDComun.ObterConexao())
            {

                SqlCommand comando = new SqlCommand(string.Format("Delete from Agenda where Id={0}", pId), conec);
                retorno = comando.ExecuteNonQuery();
                conec.Close();
            }
            return retorno;

        }



        public static Relat Obteragen(Int64 pId)
        {

            using (SqlConnection conexao = BDComun.ObterConexao())
            {
                
                Relat pRelat = new Relat();
                SqlCommand comandoo = new SqlCommand(string.Format(
                    "Select Id, Data, Hora, Cliente, Projeto, Servico, Sala, Descricao from Agenda where Id={0}", pId), conexao);

                SqlDataReader reader1 = comandoo.ExecuteReader();

                while (reader1.Read())
                {
                    
                    pRelat.Id = reader1.GetInt64(0);
                    pRelat.Data = reader1.GetString(1);
                    pRelat.Hora = reader1.GetString(2);
                    pRelat.Cliente = reader1.GetString(3);
                    pRelat.Projeto = reader1.GetString(4);
                    pRelat.Servico = reader1.GetString(5);
                    pRelat.Sala = reader1.GetString(6);
                    pRelat.Descricao = reader1.GetString(7);

                }


                conexao.Close();
                return pRelat;

            }
        }

    }
}
