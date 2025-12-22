using CSharpFeatures;

namespace CSharpFeatures
{
    internal class MathPartial
    {
        static void Main(string[] args)
        {
           CMath math = new CMath();
            Console.WriteLine($"Addition {math.Add(5, 59)}");
            Console.WriteLine($"Multiplication {math.Multiply(5,5)}");
        }
    }
}
