using System;
using System.Threading;

namespace Event
{
    public delegate void MyDelegate(object sender, int value);

    public class Publisher
    {
        public event MyDelegate? MyEvent;

        public void DoSomething(int value)
        {
            Console.WriteLine("Doing Something first...");
            Thread.Sleep(3000);
            // Trigger the event
            MyEvent?.Invoke(this,value);
        }
    }

    public class Subscriber
    {
        public void HandleEvent(object sender, int value)
        {
            Console.WriteLine("Event handled: " + value);
        }
    }

    public class nextSubscriber
    {
        public void nextEventHandler(object sender, int value)
        {
            Console.WriteLine("Next Event handled: value+10 is " + (value + 10));
        }
    }

    class Program
    {
        static void Main()
        {
            var publisher = new Publisher();
            var subscriber = new Subscriber();
            var newsubs = new nextSubscriber();

            publisher.MyEvent += subscriber.HandleEvent;
            publisher.MyEvent += newsubs.nextEventHandler;

            publisher.DoSomething(42); // This will invoke HandleEvent(42)
        }
    }
}
