namespace Datatypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Datatypes");
            int x = 10; // Value Type
            String str = "Hello World"; //Reference Type
            str = Convert.ToString(x); //Boxing
            string str2 = x.ToString(); //Boxing
            Console.WriteLine(x);
            Console.WriteLine(str);

            //Type Casting
            double d = 9.78;
            Console.WriteLine(d);   
            int num1 = Convert.ToInt32(d); //Explicit Typecasting
            Console.WriteLine(num1);
            double d2 = num1; //Implicit Typecasting
            Console.WriteLine(d2);
        }
    }
}
