using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

//https://www.youtube.com/watch?v=Rkm5JJ4m2tk



namespace WindowsFormsApplication2
{
    public class Validar
    {
        public const string _strCon = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\USERS\THIAGO KOSHIBA\DESKTOP\WINDOWSFORMSAPPLICATION2\BANCO.MDF;Integrated Security=True;Connect Timeout=30";
        private string vsql = "";
        SqlConnection objCon = null;

        private bool conectar()
        {
            objCon = new SqlConnection(_strCon);
            try
            {
                objCon.Open();
                return true;
            }
            catch
            {
                return false;
            }
        }
        private bool desconectar()
        {
            if (objCon.State != ConnectionState.Closed)
            {
                objCon.Close();
                objCon.Dispose();
                return true;
            }
            else
            {
                objCon.Dispose();
                return false;
            }
        }
        public List<string> listanivel()
        {
            vsql = "Select NivelAcesso from Tb_nivel_acesso ";
            SqlCommand objcmd = null;
            List<string> Username = new List<string>();

            if (this.conectar())
            {
                try
                {
                    objcmd = new SqlCommand(vsql, objCon);
                    SqlDataReader dr = objcmd.ExecuteReader();

                    while (dr.Read())
                    {
                        Username.Add(dr["NivelAcesso"].ToString());

                    }
                    return Username;
                }
                catch (SqlException erro)
                {
                    throw erro;
                }
                finally
                {
                    this.desconectar();
                }

            }
            else {
                return null;
            }
        }

        public List<string> listanivel1()
        {
            vsql = "Select Tipos from Tb_tipo ";
            SqlCommand objcmd = null;
            List<string> Tipos = new List<string>();

            if (this.conectar())
            {
                try
                {
                    objcmd = new SqlCommand(vsql, objCon);
                    SqlDataReader dr = objcmd.ExecuteReader();

                    while (dr.Read())
                    {
                        Tipos.Add(dr["Tipos"].ToString());

                    }
                    return Tipos;
                }
                catch (SqlException erro)
                {
                    throw erro;
                }
                finally
                {
                    this.desconectar();
                }

            }
            else {
                return null;
            }
        }

        public List<string> listanivel2()
        {
            vsql = "Select Servico from Tb_Servico ";
            SqlCommand objcmd = null;
            List<string> Tipos = new List<string>();

            if (this.conectar())
            {
                try
                {
                    objcmd = new SqlCommand(vsql, objCon);
                    SqlDataReader dr = objcmd.ExecuteReader();

                    while (dr.Read())
                    {
                        Tipos.Add(dr["Servico"].ToString());

                    }
                    return Tipos;
                }
                catch (SqlException erro)
                {
                    throw erro;
                }
                finally
                {
                    this.desconectar();
                }

            }
            else {
                return null;
            }
        }
    }
}
 
