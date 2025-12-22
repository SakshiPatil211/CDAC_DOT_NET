namespace Object_Initializer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Demo d1 = new Demo() { _Id=100 };
            Console.WriteLine(d1._Id);
            Demo d2 = new Demo() { _Id = 101, _Name = "Sakshi" };
            Console.WriteLine(d2._Id + " " + d2._Name);
            Demo d3 = new Demo() { _Id = 102, _Name = "Sakshi", _Salary = 700000 };
            Console.WriteLine(d3._Id + " " + d3._Name + " " + d3._Salary);
            Demo d4 = new Demo() { _Id = 103, _Name = "Sakshi", _Salary = 600000, _Description = "Software Developer" };
            Console.WriteLine(d4._Id + " " + d4._Name + " " + d4._Salary + " " + d4._Description);

            // User Input
            Console.WriteLine("Enter Id");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Name");
            string nm = Console.ReadLine();
            Demo d5 = new Demo() { _Id = id, _Name = nm };
            Console.WriteLine($"Demo5 Id = {d5._Id} Name = {d5._Name}");

        }
    }

    public class Demo
    {
        public int _Id;
        public string _Name;
        public string _Description;
        public double _Salary;
    }
}
