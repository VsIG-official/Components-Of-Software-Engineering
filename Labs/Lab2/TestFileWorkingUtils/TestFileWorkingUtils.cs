using IIG.Core.FileWorkingUtils;
using Xunit;

namespace TestFileWorkingUtils
{
	/// <summary>
	/// This class contain all tests for
	/// library IIG.Core.FileWorkingUtils
	/// </summary>
	public class TestFileWorkingUtils
	{
		/*
		  Naming:
		  1. The name of the method being tested.
		  2. The scenario under which it's being tested.
		  3. The expected behavior when the scenario is invoked.
		*/

		/// <summary>
		/// Test public property FilePath
		/// Check if we get exact string as it is in constructor
		/// </summary>
		[Fact]
		public void FilePath_None_ReturnsSameString()
		{
			// Arrange
			const string FULL_PATH = "D:/ForStudy/Components-Of-" +
				"Software-Engineering/Labs/Lab2/Lab2/TempFile.txt";
			FileWorker worker = new(FULL_PATH);

			string expected = worker.FilePath;

			// Act
			string actual = "D:/ForStudy/Components-Of-" +
				"Software-Engineering/Labs/Lab2/Lab2/TempFile.txt";

			// Assert
			Assert.Equal(actual, expected);
		}

		/// <summary>
		/// Test public method GetFileName
		/// Check if we get exact string as it is in constructor
		/// </summary>
		[Fact]
		public void GetFileNameFromConstructor_None_ReturnsSameString()
		{
			// Arrange
			const string FULL_PATH = "D:/ForStudy/Components-Of-" +
				"Software-Engineering/Labs/Lab2/Lab2/TempFile.txt";
			FileWorker worker = new(FULL_PATH);

			string expected = worker.GetFileName();

			// Act
			string actual = "TempFile.txt";

			// Assert
			Assert.Equal(actual, expected);
		}

		/// <summary>
		/// Test public method GetFileName
		/// Check if we get exact string as it is in constructor
		/// </summary>
		[Fact]
		public void GetFileNameFromClass_None_ReturnsSameString()
		{
			// Arrange
			const string FULL_PATH = "D:/ForStudy/Components-Of-" +
				"Software-Engineering/Labs/Lab2/Lab2/TempFile.txt";

			string expected = FileWorker.GetFileName(FULL_PATH);

			// Act
			string actual = "TempFile.txt";

			// Assert
			Assert.Equal(actual, expected);
		}
	}
}
