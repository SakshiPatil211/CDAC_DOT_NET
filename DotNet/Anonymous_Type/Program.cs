namespace Anonymous_Type
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var v1 = new { Id = 1, Name = "Sakshi", Address = "Kokarud" };
            Console.WriteLine(v1.GetType().ToString());

            var v2 = new { Id = 2, Name = "Tony Stark", Address = "NY" };
            Console.WriteLine(v2.GetType().ToString());

            var v3 = new { Id = 3, Address = "LA", Name = "Tom Ellis" };
            Console.WriteLine(v3.GetType().ToString());

            var v4 = new { Id = 4, Address = true, Name = "Kiran" };
            Console.WriteLine(v4.GetType().ToString());

            Console.WriteLine("Enter value for Id");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter value for name");
            string nm = Console.ReadLine();

            var v5 = new { Id = 5, Name = "Sakshi" };
            Console.WriteLine($"You entered: ID={v5.Id} Name={v5.Name} ");
        }

        public class Holder
        {
            public int? Id { get; set; }
            public string? Name { get; set; }
            public string? Address { get; set; }
        }
    }
}
