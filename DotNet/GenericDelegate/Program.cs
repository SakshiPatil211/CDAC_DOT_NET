namespace GenericDelegate
{
    public delegate void DelegateHi();
    public delegate void DelegateHello<T>(T msg);
    public delegate void DelegateGreet<T1, T2>(T1 str1, T2 str2);
    public delegate int DelegateDisplay<T>(T num);
    public delegate bool DelegateEven<T>(T num1);
    public delegate bool DelegateOdd<T>(T num1);
    public delegate int DelegateAdd<T>(T[] arr);
    public delegate int DelegateAdd3<T>(params T[] arr);
    public delegate int DelegateAdd1<T1, T2, T3>(T1 n1, T2 n2, T3 n3);
    internal class Program
    {
        static void Main(string[] args)
        {
            MyMath m = new MyMath();
            DelegateHi del1 = m.SayHi;
            del1();

            DelegateHello<string> del2 = m.SayHello;
            del2("Thor");

            DelegateGreet<string, string> del3 = m.Greet;
            del3("I am ", "Groot!");

            DelegateDisplay<int> del4 = m.Display;
            Console.WriteLine(del4(5));

            DelegateEven<int> del5 = m.CheckEven;
            Console.WriteLine(del5(10));

            DelegateOdd<int> del6 = m.CheckOdd;
            Console.WriteLine(del6(10));

            int[] arr = { 1, 2, 3, 4, 5};
            DelegateAdd<int> del7 = m.Add;
            Console.WriteLine(del7(arr));

            DelegateAdd3<int> del8 = m.Add3;
            Console.WriteLine(del8(1,2,3,4,5,6));

            DelegateAdd1<int, int ,int> del9 = m.Add1;
            Console.WriteLine(del9(12, 34, 45));
        }
    }

    public class MyMath
    {
        public void SayHi()
        {
            Console.WriteLine("Hi from math");
        }

        public void SayHello(string msg)
        {
            Console.WriteLine($"Hello, {msg}");
        }

        public void Greet(string str1, string str2)
        {
            Console.WriteLine($"Hey, {str1} {str2}");
        }

        public int Display(int x)
        {
            return x;
        }

        public bool CheckEven(int number)
        {
            return number % 2 == 0;
        }

        public bool CheckOdd(int number)
        {
            return number % 2 != 0;
        }

        public int Add(int[] numbers)
        {
            int sum = 0;
            foreach (var num in numbers)
            {
                sum += num;
            }
            return sum;
        }
        public int Add3(int[] numbers)
        {
            int sum = 0;
            foreach (var num in numbers)
            {
                sum += num;
            }
            return sum;
        }
        public int Add1(int n1, int n2, int n3)
        {
            int sum = n1 + n2 + n3;
            return sum;
        }

        public void Add2(int n1, int n2, int n3, out int sum)
        {
            sum = n1 + n2 + n3;
        }
    }
}
