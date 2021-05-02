using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;


namespace CompanyDB
{
    class DBManager
    {

        string DB_connection_String = @"Data Source=DESKTOP-UL6OEPH\SQLEXPRESS;Initial Catalog=CompanyDBLab44;Integrated Security=True";
        SqlConnection myConnection;

        public DBManager()
        {
            myConnection = new SqlConnection(DB_connection_String);
            try
            {
                myConnection.Open();
                MessageBox.Show("Successfully connected to the database!");
            }
            catch (Exception e)
            {
                MessageBox.Show("An error occurred while connecting to the database!");


            }

        }

        public int ExecuteNonQuery(string query)
        {
            try
            {
                SqlCommand myCommand = new SqlCommand(query, myConnection);
                return myCommand.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                return 0;
            }
        }

        public DataTable ExcuteReader(string query)
        {
            try
            {
                SqlCommand myCommand = new SqlCommand(query, myConnection);
                SqlDataReader reader = myCommand.ExecuteReader();
                if (reader.HasRows)
                {
                    DataTable dt = new DataTable();
                    dt.Load(reader);
                    reader.Close();
                    return dt;
                }
                else
                {
                    reader.Close();
                    return null;

                }
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public object ExcuteScalar(string query)
        {
            try
            {
                SqlCommand myCommand = new SqlCommand(query, myConnection);
                return myCommand.ExecuteScalar();

            }
            catch(Exception e)
            {
                return 0;
            }
        }

        public void closeConnection()
        {

            try
            {
                myConnection.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);

            }
        }



    }
}
