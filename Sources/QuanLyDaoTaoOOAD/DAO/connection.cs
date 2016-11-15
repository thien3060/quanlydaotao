using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;
using System.Configuration;

namespace DAO
{
    public class Connection
    {
        public SqlConnection Connect;

        public void OpenConnection()
        {
            Connect = new SqlConnection("Data Source=.;Initial Catalog=QuanLyDaoTao;Integrated Security=True");
            try
            {
                Connect.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ket Noi Khong Thanh Cong \n" + ex.Message, "Loi Ket Noi", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        public void CloseConnection()
        {
            Connect.Close();
        }

        public void ExecuteSql(string strSql)
        {
            OpenConnection();
            var sqlcmd = new SqlCommand(strSql, Connect);
            sqlcmd.ExecuteNonQuery();
            CloseConnection();
        }
    
        public void ExecuteSqlWithParameter(string strSql, Dictionary<string, object> parameters)
        {
            OpenConnection();
            var sqlcmd = new SqlCommand(strSql, Connect);
            foreach (var parameter in parameters)
            {
                sqlcmd.Parameters.AddWithValue(parameter.Key, parameter.Value);
            }
            sqlcmd.ExecuteNonQuery();
            CloseConnection();
        }

        public DataTable GetDataTable(string strSql)
        {
            OpenConnection();
            var dt = new DataTable();
            var sqlda = new SqlDataAdapter(strSql, Connect);
            sqlda.Fill(dt);
            CloseConnection();
            return dt;
        }

        public string SearchDaTaGrid(string key, string table, string columnName)
        {
            int count = 0;
            string ma = "";
            var dt = new DataTable();
            dt = GetDataTable("Select " + columnName + " From " + table);
            for (var i = 1; true; i++)
            {
                for (int j = 0; j < dt.Rows.Count; j++)
                {
                    if (dt.Rows[j][columnName].ToString() != key + "" + i)
                    {
                        count++;
                    }
                    else
                    {
                        count = 0;
                        break;
                    }
                }
                if (count == dt.Rows.Count)
                {
                    ma = key + "" + i;
                    break;
                }
            }
            return ma;
        }
    }
}
