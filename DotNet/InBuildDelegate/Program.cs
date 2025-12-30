namespace InBuildDelegate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Action Delegate Predegate
            //delegate with no return type

            //1st Way
            Action action1 = new Action(delegate ()
                                      {
                                          Console.WriteLine("Hello from Sakshiiiiiiiiiiiiiiiiiiii");
                                      });
            action1();

            //2nd Way
            Action action2 = delegate () { Console.WriteLine("Hello"); };
            action2();

            //3rd way
            Action action3 = () => { Console.WriteLine("Helooooo"); };
            action3();

            //4th way
            Action action4 = () => Console.WriteLine("Hello");
            action4();
            #endregion

            #region Fun<out Result>
            // it only return

            //1st way
            Func<int> fun1 = delegate() { return 1; };
            Console.WriteLine(fun1());

            //2nd way
            Func<int> func2 = ()=> { return 2; };
            Console.WriteLine(func2());

            #endregion

            #region Func<in T, out Result>
            // it accept one parameter and return bool it

            //1st Way
            Func<int, bool> del1 = new Func<int, bool>(
                                                       delegate (int x) 
                                                       {
                                                           return x % 2 == 0;
                                                       });
            //or
            /*
              Func<int, bool> del1 = delegate (int x) {
                                                        return x % 2 == 0;
                                                      };
             */
            var result = del1(10);
            Console.WriteLine(result);

            //2nd way
            Func<int, bool> del2 = new Func<int, bool>(x => x % 2 == 0);
            var result1 = del2(11);
            Console.WriteLine(result1);

            //3rd way
            Predicate<int> _predicate = x => x % 2 == 0;
            Func<int, bool> del3 = new Func<int, bool>(_predicate);
            var result4 = del3(10);
            Console.WriteLine(result4);
            #endregion

            #region in-build Where() Extension method
            int[] arr = {1, 2, 3, 4, 5};
            Console.WriteLine($"Sum {arr.Sum()}");
            Console.WriteLine($"Max {arr.Max()}");

            Predicate<int> _predicate1 = x=> x % 2 == 0;
            Func<int, bool> del4 = new Func<int, bool>(_predicate1);

            var result7 = arr.Where(del4);
            Console.WriteLine("-----Where method------");
            foreach(int x in arr) Console.WriteLine(x);

            #endregion

            #region Select() in-build method
            Func<int,int> func7= new Func<int,int>(no=>no*2);
            var doubleArea = arr.Select(func7);
            Console.WriteLine("In Select()");
            foreach (int ele in doubleArea)
            {
                Console.WriteLine(ele);
            }
            #endregion

            #region Func<Emp, bool> first in parater is user defined
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

            Console.WriteLine("Enter the city name");
            string? city = Console.ReadLine().ToLower();

            Func<Employee, bool> del = emp => emp.EAddress.ToLower() == city;
            //Func<Employee, bool> del = emp => emp.EAddress.ToLower().StartsWith(city);
            foreach (Employee e in elist)
            {
                if (del(e))
                {
                    Console.WriteLine($"Id:{e.EId} Name:{e.EName} Address:{e.EAddress}");
                }
            }
            #endregion
        }
    }

    public class Employee
    {
        public int EId { get; set; }
        public string EName { get; set; }
        public string EAddress { get; set; }
    }
}
