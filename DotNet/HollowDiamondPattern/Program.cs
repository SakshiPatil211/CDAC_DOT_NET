namespace HollowDiamondPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 9;
            int mid = n / 2;

            // Upper half
            for (int i = 0; i <= mid; i++)
            {
                Console.Write(new string(' ', mid - i));
                Console.Write("*");
                if (i > 0)
                {
                    Console.Write(new string(' ', 2 * i - 1));
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            // Lower half
            for (int i = mid - 1; i >= 0; i--)
            {
                Console.Write(new string(' ', mid - i));
                Console.Write("*");
                if (i > 0)
                {
                    Console.Write(new string(' ', 2 * i - 1));
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
