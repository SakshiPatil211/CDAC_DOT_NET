namespace OberserverPattern
{
    public delegate void NotificationDelegate(string message);
    internal class Program
    {
        static void Main(string[] args)
        {
            Subscriber subscriber = new Subscriber();
            Publisher publisher = new Publisher();

            //coupling
            publisher.Notify += new NotificationDelegate(subscriber.MethodA);
            //publisher.Notify += subscriber.MethodA;
            publisher.Notify += subscriber.MethodB;

            publisher.NotifySubscriber("The Grand Sale is UP! Upto 70% off on selected products!");

            //decoupling
            publisher.Notify -= subscriber.MethodA;

            publisher.NotifySubscriber("Sale is up to end");
            
        }
    }
    public class Subscriber
    {
        public void MethodA(string message)
        {
            Console.WriteLine($"MethodA recived sms: {message}");
        }

        public void MethodB(string message)
        {
            Console.WriteLine($"MethodB received email: {message}");
        }
    }
    public class Publisher
    {
        public event NotificationDelegate Notify;

        public void NotifySubscriber(string message)
        {
            //Notify(message);
            //you can write this way also
            Notify.Invoke(message);
        }
    }
}
