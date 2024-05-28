/*using MySql.Data.MySqlClient;
using System;

namespace matvelickov_myParfums_asp
{
    public class MySql
    {
        private static string connString = "server=localhost;port=3306;uid=root;pwd=root;database=db_parfums";

        public static void MySqlConn()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connString))
                {
                    conn.Open();
                    Console.WriteLine("Connection successful.");
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error connecting to MySQL: " + ex.Message);
            }
        }

        public static string GetParfumName()
        {
            /*try
            {
                using (MySqlConnection connection = new MySqlConnection(connString))
                {
                    connection.Open();
                    string query = "SELECT parNom FROM t_parfum";
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        object result = command.ExecuteScalar();
                        return result != null ? result.ToString() : null;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return null;
            }
        }
        return "mateja";
    }
}
*/