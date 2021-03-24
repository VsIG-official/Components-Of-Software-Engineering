using IIG.Core.FileWorkingUtils;
using Xunit;

namespace TestFileWorkingUtils
{
	/// <summary>
	/// This class contain all tests for
	/// library IIG.Core.FileWorkingUtils
	/// </summary>
	public class UnitTest1
	{
		/// <summary>
		/// Test public property FilePath
		/// Check if we get exact string as it is in constructor
		/// </summary>
		[Fact]
		public void FilePath_Get_ReturnsSameString()
		{
			// Arrange
			const string FULL_PATH = "D:/ForStudy/Components-Of-" +
				"Software-Engineering/Labs/Lab2/Lab2/TempFile.txt";
			FileWorker worker = new(FULL_PATH);

			// Act
			string actual = "D:/ForStudy/Components-Of-" +
				"Software-Engineering/Labs/Lab2/Lab2/TempFile.txt";

			// Assert
			Assert.Equal(actual, worker.FilePath);
		}
	}
}
