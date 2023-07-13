namespace Delegate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyClass obj = new MyClass();
            obj.LongRunning(Call);
        }
        static void Call(int i)
        {
            Console.WriteLine(i);
        }
    }

    public class MyClass
    {
        public delegate void CallBack(int i);
        public void LongRunning(CallBack obj1)
        {
            for (int i=0; i<10000; i++)
            {
                obj1(i);   //this is equivalent to Call(i);
            }

        }
    }
}

/*
 Here's how the delegate is utilized in the code:

1. The CallBack delegate is declared within the MyClass class. It defines the signature of a method that takes an integer parameter (int i) and returns void.

2. The LongRunning method in the MyClass class takes an instance of the CallBack delegate as a parameter (CallBack obj1). This allows the method to accept any method that matches the defined delegate signature.

3. Inside the LongRunning method, the provided callback method (obj1) is invoked during each iteration of the for loop, passing the current iteration value as an argument.

By using the delegate, the LongRunning method becomes more flexible and reusable. It can accept different callback methods that conform to the delegate's signature, allowing for custom logic to be executed during the long-running operation. The delegate acts as a contract, ensuring that the provided callback method adheres to the specified signature.

In the given code, the delegate provides a way to decouple the LongRunning method from the specific implementation of the callback logic. It allows different callback methods to be passed to the method dynamically, enabling customization and extensibility.
*/