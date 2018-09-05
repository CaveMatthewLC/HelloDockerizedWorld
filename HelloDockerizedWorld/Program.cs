using System;

namespace HelloDockerizedWorld
{
	public class Program
	{
		static void Main(string[] args)
		{
			string output = GetOutputMessage();

			Console.WriteLine(output);
			
			Logger.Warn("Warning: this may be running inside a Docker container");
		}

		public static string GetOutputMessage()
		{
			return "Hello Doc World";
		}
	}
}
