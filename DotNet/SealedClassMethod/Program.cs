namespace SealedClassMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CMath c1 = new CMath();
            Console.WriteLine(c1.Add(10, 20));
            c1.Sub(10, 20);

            AdvanceMath a = new MyMath1();
            a.Square(10);
            //a.SayHi();


        }
    }

    public sealed class CMath
    {
        public int Add(int x, int y)
        {
            return x + y;
        }

        public int Sub(int x, int y)
        {
            return x - y;
        }
    }

    public class AdvanceMath //:CMath not allowed
    {
        public virtual int Square(int x)
        {
            return x * x;
        }
    }

    public class MyMath1: AdvanceMath
    {
        public sealed override int Square(int x)
        {
            return x * x*100;
        }

        public virtual void SayHi()
        {
            Console.WriteLine("Hello");
        }
    }

    public class MyMath2: MyMath1
    {
        public override void SayHi()
        {
            Console.WriteLine("Hello Steve Rogers");
        }


        /* Not allowed because method is sealed and only one time modification is allowed */
        //public override int Square(int x)
        //{
        //    return x * x * 100;
        //}
    }
}
