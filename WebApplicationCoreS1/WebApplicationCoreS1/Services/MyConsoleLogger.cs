using WebApplicationCoreS1.Interfaces;

namespace WebApplicationCoreS1.Services
{
	public class MyConsoleLogger: ILog
	{
		public void info(string str)
		{
			Console.WriteLine(str);
		}
	}
}
