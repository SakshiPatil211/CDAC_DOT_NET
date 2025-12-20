using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Xml.Serialization;

namespace XMLJSONSerialization
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"C:\Users\IET\Desktop\250845920071\CDAC_DOT_NET\DotNet\XMLJSONSerialization\files\demo1.xml";
            string filePath1 = @"C:\Users\IET\Desktop\250845920071\CDAC_DOT_NET\DotNet\XMLJSONSerialization\files\demo2.json";

            XMLWrite(filePath);
            XMLRead(filePath);
            JSONWrite(filePath1);
            JSONRead(filePath1);



        }
        public static void XMLWrite(string filePath)
        {
            Emp emp = new Emp();
            emp.Id = 101;
            emp.Name = "Tony Stark";
            emp.Address = "New York";

            Type type = emp.GetType();
            XmlSerializer xr = new XmlSerializer(type);

            FileStream fs = null;

            if (File.Exists(filePath))
            {
                fs = new FileStream(filePath, FileMode.Append, FileAccess.Write);
            }
            else
            {
                fs = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.Write);
            }

            xr = new XmlSerializer(typeof(Emp));
            xr.Serialize(fs, emp);
            fs.Close();
            Console.WriteLine("Done");
        }

        public static void XMLRead(string filePath)
        {
            FileStream fs = null;

            if (File.Exists(filePath))
            {
                fs = new FileStream(filePath, FileMode.Open, FileAccess.Read);
            }
            else
            {
                Console.WriteLine("File does not exist!");
            }

            XmlSerializer xr = new XmlSerializer(typeof(Emp));
            Emp empData = xr.Deserialize(fs) as Emp;
            fs.Close();
            Console.WriteLine($"Id = {empData.Id}, Name = {empData.Name}, Address= {empData.Address}");
        }
        public static void JSONWrite(string filePath1)
        {
            Emp emp = new Emp();
            emp.Id = 101;
            emp.Name = "Tony Stark";

            emp.Address = "New York";
            FileStream fs = null;

            if (File.Exists(filePath1))
            {
                fs = new FileStream(filePath1, FileMode.Append, FileAccess.Write);
            }
            else
            {
                fs = new FileStream(filePath1, FileMode.OpenOrCreate, FileAccess.Write);
            }

            JsonSerializer.Serialize<Emp>(fs, emp);
            fs.Close();
            Console.WriteLine("Done");
        }

        public static void JSONRead(string filePath1)
        {
            FileStream fs = null;

            if (File.Exists(filePath1))
            {
                fs = new FileStream(filePath1, FileMode.Open, FileAccess.Read);
            }
            else
            {
                Console.WriteLine("File does not exist!");
            }

            Emp empData = JsonSerializer.Deserialize<Emp>(fs);
            fs.Close();
            Console.WriteLine($"Id = {empData.Id}, Name = {empData.Name}, Address= {empData.Address}");
        }
    }

    public class Emp
    {
        private int _Id;
        private string _Name;
        private string _Address;

        [XmlIgnore]
        [JsonIgnore]
        public string Address
        {
            get { return _Address; }
            set { _Address = value; }
        }
        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }
        public int Id
        {
            get { return _Id; }
            set { _Id = value; }
        }

    }
}
