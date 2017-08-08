using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace WindowsFormsApplication2
{
    class ChangeInBDcs
    {
        Connection constr44 = new Connection();
        SqlConnection cnAB = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\USERS\THIAGO KOSHIBA\DESKTOP\WINDOWSFORMSAPPLICATION2\BANCO.MDF;Integrated Security=True;Connect Timeout=30");
        SqlCommand cmd = new SqlCommand();
        DataTable myTable = new DataTable();
        private void SetComnd(string myState)
        {
            // cn.ConnectionString = "Server=CompileMe;Database=MyDatabase;Integrated Security=True";
            cmd.Connection = cnAB;
            cmd.CommandText = myState;

        }
        private void connect()
        { cnAB.Open(); }
        private void Disconnect()
        { cnAB.Dispose(); }
        public DataTable RunQuery(string select)
        {
            SetComnd(select);
            myTable.Load(cmd.ExecuteReader());
            return myTable;
        }
        public bool login(string rg,string senha)
        {
            connect();
            string sqlcmd = "select * from CAD where Rg='" + rg + "' and Senha='" + senha + "'";
            DataTable mytbl = RunQuery(sqlcmd);
            if (mytbl.Rows.Count > 0) return true;
            else return false;
        }

     

    }
}
