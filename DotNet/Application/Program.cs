
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace Application
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string asmPath = @"C:\Users\IET\Desktop\250845920071\CDAC_DOT_NET\DotNet\EmployeeLib\Emp.cs";

            Assembly asm = Assembly.LoadFrom(asmPath);
            Type[] allTypes = asm.GetTypes();
            for (int i = 0; i < allTypes.Length; i++)
            {
                Type type = allTypes[i];
                //Console.WriteLine(type.Name);
                Attribute[] allAttributes = type.GetCustomAttributes().ToArray();
                for (int j = 0; j < allAttributes.Length; j++)
                {
                    Attribute attr = allAttributes[j];
                    if (attr is BVS)
                    {
                        BVS bvsAttr = attr as BVS;

                        Console.WriteLine($"Class {type.Name} is developed by {bvsAttr.DeveloperName} of (c) {bvsAttr.CompanyName}");
                    }

                    if (attr is SerializableAttribute)
                    {
                        Console.WriteLine($"Class {type.Name} is marked as Serializable");
                    }
                }
            }

        }
    }
}
