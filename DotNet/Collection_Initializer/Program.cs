namespace Collection_Initializer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Old Way
            int[] arr = new int[3];
            arr[0] = 1;
            arr[1] = 2;
            arr[2] = 3;

            // New way
            int[] arr2 = new int[] { 1, 2, 3, 4 };
            foreach(int i in arr2)
            {
                Console.WriteLine(i);
            }

            string[] arr3 = new string[] { "Tony Stark", "Thor", "Loki", "Black Widow" };
            foreach(string str in arr3)
            {
                Console.WriteLine(str);
            }

            List<Demo> demoLst = new List<Demo>()
            {
                new Demo() { _Id = 1, _Name = "Hugh Jackman", _Description = "Australian Actor" },
                new Demo() { _Id = 2, _Name = "Tom Ellis", _Description = "Wellish Actor" }
            };
            foreach(Demo demo in demoLst)
            {
                Console.WriteLine($"Id = {demo._Id} Name = {demo._Name} Description = {demo._Description}");
            }
        }
    }

    public class Demo
    {
        public int _Id;
        public string _Name;
        public string _Description;
    }
}
