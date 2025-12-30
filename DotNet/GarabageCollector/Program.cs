namespace GarabageCollector
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //one way: here we have call the Dispose()
            MyClass obj = new MyClass();
            obj.SayHi();
            obj.Dispose();

            //Another Way: here we not call the Dispose method at the end of the using block Despose() called
            Console.WriteLine("---------using()--------");
            using (MyClass obj1 = new MyClass())
            {
                obj1.SayHi();
            }

            Console.WriteLine(GC.MaxGeneration);
            Console.WriteLine("obj generation "+GC.GetGeneration(obj));
            

        }
    }

    public class MyClass : IDisposable
    {
        public void Dispose()
        {
            Console.WriteLine("GC method called");
            GC.SuppressFinalize(this);
        }

        public void SayHi()
        {
            Console.WriteLine("Hellooo");
        }
    }
}
