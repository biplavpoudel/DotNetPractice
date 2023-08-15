using System.Diagnostics;
using System.Threading.Tasks;

namespace TaskandAsync
{
    internal class Program
    {
            static async Task Main(string[] args)
            {
                await TestMethodAsync();
                //Console.ReadLine();
            }

            public static async Task TestMethodAsync()
            {
                Task<string> processTask = Process();
                // independent work which doesn't need the result of long Process
           
                Console.WriteLine("executed");

                //and now call await on the task
                string result = await processTask;
                //use the result
                Console.WriteLine(result);
                Console.Write("All processes executed at last");
            }
            public static async Task<string> Process() // returns an string from this long running operation
            {
                await Task.Delay(2000); // 2 second delay
                return "Process complete";
            }
    }
}