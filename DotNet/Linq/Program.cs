namespace Linq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> elist = new List<Employee>()
            {
                new Employee() {EId= 1, EName="Peter", EAddress="NY"},
                new Employee() {EId=2, EName="Gwen", EAddress="NY"},
                new Employee() {EId=3, EName="chris", EAddress="Australia"},
                new Employee() {EId=4, EName="Tom", EAddress="London"},
                new Employee() {EId=5, EName="Jane", EAddress="Australia"},
                new Employee() {EId=6, EName="Loki", EAddress="Asgard"},
                new Employee() {EId=7, EName="Thor", EAddress="Asgard"},
            };

            #region LAZY Loading of LINQ
            Console.WriteLine("Enter the city name");
            string? city = Console.ReadLine().ToLower();

            var filetrEmp = (from emp in elist
                             where emp.EAddress.ToLower().StartsWith(city)
                             select emp);

            elist.Add(new Employee() { EId = 86, EName = "ShangChi", EAddress = "London" });

            foreach (Employee e in filetrEmp)
            {
                e.GetDetails();
            }
            #endregion

            #region LINQ with .ToList() Extension Method
            Console.WriteLine("Enter the first character of city");
            string? city1 = Console.ReadLine().ToLower();

            var result = (from emp in elist
                          where emp.EAddress.ToLower().StartsWith(city1)
                          select emp).ToList();

            elist.Add(new Employee() { EId = 86, EName = "ShangChi", EAddress = "London" });

            foreach (Employee e in result)
            {
                e.GetDetails();
            }
            #endregion

            #region LINQ with Tuple
            Console.WriteLine("Enter the first character of city");
            string? city2 = Console.ReadLine().ToLower();

            var result1 = (from emp in elist
                          where emp.EAddress.ToLower().StartsWith(city2)
                          select (emp.EName,emp.EAddress)).ToList();

            foreach (var e in result1)
            {
                Console.WriteLine($"NAme:{e.EName} Address:{e.EAddress}");
            }
            #endregion
        }
    }

    public class Employee
    {
        public int EId { get; set; }
        public string EName { get; set; }
        public string EAddress { get; set; }

        public void GetDetails()
        {
            Console.WriteLine($"Id:{this.EId} Name:{this.EName} Address:{this.EAddress}");
        }
    }
}
