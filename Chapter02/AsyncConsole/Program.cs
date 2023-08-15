/*HttpClient client = new();    //target-typed new
HttpResponseMessage response = await client.GetAsync("https://apple.com");
WriteLine("Apple's homepage has {0:N0} bytes.", response.Content.Headers.ContentLength);
*/
// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

using System.Threading.Tasks;
public class Program
{

    static void Main(string[] args)
    {
        Task t1 = new Task(PrintInfo);
        t1.Start();
        Console.WriteLine("Main Thread Completed");
        Console.ReadLine();
    }

    static void PrintInfo()
    {
        for (int i = 1; i <= 5; i++)
        {
            Console.WriteLine("i value: {0}", i);
        }

        Console.WriteLine("Child Thread Completed");
    }
}
