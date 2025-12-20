using System.Runtime.Serialization.Formatters.Binary;

namespace BinarySerialization
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"C:\Users\IET\Desktop\250845920071\CDAC_DOT_NET\DotNet\FileIO\files\demo2.txt";
            WriteObjectIntoFile(filePath);
            ReadObjectFromFile(filePath);
        }

        public static void WriteObjectIntoFile(string filePath)
        {
            Employee emp = new Employee();
            emp.Id = 101;
            emp.Name = "Tony Stark";
            emp.Salary = 50000;

            FileStream fs = null;
            if(File.Exists(filePath))
            {
                fs = new FileStream(filePath, FileMode.Append, FileAccess.Write);
            }
            else
            {
                fs = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.Write);
            }

            BinaryWriter writer= new BinaryWriter(fs);
            writer.Write(emp.Id);
            writer.Write(emp.Name);
            writer.Write(emp.Salary);
            fs.Close();
        }

        public static void ReadObjectFromFile(string filePath)
        {
            Employee emp = new Employee();
            emp.Id = 101;
            emp.Name = "Tony Stark";
            emp.Salary = 50000;

            FileStream fs = null;
            if (File.Exists(filePath))
            {
                fs = new FileStream(filePath, FileMode.Open, FileAccess.Read);
            }
            else
            {
                Console.WriteLine("file does not exists");
            }

            BinaryReader reader = new BinaryReader(fs);
            int id = reader.ReadInt32();
            string name = reader.ReadString();
            double salary = reader.ReadDouble();
            fs.Close();
            Console.WriteLine($"Id: {id} Name: {name} Salary: {salary}");
        }
    }

    [Serializable]
    public class Employee
    {
        private int id;
        private string name;
        private double salary;

        public int Id
        {
            set
            {
                id = value;
            }
            get
            {
                return id;
            }
        }
        public string Name
        {
            set { name = value; }
            get { return name; }
        }
        public double Salary
        {
            set
            {
                salary = value;
            }
            get
            {
                return salary;
            }
        }
    }
}
