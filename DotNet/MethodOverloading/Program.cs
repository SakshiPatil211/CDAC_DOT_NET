namespace MethodOverloading
{
    #region MyMath class
    public class MyMath
    {
        public void add(int a, int b, int c)
        {
            Console.WriteLine("In add function of MyMath {0} ", a + b + c);
        }
        public void add(int a, int b)
        {
            Console.WriteLine("In add function of MyMath {0} ", a + b);

        }
    }
    #endregion

    #region MyMath2 class
    public class MyMath2 : MyMath
    {
        public new void add(int a, int b)
        {
            Console.WriteLine("In add function of MyMath2 {0} ",a + b);
        }
    }
    #endregion

    internal class TestMyMath
    {
        static void Main(string[] args)
        {
            MyMath2 m = new MyMath2();
            m.add(1, 5, 6);
            m.add(3, 6); 
            m.add(5, 7);
        }
    }
}
