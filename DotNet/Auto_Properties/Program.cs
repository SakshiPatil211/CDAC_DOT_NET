namespace Auto_Properties
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee()
            {
                EId = 1,
                EName = "Sakshi",
                isActive = true,
                Salary = 90000,
                DOJ = DateTime.Now,
                Projects = new List<string>() { "ORM", "Databse API","ASP.Net MVC"}
            };

            Console.WriteLine(e1.EId);
            Console.WriteLine(e1.EName);
            Console.WriteLine(e1.Salary);
            Console.WriteLine(e1.DOJ.ToString());
            foreach (string p in e1.Projects)
            {
                Console.WriteLine(p);
            }
        }
    }

    public class Employee
    {
        public int EId {  get; set; }
        public string EName { get; set; }
        public bool isActive {  get; set; }
        public double Salary {  get; set; }
        public DateTime DOJ {  get; set; }
        public List<string> Projects {  get; set; }
    }

}
