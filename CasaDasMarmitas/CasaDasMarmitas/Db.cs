using System;
using System.Collections.Generic;
using System.Data;
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

        public static void Disconnect()
        {
            conexao.Close();
        }
    }
}
