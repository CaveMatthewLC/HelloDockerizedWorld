using NUnit.Framework;
using HelloDockerizedWorld;

namespace HelloDockerizedWorldTests
{
	[TestFixture]
	public class ProgramTests
	{
		[Test]
		public void OutputMessageTest()
		{
			string desiredOutputMessage = "Hello Dockerized World";

			string outputMessage = Program.GetOutputMessage();

			Assert.AreEqual(outputMessage, desiredOutputMessage);
		}
	}
}
