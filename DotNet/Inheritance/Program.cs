namespace Inheritance
{
    public class Vehicle {
        public void startEngine()
        {
            Console.WriteLine("Engine has Started");
        }
    }

    public class Car : Vehicle
    {
        public void accelerate()
        {
            Console.WriteLine("Vehicle is Accelerating");
        }
    }

    public class SportsCar : Car 
    { 
        public void drift()
        {
            Console.WriteLine("Sports Car is Drifiting");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            SportsCar MySportsCar = new SportsCar();
            MySportsCar.startEngine();
            MySportsCar.accelerate();   
            MySportsCar.drift();
        }
    }
}
