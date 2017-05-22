using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace WindowsFormsApplication2
{
    class ClienteFunc
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

        

        public static int Adicionar(Cliente pCliente)
        {
            int retorno = 0;
            using (SqlConnection Conn = BDComun.ObterConexao())
            {
                SqlCommand Comando = new SqlCommand(string.Format("Insert Into CAD (Nome, Telefone, Celular, Email, Endereco, N, Bairro, Rg, Cpf, Login, Senha, NivelAcesso ) values ('{0}', '{1}','{2}','{3}','{4}', '{5}','{6}','{7}','{8}','{9}','{10}','{11}')",
                    pCliente.Nome, pCliente.Telefone, pCliente.Celular, pCliente.Email, pCliente.Endereco, pCliente.N, pCliente.Bairro, pCliente.Rg, pCliente.Cpf, pCliente.Login,pCliente.Senha, pCliente.NivelAcesso), Conn);

                retorno = Comando.ExecuteNonQuery();
                Conn.Close();

            }
            return retorno;
        }

       

        public static int Editar(Cliente pCliente)
        {
            int retorno = 0;

            using (SqlConnection conexao = BDComun.ObterConexao())
            {
               
                SqlCommand comando = new SqlCommand(string.Format("Update CAD set Nome = '{0}', Telefone = '{1}', Celular = '{2}', Email = '{3}', Endereco = '{4}', N = '{5}', Bairro = '{6}', Rg = '{7}', Cpf = '{8}', NivelAcesso = '{9}' where Id = {10}",
                     pCliente.Nome, pCliente.Telefone, pCliente.Celular, pCliente.Email, pCliente.Endereco, pCliente.N, pCliente.Bairro, pCliente.Rg, pCliente.Cpf, pCliente.NivelAcesso, pCliente.Id), conexao);

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

                SqlCommand comando = new SqlCommand(string.Format("Delete from CAD where Id={0}", pId), conec);
                retorno = comando.ExecuteNonQuery();
                conec.Close();
            }
            return retorno;

        }


        public static List<Cliente> BuscarCliente(String pNome)
        {

            List<Cliente> Lista = new List<Cliente>();
            using (SqlConnection con = BDComun.ObterConexao())
            {
                
                SqlCommand comando = new SqlCommand(string.Format(
                    "Select  Id, Nome, Telefone, Celular, Email, Endereco, N, Bairro, Rg, Cpf, NivelAcesso from CAD where Nome like '%{0}%'", pNome), con);

                SqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    Cliente pCliente = new Cliente();
                    pCliente.Id = reader.GetInt64(0);
                    pCliente.Nome = reader.GetString(1);
                    pCliente.Telefone = reader.GetString(2);
                    pCliente.Celular = reader.GetString(3);
                    pCliente.Email = reader.GetString(4);
                    pCliente.Endereco = reader.GetString(5);
                    pCliente.N = reader.GetString(6);
                    pCliente.Bairro = reader.GetString(7);
                    pCliente.Rg = reader.GetString(8);
                    pCliente.Cpf = reader.GetString(9);
                    pCliente.NivelAcesso = reader.GetString(10);

                    Lista.Add(pCliente);

                }
                con.Close();
                return Lista;

            }

        }


        public static Cliente ObterCliente(Int64 pId)
        {

            using (SqlConnection conexao = BDComun.ObterConexao())
            {

                Cliente pCliente = new Cliente();
                SqlCommand comando = new SqlCommand(string.Format(
                    "Select Id, Nome, Telefone, Celular, Email, Endereco, N, Bairro, Rg, Cpf, NivelAcesso from CAD where Id={0}", pId), conexao);

               SqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    pCliente.Id = reader.GetInt64(0);
                    pCliente.Nome = reader.GetString(1);
                    pCliente.Telefone = reader.GetString(2);
                    pCliente.Celular = reader.GetString(3);
                    pCliente.Email = reader.GetString(4);
                    pCliente.Endereco = reader.GetString(5);
                    pCliente.N = reader.GetString(6);
                    pCliente.Bairro = reader.GetString(7);
                    pCliente.Rg = reader.GetString(8);
                    pCliente.Cpf = reader.GetString(9);
                    pCliente.NivelAcesso = reader.GetString(10);
                    
                }
                

                conexao.Close();
                return pCliente;

            }
        }
    }
}