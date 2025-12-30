using Microsoft.Data.SqlClient;

namespace ConnectedADO.Net
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string connString = "Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=IETDb;Integrated Security=True";

            #region Select query
            //SqlConnection conn = new SqlConnection(connString);

            //string selectQuery = "select * from Employee1";
            //SqlCommand cmd = new SqlCommand();
            //cmd.CommandType = System.Data.CommandType.Text;
            //cmd.CommandText = selectQuery;
            //cmd.Connection = conn;

            //conn.Open();

            //SqlDataReader reader = cmd.ExecuteReader();

            //while (reader.Read())
            //{
            //    int id = Convert.ToInt32(reader[0]);
            //    string? nm = reader[1].ToString();
            //    string? addr = reader[2].ToString();

            //    Console.WriteLine($"Id ={id} Name={nm} Address={addr}");
            //}

            //conn.Close();
            #endregion

            #region insert
            SqlConnection conn1 = new SqlConnection(connString);
            
            Console.WriteLine("Enter the id");
            int id1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Name:");
            string? nm1 = Console.ReadLine();
            Console.WriteLine("Enter Address");
            string? addr1 = Console.ReadLine();

            string insertQuery = "insert into Employee values({id1},{'nm1'}, {'addr1'})";
            SqlCommand cmd1 = new SqlCommand();
            cmd1.CommandType = System.Data.CommandType.Text;
            cmd1.CommandText = insertQuery;
            cmd1.Connection = conn1;

            conn1.Open();

            int n = cmd1.ExecuteNonQuery();

            if (n > 0)
            {
                Console.WriteLine("Inserted successfully");
            }
            else
            {
                Console.WriteLine("Inserted not successfully");
            }

            conn1.Close();
            #endregion
        }
    }
}
