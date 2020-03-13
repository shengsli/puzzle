using System;
using System.Data.SqlClient;

namespace Application
{
    class Program
    {
        static void Main(string[] args)
        {
            // string server = "SGDPDEVSLI01";
            // string username = "sa";
            // string password = "Password1";
            // string database = "SBODEMOUS";
            string connectionString = @"Data Source=SGDPDEVSLI01\Initial Catalog=SBODEMOUS;User ID=sa;Password=Password1";
            try
            {
                using (sqlConnection connection = new sqlConnection(connectionString))
                {
                    connection.Open();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }
    }
}