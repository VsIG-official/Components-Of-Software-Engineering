using System;
using Xunit;
using IIG.Core.FileWorkingUtils;

namespace TestFileWorkingUtils
{
	public class UnitTest1
	{
		[Fact]
		public void Test1()
		{
			FileWorker worker = new FileWorker("Labs/Lab2/Lab2/TempFile.txt");
		}
	}
}
