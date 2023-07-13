using System;

namespace Event
{
    public delegate void MyDelegate(int value);

    public class Publisher
    {
        public event MyDelegate? MyEvent;

        public void DoSomething(int value)
        {
            // Trigger the event
            MyEvent?.Invoke(value);
        }
    }

    public class Subscriber
    {
        public void HandleEvent(int value)
        {
            Console.WriteLine("Event handled: " + value);
        }
    }

    class Program
    {
        static void Main()
        {
            var publisher = new Publisher();
            var subscriber = new Subscriber();

            publisher.MyEvent += subscriber.HandleEvent;

            publisher.DoSomething(42); // This will invoke HandleEvent(42)
        }
    }
}
