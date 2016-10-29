using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CasaDasMarmitas
{
    class Db
    {
        private static SqlConnection conexao;
        private static SqlCommand cmd;
        private static DataAdapter data;
        private static DataSet ds = new DataSet();
        public static bool Connect()
        {
           string strcon = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Data\Marmita.mdf;Integrated Security=True";
           conexao = new SqlConnection(strcon);
            try
            {
                conexao.Open();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Erro -> " + ex.Message);
                throw;
            }
            return true;
        }

        public static DataSet Select(string query)
        {
            try
            {
                cmd = new SqlCommand(query, conexao);
                cmd.ExecuteNonQuery();
                data = new SqlDataAdapter(cmd);
                data.Fill(ds);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro -> " + ex.Message);
                throw;
            }
            return ds;
        }

        private static bool exec(string query)
        {
            try
            {
                cmd = new SqlCommand(query, conexao);
                int val = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro -> " + ex.Message);
                return false;
            }
            return true;
        }

        public static bool Insert(string query)
        {
            return exec(query);
        }

        public static bool Update(string query)
        {
            return exec(query);
        }

        public static bool Delete(string query)
        {
            return exec(query);
        }

        public static void Disconnect()
        {
            conexao.Close();
        }
    }
}
