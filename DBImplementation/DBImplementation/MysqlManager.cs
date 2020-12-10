using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace DBImplementation
{
	public static class MysqlManager
	{    
        public static MySqlDataReader executeQuery(String connectionStr, String query)
		{
            MySqlConnection conn = null;
            MySqlDataReader reader = null;
            try
            {
                conn = new MySqlConnection(connectionStr);
                conn.Open();
                MySqlCommand command = new MySqlCommand(query, conn);
                reader = command.ExecuteReader();
                reader.Read();
                return reader;
            }
            catch (MySqlException err)
            {
                throw new Exception("Error execute query [" + err.Message + "]");
            }
            finally
            {
               // if (conn != null)
                //    conn.Close();            
            }

        }

        public static String executeScalsr(String connectionStr, String query)
        {
            MySqlConnection conn = null;
            try
            {
                conn = new MySqlConnection(connectionStr);
                conn.Open();               
                MySqlCommand command = new MySqlCommand(query, conn);
                return command.ExecuteScalar().ToString();
            }
            catch (MySqlException err)
            {
                throw new Exception("Error execute batch [" + err.Message + "]");
            }
            finally
            {
              //  if (conn != null)
              //      conn.Close();
            }
        }

        public static DataTable executeAdapter(String connectionStr, String query)
        {
            MySqlConnection conn = null;
            try
            {
                conn = new MySqlConnection(connectionStr);
                conn.Open();
                MySqlDataAdapter SDA = new MySqlDataAdapter(query, conn);
                DataTable DATA = new DataTable();
                SDA.Fill(DATA);
                return DATA;
            }
            catch (MySqlException err)
            {
                throw new Exception("Error execute batch [" + err.Message + "]");
            }
            finally
            {
                  if (conn != null)
                      conn.Close();
            }
        }
    }
}
