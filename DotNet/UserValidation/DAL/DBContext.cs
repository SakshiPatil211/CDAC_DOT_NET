using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserValidation.Model;

namespace UserValidation.DAL
{
    public class DBContext
    {
        String ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=IETDb;Integrated Security=True";

        internal object validateUser(User user)
        {
            SqlConnection conn = new SqlConnection(ConnectionString);

            SqlCommand cmd = new SqlCommand($"select * from [user] where userName = '{user.userName}' and password = '{user.password}'", conn);

            conn.Open();
            User u1 = null;
            SqlDataReader record = cmd.ExecuteReader();

            if (record != null)
            {
                while (record.Read())
                {
                    u1 = new User(record[0].ToString(), record[1].ToString());
                    //u1 = new User(record[0].ToString(), record[1].ToString(), record[2].ToString());
                }
            }

            conn.Close();

            return u1;
        }
    }
}
