
using UserValidation.DAL;
using UserValidation.Model;

namespace UserValidation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ch;

            DBContext contextDB = new DBContext();


            do
            {
                Console.WriteLine("\n1 : Login " +
                    "\n2 : Exit");
                Console.WriteLine("Enter your Choice : ");
                ch = Convert.ToInt32(Console.ReadLine());

                switch (ch)
                {
                    case 1:
                        {
                            Console.WriteLine("Enter User Name : ");
                            string? uname = Console.ReadLine();
                            Console.WriteLine("Enter Password : ");
                            string? pass = Console.ReadLine();

                            User user = new User(uname, pass);

                            var u = contextDB.validateUser(user);

                            if (u != null)
                            {
                                Console.WriteLine("welcome!!!");
                            }
                            else
                            {
                                Console.WriteLine("Incorrect Credentials");
                            }

                            break;
                        }

                }


            } while (ch != 0);
        }
    }
}
