namespace Interface1
{
    // Implicit Implementation of Interface
    //public interface IDrink
    //{
    //    void GetDrink();
    //}

    //public class ColdDrink : IDrink
    //{
    //    public void GetDrink()
    //    {
    //        Console.WriteLine("Enjoy your cold drink!!!");
    //    }
    //}

    //public class HotDrink : IDrink
    //{
    //    public void GetDrink()
    //    {
    //        Console.WriteLine("Enjoy your hot drink!!!");
    //    }
    //}


    // Explicit Implementation of Interface

    #region Interface IX IY

   
    public interface IX
    {
        int add(int a, int b);
        int sub(int a, int b);
    }
    public interface IY
    {
        int add(int a, int b);
        int mul(int a, int b);
    }
    #endregion

    public class MyMath : IX, IY
    {
        int IX.add(int a, int b)
        {
            return a + b;
        }
        int IX.sub(int a, int b)
        {
            return a - b;
        }
        int IY.add(int a, int b)
        {
            return a + b;
        }
        int IY.mul(int a, int b)
        {
            return a * b;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            //IDrink d1 = new ColdDrink();
            //d1.GetDrink();
            //IDrink d2 = new HotDrink();
            //d2.GetDrink();

            IX xObj = new MyMath();
            Console.WriteLine(xObj.add(1, 2));
            Console.WriteLine(xObj.sub(7, 2));
            IY yObj = new MyMath();
            Console.WriteLine(yObj.add(8, 3));
            Console.WriteLine(yObj.mul(6, 7));
        }
    }

}
