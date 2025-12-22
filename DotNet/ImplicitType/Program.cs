namespace ImplicitType
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Test obj = new Test();
            Console.WriteLine("Enter the choice");
            int ch = Convert.ToInt32(Console.ReadLine());
            var result = obj.GetSomething(ch);
            Console.WriteLine(result);


            var x = 100;
            var str = "sakshi";
            var e = new Employee();
        }
    }

    public class Test
    {
        public object GetSomething(Nullable<int> choice)
        {
            if(choice == 1)
            {
                return 1;
            }else if(choice == 2)
            {
                return new Employee() { Id = 100, Name = "Sakshi" };
            }
            else
            {
                return null;
            }
        }
    }

    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
