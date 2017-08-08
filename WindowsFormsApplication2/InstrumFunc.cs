using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace WindowsFormsApplication2
{
    class InstrumFunc
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

        public static List<Instrum> BuscarEquip(String Pid)
        {

            List<Instrum> Lista1 = new List<Instrum>();
            using (SqlConnection co = BDComun.ObterConexao())
            {
                SqlCommand comandoo = new SqlCommand(string.Format(
                    "Select Id, NomeEquip, classificacao, tipo, valor, situacao from InstruCad where NomeEquip like '%{0}%'", Pid), co);

                SqlDataReader reader1 = comandoo.ExecuteReader();

                while (reader1.Read())
                {
                    Instrum pInstrum = new Instrum();
                    pInstrum.Id = reader1.GetInt64(0);
                    pInstrum.NomeEquip = reader1.GetString(1);
                    pInstrum.Classificacao = reader1.GetString(2);
                    pInstrum.Tipo = reader1.GetString(3);
                    pInstrum.valor = reader1.GetString(4);
                    pInstrum.Situacao = reader1.GetString(5);

                    Lista1.Add(pInstrum);

                }
                co.Close();
                return Lista1;

            }

        }

        public static List<Instrum1> BuscarEquip1(String Pid)
        {

            List<Instrum1> Lista1 = new List<Instrum1>();
            using (SqlConnection co = BDComun.ObterConexao())
            {
                SqlCommand comandoo = new SqlCommand(string.Format(
                    "Select NomeEquip, Tipo, Valor from InstruCad where Classificacao like 'Internacional'", Pid), co);

                SqlDataReader reader11 = comandoo.ExecuteReader();

                while (reader11.Read())
                {
                    Instrum1 pInstrum1 = new Instrum1();
                    pInstrum1.NomeEquip = reader11.GetString(0);
                    pInstrum1.Tipo = reader11.GetString(1);
                    pInstrum1.Valor = reader11.GetString(2);

                    Lista1.Add(pInstrum1);

                }
                co.Close();
                return Lista1;

            }

        }

        public static List<Instrum2> BuscarEquip2(String Pid)
        {

            List<Instrum2> Lista2 = new List<Instrum2>();
            using (SqlConnection co = BDComun.ObterConexao())
            {
                SqlCommand comandoo = new SqlCommand(string.Format(
                    "Select NomeEquip, Tipo, Valor from InstruCad where classificacao like 'Nacional'", Pid), co);

                SqlDataReader reader15 = comandoo.ExecuteReader();

                while (reader15.Read())
                {
                    Instrum2 pInstrum2 = new Instrum2();
                    pInstrum2.NomeEquip = reader15.GetString(0);
                    pInstrum2.Tipo = reader15.GetString(1);
                    pInstrum2.Valor = reader15.GetString(2);

                    Lista2.Add(pInstrum2);

                }
                co.Close();
                return Lista2;

            }

        }


        public static int Adicionar(Instrum pInstrum)
        {
            int retorno = 0;
            using (SqlConnection Conn = BDComun.ObterConexao())
            {
                SqlCommand Comando = new SqlCommand(string.Format("Insert Into InstruCad (NomeEquip, classificacao, tipo, valor, situacao ) values ('{0}', '{1}','{2}','{3}','{4}')",
                    pInstrum.NomeEquip, pInstrum.Classificacao, pInstrum.Tipo, pInstrum.valor, pInstrum.Situacao), Conn);

                retorno = Comando.ExecuteNonQuery();
                Conn.Close();

                
            }
            return retorno;
            

        }


        public static int Editar(Instrum pInstrum)
        {
            int retorno = 0;

            using (SqlConnection conexao = BDComun.ObterConexao())
            {

                SqlCommand comando = new SqlCommand(string.Format("Update InstruCad set NomeEquip = '{0}', classificacao = '{1}', tipo = '{2}', valor = '{3}', situacao = '{4}' where Id = {5} ",
                    pInstrum.NomeEquip, pInstrum.Classificacao, pInstrum.Tipo, pInstrum.valor,pInstrum.Situacao, pInstrum.Id ), conexao);


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

                SqlCommand comando = new SqlCommand(string.Format("Delete from InstruCad where Id={0}", pId), conec);
                retorno = comando.ExecuteNonQuery();
                conec.Close();
            }
            return retorno;

        }


        public static Instrum ObterEquip(Int64 pId)
        {

            using (SqlConnection conexao = BDComun.ObterConexao())
            {

                Instrum pInstrum = new Instrum();
                SqlCommand comandoo = new SqlCommand(string.Format(
                    "Select Id, NomeEquip, Classificacao, Tipo, valor, situacao from InstruCad where Id={0}", pId), conexao);

                SqlDataReader reader1 = comandoo.ExecuteReader();

                while (reader1.Read())
                {
                    pInstrum.Id = reader1.GetInt64(0);
                    pInstrum.NomeEquip = reader1.GetString(1);
                    pInstrum.Classificacao = reader1.GetString(2);
                    pInstrum.Tipo = reader1.GetString(3);
                    pInstrum.valor = reader1.GetString(4);
                    pInstrum.Situacao = reader1.GetString(5);
                }


                conexao.Close();
                return pInstrum;

            }
        }
        

    }
}
