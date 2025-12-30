namespace Extension_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Extension Methods
            int[] arr = { 1, 2, 3, 4, 5 };
            var result = arr.Sum();
            Console.WriteLine(result);
            #endregion

            #region Demo1
            /*Console.WriteLine("Enter your EmailID : ");
            string? email = Console.ReadLine();

            if(email != null)
            {
                if (email.CheckForValidateEmail())
                {
                    Console.WriteLine("Valid Email");
                }
                else
                {
                    Console.WriteLine("Invalid Email");
                }
            }*/
            #endregion

            #region Demo2
            int[] arr1 = {1, 2, 3, 4, 5, 6};
            string[] str2 = { "Steve", "Billy", "Will", "Erica" };

            //List<int> list = arr1.ConvertToList(1234);
            List<string> list = str2.ConvertToList(5678);
            foreach(var i in list)
            {
                Console.WriteLine(i);
            }
            #endregion
        }
    }

    public static class MyExtensionMethod
    {
        public static bool CheckForValidateEmail(this string email)
        {
            return email.Contains("@gmail.com");
        }

        public static List<T> ConvertToList<T>(this IEnumerable<T> source, int N)
        {
            List<T> list = new List<T>();
            foreach(var item in source)
            {
                list.Add(item);
            }
            return list;
        }
    }
}
