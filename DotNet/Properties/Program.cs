namespace Properties
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee e = new Employee();
            e.Id = 10;
            e.Name = "Sakshi";
            e.Address = "Kokarud Sangli";

            int id = e.Id;
            string name = e.Name;
            string address = e.Address;
            Console.WriteLine(id);
            Console.WriteLine(name);
            Console.WriteLine(address);
        }
    }

    public class Employee
    {
        private int _id;
        private string _name;
        private string _address;

        public int Id
        {
            set
            {
                _id = value;
            }

            get
            {
                return _id;
            }
        }

        public string Name
        {
            set
            {
                _name = value;
            }
            get
            {
                return _name;
            }
        }

        public string Address
        {
            set
            {
                _address = value;
            }
            get
            {
                return _address;
            }
        }
    }
}
