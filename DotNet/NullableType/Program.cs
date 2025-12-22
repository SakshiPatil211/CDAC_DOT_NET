namespace NullableType
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // First way
            string name = null;
            //int deptId = null; // Compile time error
            int? deptId = null;
            int? empId = null;

            if (empId.HasValue)
            {
                Console.WriteLine($"Value {empId.Value}");
            }
            else
            {
                Console.WriteLine("Null Value");
                // Console.WriteLine($"Value {empId.Value}"); you can't access null value
            }


            // Second way
            Nullable<int> Id = null;
            if (Id.HasValue)
            {
                Console.WriteLine($"Value {Id.Value}");
            }
            else
            {
                Console.WriteLine("Null Value");
                // Console.WriteLine($"Value {Id.Value}"); you can't access null value
            }

        }
    }
}
