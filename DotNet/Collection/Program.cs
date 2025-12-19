using System.Collections;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;
using static Collection.Program;

namespace Collection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Array(int and  string) declaration and access array elements
            Console.WriteLine("Array(int and  string) declaration and access array elements\n");
            int[] arr = { 1, 2, 3 };
            /*int[] arr = new int[3];
            arr[0] = 1;
            arr[1] = 2;
            arr[2] = 3;*/
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }

            string[] str = { "\nIron Man", "Thor", "Captain America" };
            for (int i = 0; i < str.Length; i++)
            {
                Console.WriteLine(str[i]);
            }
            #endregion

            #region creation of object
            Employee e1 = new Employee();
            e1.EmpId = 1;
            e1.Ename = "Tony Stark";
            e1.EAddress = "New York";

            Employee e2 = new Employee();
            e2.EmpId = 2;
            e2.Ename = "Peter Parker";
            e2.EAddress = "New York";

            Employee e3 = new Employee();
            e3.EmpId = 3;
            e3.Ename = "Steve Rogers";
            e3.EAddress = "New York";

            Employee[] e = new Employee[3];
            e[0] = e1;
            e[1] = e2;
            e[2] = e3;

            Console.WriteLine("\nObject creation using class\n");
            for (int i = 0; i < e.Length; i++)
            {
                //Console.WriteLine(e[i]); it gives fully qualified name as Collection.Program+Employee
                Console.WriteLine($"ID: {e[i].EmpId},Ename: {e[i].Ename}, Address: {e[i].EAddress}");
            }
            #endregion

            #region create array of objects using Object[] 
            Object[] obj = new object[5];
            obj[0] = 10;
            obj[1] = 20.10;
            obj[2] = "Sakshi";
            obj[3] = e1;
            Book b = new Book();
            b.BName = "The power of your Subconsious Mind";
            b.Author = "S.R.Chavan";
            obj[4] = b;

            Console.WriteLine("\ncreate array of objects using Object[]\n");
            for (int i = 0; i < obj.Length; i++)
            {
                Object obj1 = obj[i];
                if (obj1 is int)
                {
                    int j = Convert.ToInt32(obj1); //unboxing
                    Console.WriteLine($" value= {j}, Type= {j.GetType().ToString()}");
                }
                if (obj1 is double)
                {
                    double j = Convert.ToDouble(obj1); //unboxing
                    Console.WriteLine($"value= {j}, Type= {j.GetType().ToString()}");
                }
                if (obj1 is string)
                {
                    string str1 = obj1.ToString(); //unboxing
                    Console.WriteLine($"value={str1}, Type = {str1.GetType().ToString()}");
                }
                if (obj1 is Employee)
                {
                    //Employee emp = (Employee) obj1; you can write both way
                    Employee emp = obj1 as Employee;
                    Console.WriteLine($"Id: {emp.EmpId}, Name: {emp.Ename}, Address: {emp.EAddress}");
                }
                if (obj1 is Book)
                {
                    Book book = obj1 as Book;
                    Console.WriteLine($"Book Name: {book.BName}, Author: {book.Author}");
                }
            }
            #endregion

            #region ArrayList Non-Generic Collection
            //This is object type collection, its size is dynamic in nature, means grows and shrinks at runtime
            Console.WriteLine("\n ArrayList Non-Generic Collection\n");
            ArrayList arrList = new ArrayList();
            arrList.Add(1);
            arrList.Add("Sakshi");
            arrList.Add(e1); //Employee
            arrList.Add(b); //Book
            arrList.Add(10.20); //Boxing

            for (int i = 0; i < arrList.Count; i++)
            {
                Object obj3 = arrList[i]; //value in the object form
                if (obj3 is int)
                {
                    int j = Convert.ToInt32(obj3);
                    Console.WriteLine($"value: {j}");
                }

                if (obj3 is double)
                {
                    double j = Convert.ToDouble(obj3);
                    Console.WriteLine($"value: {j}");
                }

                if (obj3 is string)
                {
                    string str1 = obj3.ToString();
                    Console.WriteLine($"value: {str1}");
                }

                if (obj3 is Employee)
                {
                    Employee emp = obj3 as Employee;
                    Console.WriteLine($"Id: {emp.EmpId}, Name: {emp.Ename}, Address: {emp.EAddress}");
                }

                if (obj3 is Book)
                {
                    Book b1 = obj3 as Book;
                    Console.WriteLine($"Book Name: {b1.BName}, Author: {b1.Author}");
                }
            }
            #endregion

            #region List Generic Collection
            Console.WriteLine("\nList Generic Collection\n");
            List<int> list = new List<int>();
            list.Add(1);
            list.Add(2);
            list.Add(5);
            list.Add(8);

            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }
            #endregion

            #region Hashtable non-generic collection
            Console.WriteLine("Hashtable non-generic collection");
            Hashtable ht = new Hashtable();
            ht.Add(1, "Sakshi");
            ht.Add("Surname", "Patil");
            ht.Add(2, 23.33);
            ht.Add(3, e1);

            Console.WriteLine("Keys:-----------------");
            foreach (Object key in ht.Keys)
            {
                Console.WriteLine(key);
            }

            Console.WriteLine("Values:-----------------");
            foreach (Object value in ht.Values)
            {
                Console.WriteLine(value);
            }

            foreach (Object key in ht.Keys)
            {
                Console.WriteLine($"key: {key}, value: {ht[key]}");
            }
            #endregion

            #region Tuple
            Console.WriteLine("\nTuple\n");
            var details = Display(10, "Sakshi", 90);
            Console.WriteLine($"Id: {details.Id} Name:{details.Name} Mark:{details.Marks}");
            #endregion
        }

        #region Tuple return
        public static (int Id, string Name, Double Marks) Display(int id, string name, double marks)
        {
            //int id = this.id; you can not use
            int Id = id;
            string Name = name;
            double Marks = marks;
            return (id, Name, Marks);
        }
        #endregion


    }

        public class Employee
        {
            private int _EmpId;
            private string _EName;
            private string _EAddress;

            
            public int EmpId
            {
                set { _EmpId = value; }
                get { return _EmpId; }
            }

            public string Ename
            {
                set { _EName = value; }
                get { return _EName; }
            }

            public string EAddress
            {
                set { _EAddress = value; }
                get { return _EAddress; }
            }

            public override string ToString()
            {
                return $"EmpNo {EmpId}, Enmae:{Ename}, Eaddress:{EAddress}";
            }
        }

        public class Book
        {
            private string _BName;
            private string _Author;

            public string BName
            {
                set {  _BName = value; }
                get { return _BName; }
            }

            public string Author
            {
                set {  _Author = value; }
                get { return _Author; }
            }

            public override string ToString()
            {
                return $"BNAme: {BName},Author: {Author}";
            }
        }
}
