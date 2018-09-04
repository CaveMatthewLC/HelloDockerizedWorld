using System;

namespace HelloDockerizedWorld
{
	class Program
	{
		static void Main(string[] args)
		{
			string output = "Hello Dockerized World";

			Console.WriteLine(output);
			
			Logger.Warn("Warning: this may be running inside a Docker container");
		}
	}
}
