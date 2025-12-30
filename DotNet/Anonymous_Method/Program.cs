namespace Anonymous_Method
{
    public delegate bool MyDelegate(int num);
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int no = Convert.ToInt32(Console.ReadLine());

            #region Normal Method Call
            /*var result = Check(no);
            if (result)
            {
                Console.WriteLine($"{no} is greater than 10");
            }
            else
            {
                Console.WriteLine($"{no} is not greater than 10");
            }*/
            #endregion

            #region Anonymous method
            /*MyDelegate del = new MyDelegate(delegate (int num) 
                                                     { 
                                                         return num > 10; 
                                                     });*/

            MyDelegate del = delegate (int num)
                                     {
                                         return num > 10;
                                     };

            /*var result1 = del(11);
            if (result1)
            {
                Console.WriteLine($"{no} is greater than 10");
            }
            else
            {
                Console.WriteLine($"{no} is not greater than 10");
            }*/
            #endregion

            #region Lambda Expression
            //MyDelegate del2 = (int num) => { return num > 10; };
            /*MyDelegate del2 = num => num > 10;
            var result2 = del2(no);
            if (result2)
            {
                Console.WriteLine($"{no} is greater than 10");
            }
            else
            {
                Console.WriteLine($"{no} is not greater than 10");
            }*/
            #endregion

            #region Predicate
            /*Predicate<int> pred = num => num > 10;
            var result3 = pred(2);
            if (result3)
            {
                Console.WriteLine($"{no} is greater than 10");
            }
            else
            {
                Console.WriteLine($"{no} is not greater than 10");
            }*/
            #endregion

        }

        public static bool Check(int num)
        {
            return num > 10;
        }
    }
}
