using System.Threading;

namespace Threading1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Threads are nameless
            Thread t = Thread.CurrentThread;
            Console.WriteLine(t.ManagedThreadId);
            Console.WriteLine(t.Name);
            #endregion

            #region Custom Threads and ThreadStart Delegate 
            Thread t1 = new Thread(Method1) { Name = "th 01" };
            Thread t2 = new Thread(Method1) { Name = "th 02" };
            Thread t3 = new Thread(Method1) { Name = "th 03" };

            t1.Start();
            t2.Start();
            t3.Start();
            #endregion

        }

        static void Method1()
        {
            Console.WriteLine("Method1----" +Thread.CurrentThread.Name);
            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine("Method1 "+i);
            }

            Console.WriteLine("Method1----" + Thread.CurrentThread.Name);
        }

        static void Method2()
        {
            Console.WriteLine("Method2----" + Thread.CurrentThread.Name);
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Method2 " + i);
            }

            Console.WriteLine("Method2----" + Thread.CurrentThread.Name);
        }

        static void Method3()
        {
            Console.WriteLine("Method3----" + Thread.CurrentThread.Name);
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Method3 " + i);
            }

            Console.WriteLine("Method3----" + Thread.CurrentThread.Name);
        }
    }
}
