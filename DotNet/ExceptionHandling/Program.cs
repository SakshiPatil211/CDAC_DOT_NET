
namespace ExceptionHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter number 1 : ");
                int n1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter number 2 : ");
                int n2 = Convert.ToInt32(Console.ReadLine());

                if (n2 == 0)
                {
                    Console.WriteLine("Don't write second number as 0!");
                }

                int divResult = n1 / n2;
                Console.WriteLine($"Result : {divResult}");
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            //catch(DivideByZeroException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}

            //catch(MyCustomException obj)
            //{
            //    Console.WriteLine(obj.Message);
            //}


        }
    }

    public class MyCustomException : Exception
    {
        public string MyMessage { get; set; }
        public MyCustomException(string msg) {
            MyMessage = msg;
        }
    }
}
