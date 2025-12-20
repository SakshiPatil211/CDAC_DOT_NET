namespace FileIO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"C:\Users\IET\Desktop\250845920071\CDAC_DOT_NET\DotNet\FileIO\files\demo1.txt";

            WriteIntoFile(filePath);
            ReadFromFile(filePath);
        }

        public static void WriteIntoFile(string filePath)
        {
            FileStream fs = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter writer = new StreamWriter(fs);
            writer.WriteLine("Hello, Sakshi Patil");
            writer.Flush();
            writer.Close();
            fs.Close();
            Console.WriteLine("Write into file");
        }

        public static void ReadFromFile(string filePath)
        {
            FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(fs);
            string line = reader.ReadToEnd();
            reader.Close();
            fs.Close();
            Console.WriteLine(line);
        }


    }
}
