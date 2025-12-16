namespace Virtual_OverrideInInheritance
{
    public class Animal
    {
        public virtual void speaks()
        {
            Console.WriteLine("Animal Speaks");
        }
    }

    public class Dog : Animal
    {
        public override void speaks()
        {
            Console.WriteLine("Dog Barks");
        }
    }
    internal class TestAnimal
    {
        static void Main(string[] args)
        {
            Animal a = new Dog();
            a.speaks();
        }
    }
}
