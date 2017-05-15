using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace WindowsFormsApplication2
{
    class SalaFunc
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

        public static List<Sala> BuscarEquip(String Pid)
        {

            List<Sala> Lista1 = new List<Sala>();
            using (SqlConnection co = BDComun.ObterConexao())
            {
                SqlCommand comandoo = new SqlCommand(string.Format(
                    "Select Id, NomeSala, Identificacao, Tamanho, Valor, Situacao from SalaCad where NomeSala like '%{0}%'", Pid), co);

                SqlDataReader reader1 = comandoo.ExecuteReader();

                while (reader1.Read())
                {
                    Sala pSala = new Sala();
                    pSala.Id = reader1.GetInt64(0);
                    pSala.NomeSala = reader1.GetString(1);
                    pSala.Identificacao = reader1.GetString(2);
                    pSala.Tamanho = reader1.GetString(3);
                    pSala.Valor = reader1.GetString(4);
                    pSala.Situacao = reader1.GetString(5);

                    Lista1.Add(pSala);

                }
                co.Close();
                return Lista1;

            }

        }


        public static int Adicionar(Sala pSala)
        {
            int retorno = 0;
            using (SqlConnection Conn = BDComun.ObterConexao())
            {
                SqlCommand Comando = new SqlCommand(string.Format("Insert Into SalaCad (NomeSala, Identificacao, Tamanho, Valor, Situacao ) values ('{0}', '{1}','{2}','{3}','{4}')",
                    pSala.NomeSala, pSala.Identificacao, pSala.Tamanho, pSala.Valor, pSala.Situacao), Conn);

                retorno = Comando.ExecuteNonQuery();
                Conn.Close();

            }
            return retorno;
        }


        public static int Editar(Sala pSala)
        {
            int retorno = 0;

            using (SqlConnection conexao = BDComun.ObterConexao())
            {

                SqlCommand comando = new SqlCommand(string.Format("Update SalaCad set NomeSala = '{0}', Identificacao = '{1}', Tamanho = '{2}', Valor = '{3}', Situacao = '{4}' where Id = {5}",
                    pSala.NomeSala, pSala.Identificacao, pSala.Tamanho, pSala.Valor, pSala.Situacao, pSala.Id), conexao);

                retorno = comando.ExecuteNonQuery();
                conexao.Close();


            }
            return retorno;

        }


        public static int Excluir(Int64 pId)
        {
            int retorno = 0;
            using (SqlConnection conec = BDComun.ObterConexao())
            {

                SqlCommand comando = new SqlCommand(string.Format("Delete from SalaCad where Id={0}", pId), conec);
                retorno = comando.ExecuteNonQuery();
                conec.Close();
            }
            return retorno;

        }


        public static Sala ObterEquip(Int64 pId)
        {

            using (SqlConnection conexao = BDComun.ObterConexao())
            {

                Sala pSala = new Sala();
                SqlCommand comandoo = new SqlCommand(string.Format(
                    "Select Id, NomeSala, Identificacao, Tamanho, Valor, Situacao from SalaCad where Id={0}", pId), conexao);

                SqlDataReader reader1 = comandoo.ExecuteReader();

                while (reader1.Read())
                {
                    pSala.Id = reader1.GetInt64(0);
                    pSala.NomeSala = reader1.GetString(1);
                    pSala.Identificacao = reader1.GetString(2);
                    pSala.Tamanho = reader1.GetString(3);
                    pSala.Valor = reader1.GetString(4);
                    pSala.Situacao = reader1.GetString(5);
                }


                conexao.Close();
                return pSala;

            }
        }

    }
}
