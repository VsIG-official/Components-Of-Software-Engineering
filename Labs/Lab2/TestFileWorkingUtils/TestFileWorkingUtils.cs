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

		#region FilePath

		/// <summary>
		/// Test public property FilePath
		/// Check if we get exact string as it is in constructor
		/// </summary>
		[Fact]
		public void FilePath_None_ReturnsSameString()
		{
			// Arrange
			const string FULL_PATH = @"D:\ForStudy\Components-Of-" +
				@"Software-Engineering\Labs\Lab2\Lab2\TempFile.txt";
			FileWorker worker = new(FULL_PATH);

			string expected = worker.FilePath;

			// Act
			string actual = @"D:\ForStudy\Components-Of-" +
				@"Software-Engineering\Labs\Lab2\Lab2\TempFile.txt";

			// Assert
			Assert.Equal(actual, expected);
		}

		#endregion FilePath

		#region GetFileName

		/// <summary>
		/// Test public method GetFileName using constructor
		/// Check if we get correct name of the file
		/// </summary>
		[Fact]
		public void GetFileNameFromConstructor_None_ReturnsSameString()
		{
			// Arrange
			const string FULL_PATH = @"D:\ForStudy\Components-Of-" +
				@"Software-Engineering\Labs\Lab2\Lab2\TempFile.txt";
			FileWorker worker = new(FULL_PATH);

			string expected = worker.GetFileName();

			// Act
			string actual = "TempFile.txt";

			// Assert
			Assert.Equal(actual, expected);
		}

		/// <summary>
		/// Test public method GetFileName using class
		/// Check if we get correct name of the file
		/// </summary>
		[Fact]
		public void GetFileNameFromClass_Path_ReturnsSameString()
		{
			// Arrange
			const string FULL_PATH = @"D:\ForStudy\Components-Of-" +
				@"Software-Engineering\Labs\Lab2\Lab2\TempFile.txt";

			string expected = FileWorker.GetFileName(FULL_PATH);

			// Act
			string actual = "TempFile.txt";

			// Assert
			Assert.Equal(actual, expected);
		}

		#endregion GetFileName

		#region GetFullPath

		/// <summary>
		/// Test public method GetFullPath using constructor
		/// Check if we get correct full path to the file
		/// </summary>
		[Fact]
		public void GetFullPathFromConstructor_None_ReturnsSameString()
		{
			// Arrange
			const string FULL_PATH = @"D:\ForStudy\Components-Of-" +
				@"Software-Engineering\Labs\Lab2\Lab2\TempFile.txt";
			FileWorker worker = new(FULL_PATH);

			string expected = worker.GetFullPath();

			// Act
			string actual = FULL_PATH;

			// Assert
			Assert.Equal(actual, expected);
		}

		/// <summary>
		/// Test public method GetFullPath using class
		/// Check if we get correct full path to the file
		/// </summary>
		[Fact]
		public void GetFullPathFromClass_Path_ReturnsSameString()
		{
			// Arrange
			const string FULL_PATH = @"D:\ForStudy\Components-Of-" +
				@"Software-Engineering\Labs\Lab2\Lab2\TempFile.txt";

			string expected = FileWorker.GetFullPath(FULL_PATH);

			// Act
			string actual = FULL_PATH;

			// Assert
			Assert.Equal(actual, expected);
		}

		#endregion GetFullPath

		#region ReadAll

		#region ReadAllTXT

		/// <summary>
		/// Test public method ReadAll using constructor
		/// Check if we get correct string from txt file
		/// </summary>
		[Fact]
		public void ReadAllFromConstructor_None_ReturnsStringFromFileTXT()
		{
			// Arrange
			const string FULL_PATH = @"D:\ForStudy\Components-Of-" +
				@"Software-Engineering\Labs\Lab2\Lab2\TempFile.txt";
			const string STRING_FROM_FILE = "Some text for lab2\r\nSecond string";
			FileWorker worker = new(FULL_PATH);

			string expected = worker.ReadAll();

			// Act
			string actual = STRING_FROM_FILE;

			// Assert
			Assert.Equal(actual, expected);
		}

		/// <summary>
		/// Test public method ReadAll using class
		/// Check if we get correct string from txt file
		/// </summary>
		[Fact]
		public void ReadAllFromClass_Path_ReturnsStringFromFileTXT()
		{
			// Arrange
			const string FULL_PATH = @"D:\ForStudy\Components-Of-" +
				@"Software-Engineering\Labs\Lab2\Lab2\TempFile.txt";
			const string STRING_FROM_FILE = "Some text for lab2" +
				"\r\nSecond string";

			string expected = FileWorker.ReadAll(FULL_PATH);

			// Act
			string actual = STRING_FROM_FILE;

			// Assert
			Assert.Equal(actual, expected);
		}

		#endregion ReadAllTXT

		#region ReadAllMD

		/// <summary>
		/// Test public method ReadAll using constructor
		/// Check if we get correct string from md file
		/// </summary>
		[Fact]
		public void ReadAllFromConstructor_None_ReturnsStringFromFileMD()
		{
			// Arrange
			const string FULL_PATH = @"D:\ForStudy\Components-Of-" +
				@"Software-Engineering\Labs\Lab2\Lab2\TempFileMD.md";
			const string STRING_FROM_FILE = "Some text for lab2 MD" +
				"\r\nSecond string MD";
			FileWorker worker = new(FULL_PATH);

			string expected = worker.ReadAll();

			// Act
			string actual = STRING_FROM_FILE;

			// Assert
			Assert.Equal(actual, expected);
		}

		/// <summary>
		/// Test public method ReadAll using class
		/// Check if we get correct string from md file
		/// </summary>
		[Fact]
		public void ReadAllFromClass_Path_ReturnsStringFromFileMD()
		{
			// Arrange
			const string FULL_PATH = @"D:\ForStudy\Components-Of-" +
				@"Software-Engineering\Labs\Lab2\Lab2\TempFileMD.md";
			const string STRING_FROM_FILE = "Some text for lab2 MD" +
				"\r\nSecond string MD";

			string expected = FileWorker.ReadAll(FULL_PATH);

			// Act
			string actual = STRING_FROM_FILE;

			// Assert
			Assert.Equal(actual, expected);
		}

		#endregion ReadAllMD

		#region ReadAllXML

		/// <summary>
		/// Test public method ReadAll using constructor
		/// Check if we get correct string from xml file
		/// </summary>
		[Fact]
		public void ReadAllFromConstructor_None_ReturnsStringFromFileXML()
		{
			// Arrange
			const string FULL_PATH = @"D:\ForStudy\Components-Of-" +
				@"Software-Engineering\Labs\Lab2\Lab2\TempFileXML.xml";

			const string STRING_FROM_FILE = "<?xml version=\"1.0\"" +
				"?>\n<Text>\n      <FirstText>Some text for lab2 " +
				"XML</FirstText>\n      <SecondText>Second string " +
				"XML</SecondText>\n</Text>\n";

			FileWorker worker = new(FULL_PATH);

			string expected = worker.ReadAll();

			// Act
			string actual = STRING_FROM_FILE;

			// Assert
			Assert.Equal(actual, expected);
		}

		/// <summary>
		/// Test public method ReadAll using class
		/// Check if we get correct string from xml file
		/// </summary>
		[Fact]
		public void ReadAllFromClass_Path_ReturnsStringFromFileXML()
		{
			// Arrange
			const string FULL_PATH = @"D:\ForStudy\Components-Of-" +
				@"Software-Engineering\Labs\Lab2\Lab2\TempFileXML.xml";

			const string STRING_FROM_FILE = "<?xml version=\"1.0\"" +
				"?>\n<Text>\n      <FirstText>Some text for lab2 " +
				"XML</FirstText>\n      <SecondText>Second string " +
				"XML</SecondText>\n</Text>\n";

			string expected = FileWorker.ReadAll(FULL_PATH);

			// Act
			string actual = STRING_FROM_FILE;

			// Assert
			Assert.Equal(actual, expected);
		}

		#endregion ReadAllXML

		#region ReadAllCSV

		/// <summary>
		/// Test public method ReadAll using constructor
		/// Check if we get correct string from csv file
		/// </summary>
		[Fact]
		public void ReadAllFromConstructor_None_ReturnsStringFromFileCSV()
		{
			// Arrange
			const string FULL_PATH = @"D:\ForStudy\Components-Of-" +
				@"Software-Engineering\Labs\Lab2\Lab2\TempFileCSV.csv";

			const string STRING_FROM_FILE = "Some text for lab2,CSV\r\nSecond string,CSV\r\n";

			FileWorker worker = new(FULL_PATH);

			string expected = worker.ReadAll();

			// Act
			string actual = STRING_FROM_FILE;

			// Assert
			Assert.Equal(actual, expected);
		}

		/// <summary>
		/// Test public method ReadAll using class
		/// Check if we get correct string from csv file
		/// </summary>
		[Fact]
		public void ReadAllFromClass_Path_ReturnsStringFromFileCSV()
		{
			// Arrange
			const string FULL_PATH = @"D:\ForStudy\Components-Of-" +
				@"Software-Engineering\Labs\Lab2\Lab2\TempFileCSV.csv";

			const string STRING_FROM_FILE = "Some text for lab2,CSV\r\nSecond string,CSV\r\n";

			string expected = FileWorker.ReadAll(FULL_PATH);

			// Act
			string actual = STRING_FROM_FILE;

			// Assert
			Assert.Equal(actual, expected);
		}

		#endregion ReadAllCSV

		#endregion ReadAll

		#region ReadLines

		#region ReadLinesTXT

		/// <summary>
		/// Test public method ReadLines using constructor
		/// Check if we get correct array of strings from txt file
		/// </summary>
		[Theory]
		[InlineData("Some text for lab2", 0)]
		[InlineData("Second string", 1)]
		public void ReadLinesFromConstructor_None_ReturnsStringFromFileTXT
			(string stringFromFile, int indexOfString)
		{
			// Arrange
			const string FULL_PATH = @"D:\ForStudy\Components-Of-" +
				@"Software-Engineering\Labs\Lab2\Lab2\TempFile.txt";

			FileWorker worker = new(FULL_PATH);

			string expected = worker.ReadLines()[indexOfString];

			// Act
			string actual = stringFromFile;

			// Assert
			Assert.Equal(actual, expected);
		}

		/// <summary>
		/// Test public method ReadAll using class
		/// Check if we get correct array of strings from txt file
		/// </summary>
		[Theory]
		[InlineData("Some text for lab2", 0)]
		[InlineData("Second string", 1)]
		public void ReadLinesFromClass_Path_ReturnsStringFromFileTXT
			(string stringFromFile, int indexOfString)
		{
			// Arrange
			const string FULL_PATH = @"D:\ForStudy\Components-Of-" +
				@"Software-Engineering\Labs\Lab2\Lab2\TempFile.txt";

			string expected = FileWorker.ReadLines(FULL_PATH)[indexOfString];

			// Act
			string actual = stringFromFile;

			// Assert
			Assert.Equal(actual, expected);
		}

		#endregion ReadLinesTXT

		#region ReadLinesMD

		/// <summary>
		/// Test public method ReadLines using constructor
		/// Check if we get correct array of strings from md file
		/// </summary>
		[Theory]
		[InlineData("Some text for lab2 MD", 0)]
		[InlineData("Second string MD", 1)]
		public void ReadLinesFromConstructor_None_ReturnsStringFromFileMD
			(string stringFromFile, int indexOfString)
		{
			// Arrange
			const string FULL_PATH = @"D:\ForStudy\Components-Of-" +
				@"Software-Engineering\Labs\Lab2\Lab2\TempFileMD.md";

			FileWorker worker = new(FULL_PATH);

			string expected = worker.ReadLines()[indexOfString];

			// Act
			string actual = stringFromFile;

			// Assert
			Assert.Equal(actual, expected);
		}

		/// <summary>
		/// Test public method ReadAll using class
		/// Check if we get correct array of strings from md file
		/// </summary>
		[Theory]
		[InlineData("Some text for lab2 MD", 0)]
		[InlineData("Second string MD", 1)]
		public void ReadLinesFromClass_Path_ReturnsStringFromFileMD
			(string stringFromFile, int indexOfString)
		{
			// Arrange
			const string FULL_PATH = @"D:\ForStudy\Components-Of-" +
				@"Software-Engineering\Labs\Lab2\Lab2\TempFileMD.md";

			string expected = FileWorker.ReadLines(FULL_PATH)[indexOfString];

			// Act
			string actual = stringFromFile;

			// Assert
			Assert.Equal(actual, expected);
		}

		#endregion ReadLinesMD

		#region ReadLinesXML

		/// <summary>
		/// Test public method ReadLines using constructor
		/// Check if we get correct array of strings from xml file
		/// </summary>
		[Theory]
		[InlineData("<?xml version=\"1.0\"?>", 0)]
		[InlineData("<Text>", 1)]
		[InlineData("      <FirstText>Some text for lab2 XML</FirstText>", 2)]
		[InlineData("      <SecondText>Second string XML</SecondText>", 3)]
		[InlineData("</Text>", 4)]
		public void ReadLinesFromConstructor_None_ReturnsStringFromFileXML
			(string stringFromFile, int indexOfString)
		{
			// Arrange
			const string FULL_PATH = @"D:\ForStudy\Components-Of-" +
				@"Software-Engineering\Labs\Lab2\Lab2\TempFileXML.xml";

			FileWorker worker = new(FULL_PATH);

			string expected = worker.ReadLines()[indexOfString];

			// Act
			string actual = stringFromFile;

			// Assert
			Assert.Equal(actual, expected);
		}

		/// <summary>
		/// Test public method ReadAll using class
		/// Check if we get correct array of strings from xml file
		/// </summary>
		[Theory]
		[InlineData("<?xml version=\"1.0\"?>", 0)]
		[InlineData("<Text>", 1)]
		[InlineData("      <FirstText>Some text for lab2 XML</FirstText>", 2)]
		[InlineData("      <SecondText>Second string XML</SecondText>", 3)]
		[InlineData("</Text>", 4)]
		public void ReadLinesFromClass_Path_ReturnsStringFromFileXMl
			(string stringFromFile, int indexOfString)
		{
			// Arrange
			const string FULL_PATH = @"D:\ForStudy\Components-Of-" +
				@"Software-Engineering\Labs\Lab2\Lab2\TempFileXML.xml";

			string expected = FileWorker.ReadLines(FULL_PATH)[indexOfString];

			// Act
			string actual = stringFromFile;

			// Assert
			Assert.Equal(actual, expected);
		}

		#endregion ReadLinesXML

		#region ReadLinesCSV

		/// <summary>
		/// Test public method ReadLines using constructor
		/// Check if we get correct array of strings from csv file
		/// </summary>
		[Theory]
		[InlineData("Some text for lab2,CSV", 0)]
		[InlineData("Second string,CSV", 1)]
		public void ReadLinesFromConstructor_None_ReturnsStringFromFileCSV
			(string stringFromFile, int indexOfString)
		{
			// Arrange
			const string FULL_PATH = @"D:\ForStudy\Components-Of-" +
				@"Software-Engineering\Labs\Lab2\Lab2\TempFileCSV.csv";

			FileWorker worker = new(FULL_PATH);

			string expected = worker.ReadLines()[indexOfString];

			// Act
			string actual = stringFromFile;

			// Assert
			Assert.Equal(actual, expected);
		}

		/// <summary>
		/// Test public method ReadAll using class
		/// Check if we get correct array of strings from csv file
		/// </summary>
		[Theory]
		[InlineData("Some text for lab2,CSV", 0)]
		[InlineData("Second string,CSV", 1)]
		public void ReadLinesFromClass_Path_ReturnsStringFromFileCSV
			(string stringFromFile, int indexOfString)
		{
			// Arrange
			const string FULL_PATH = @"D:\ForStudy\Components-Of-" +
				@"Software-Engineering\Labs\Lab2\Lab2\TempFileCSV.csv";

			string expected = FileWorker.ReadLines(FULL_PATH)[indexOfString];

			// Act
			string actual = stringFromFile;

			// Assert
			Assert.Equal(actual, expected);
		}

		#endregion ReadLinesCSV

		#endregion ReadLines

		#region TryWrite

		#region TryWriteTXT

		/// <summary>
		/// Test public method TryWrite using constructor
		/// Check if we create txt file
		/// </summary>
		[Fact]
		public void TryWriteTXTFromConstructor_None_ReturnsTrue()
		{
			// Arrange
			const string FULL_PATH = @"D:\ForStudy\Components-Of-" +
				@"Software-Engineering\Labs\Lab2\Lab2\TestFiles" +
				@"\TestWriteFileConstructorTXT.txt";
			const string STRING_TO_FILE = "Text from test Constructor TXT";
			FileWorker worker = new(FULL_PATH);

			bool expected = worker.TryWrite(STRING_TO_FILE);

			// Act
			bool actual = true;

			// Assert
			Assert.Equal(actual, expected);
		}

		/// <summary>
		/// Test public method TryWrite using class
		/// Check if we create txt file
		/// </summary>
		[Fact]
		public void TryWriteTXTFromClass_Path_ReturnsTrue()
		{
			// Arrange
			const string FULL_PATH = @"D:\ForStudy\Components-Of-" +
				@"Software-Engineering\Labs\Lab2\Lab2\TestFiles" +
				@"\TestWriteFileClassTXT.txt";
			const string STRING_TO_FILE = "Text from test Class TXT";

			bool expected = FileWorker.TryWrite(STRING_TO_FILE, FULL_PATH);

			// Act
			bool actual = true;

			// Assert
			Assert.Equal(actual, expected);
		}

		#endregion TryWriteTXT

		#region TryWriteMD

		/// <summary>
		/// Test public method TryWrite using constructor
		/// Check if we create txt file
		/// </summary>
		[Fact]
		public void TryWriteMDFromConstructor_None_ReturnsTrue()
		{
			// Arrange
			const string FULL_PATH = @"D:\ForStudy\Components-Of-" +
				@"Software-Engineering\Labs\Lab2\Lab2\TestFiles" +
				@"\TestWriteFileConstructorMD.md";
			const string STRING_TO_FILE = "Text from test Constructor MD";
			FileWorker worker = new(FULL_PATH);

			bool expected = worker.TryWrite(STRING_TO_FILE);

			// Act
			bool actual = true;

			// Assert
			Assert.Equal(actual, expected);
		}

		/// <summary>
		/// Test public method TryWrite using class
		/// Check if we create md file
		/// </summary>
		[Fact]
		public void TryWriteMDFromClass_Path_ReturnsTrue()
		{
			// Arrange
			const string FULL_PATH = @"D:\ForStudy\Components-Of-" +
				@"Software-Engineering\Labs\Lab2\Lab2\TestFiles" +
				@"\TestWriteFileClassMD.md";
			const string STRING_TO_FILE = "Text from test Class MD";

			bool expected = FileWorker.TryWrite(STRING_TO_FILE, FULL_PATH);

			// Act
			bool actual = true;

			// Assert
			Assert.Equal(actual, expected);
		}

		#endregion TryWriteMD

		#region TryWriteXML

		/// <summary>
		/// Test public method TryWrite using constructor
		/// Check if we create xml file
		/// </summary>
		[Fact]
		public void TryWriteXMLFromConstructor_None_ReturnsTrue()
		{
			// Arrange
			const string FULL_PATH = @"D:\ForStudy\Components-Of-" +
				@"Software-Engineering\Labs\Lab2\Lab2\TestFiles" +
				@"\TestWriteFileConstructorXML.xml";
			const string STRING_TO_FILE = "Text from test Constructor XML";
			FileWorker worker = new(FULL_PATH);

			bool expected = worker.TryWrite(STRING_TO_FILE);

			// Act
			bool actual = true;

			// Assert
			Assert.Equal(actual, expected);
		}

		/// <summary>
		/// Test public method TryWrite using class
		/// Check if we create xml file
		/// </summary>
		[Fact]
		public void TryWriteXMLFromClass_Path_ReturnsTrue()
		{
			// Arrange
			const string FULL_PATH = @"D:\ForStudy\Components-Of-" +
				@"Software-Engineering\Labs\Lab2\Lab2\TestFiles" +
				@"\TestWriteFileClassXML.xml";
			const string STRING_TO_FILE = "Text from test Class XML";

			bool expected = FileWorker.TryWrite(STRING_TO_FILE, FULL_PATH);

			// Act
			bool actual = true;

			// Assert
			Assert.Equal(actual, expected);
		}

		#endregion TryWriteXML

		#region TryWriteCSV

		/// <summary>
		/// Test public method TryWrite using constructor
		/// Check if we create csv file
		/// </summary>
		[Fact]
		public void TryWriteCSVFromConstructor_None_ReturnsTrue()
		{
			// Arrange
			const string FULL_PATH = @"D:\ForStudy\Components-Of-" +
				@"Software-Engineering\Labs\Lab2\Lab2\TestFiles" +
				@"\TestWriteFileConstructorCSV.csv";
			const string STRING_TO_FILE = "Text from test Constructor CSV";
			FileWorker worker = new(FULL_PATH);

			bool expected = worker.TryWrite(STRING_TO_FILE);

			// Act
			bool actual = true;

			// Assert
			Assert.Equal(actual, expected);
		}

		/// <summary>
		/// Test public method TryWrite using class
		/// Check if we create csv file
		/// </summary>
		[Fact]
		public void TryWriteCSVFromClass_Path_ReturnsTrue()
		{
			// Arrange
			const string FULL_PATH = @"D:\ForStudy\Components-Of-" +
				@"Software-Engineering\Labs\Lab2\Lab2\TestFiles" +
				@"\TestWriteFileClassCSV.csv";
			const string STRING_TO_FILE = "Text from test Class CSV";

			bool expected = FileWorker.TryWrite(STRING_TO_FILE, FULL_PATH);

			// Act
			bool actual = true;

			// Assert
			Assert.Equal(actual, expected);
		}

		#endregion TryWriteCSV

		#region TryWriteZeroTries

		/// <summary>
		/// Test public method TryWrite using constructor
		/// Check if we can't create txt file with Zero tries
		/// </summary>
		[Fact]
		public void TryWriteTXTFromConstructorZeroTries_None_ReturnsFalse()
		{
			// Arrange
			const string FULL_PATH = @"D:\ForStudy\Components-Of-" +
				@"Software-Engineering\Labs\Lab2\Lab2\TestFiles" +
				@"\TestWriteFileConstructorZeroTriesTXT.txt";
			const string STRING_TO_FILE = "Text from test " +
				"Zero Tries Constructor TXT";
			FileWorker worker = new(FULL_PATH);

			bool expected = worker.TryWrite(STRING_TO_FILE, 0);

			// Act
			bool actual = false;

			// Assert
			Assert.Equal(actual, expected);
		}

		/// <summary>
		/// Test public method TryWrite using class
		/// Check if we can't create txt file with Zero tries
		/// </summary>
		[Fact]
		public void TryWriteTXTFromClassZeroTries_Path_ReturnsFalse()
		{
			// Arrange
			const string FULL_PATH = @"D:\ForStudy\Components-Of-" +
				@"Software-Engineering\Labs\Lab2\Lab2\TestFiles" +
				@"\TestWriteFileClassZeroTriesTXT.txt";
			const string STRING_TO_FILE = "Text from test " +
				"Zero Tries Class TXT";

			bool expected = FileWorker.TryWrite(STRING_TO_FILE, FULL_PATH, 0);

			// Act
			bool actual = false;

			// Assert
			Assert.Equal(actual, expected);
		}

		#endregion TryWriteZeroTries

		#region TryWriteNegativeTries

		/// <summary>
		/// Test public method TryWrite using constructor
		/// Check if we can't create txt file with Negative tries
		/// </summary>
		[Fact]
		public void TryWriteTXTFromConstructorNegativeTries_None_ReturnsFalse()
		{
			// Arrange
			const string FULL_PATH = @"D:\ForStudy\Components-Of-" +
				@"Software-Engineering\Labs\Lab2\Lab2\TestFiles" +
				@"\TestWriteFileConstructorNegativeTriesTXT.txt";
			const string STRING_TO_FILE = "Text from test " +
				"Negative Tries Constructor TXT";
			FileWorker worker = new(FULL_PATH);

			bool expected = worker.TryWrite(STRING_TO_FILE, -1);

			// Act
			bool actual = false;

			// Assert
			Assert.Equal(actual, expected);
		}

		/// <summary>
		/// Test public method TryWrite using class
		/// Check if we can't create txt file with Negative tries
		/// </summary>
		[Fact]
		public void TryWriteTXTFromClassNegativeTries_Path_ReturnsFalse()
		{
			// Arrange
			const string FULL_PATH = @"D:\ForStudy\Components-Of-" +
				@"Software-Engineering\Labs\Lab2\Lab2\TestFiles" +
				@"\TestWriteFileClassNegativeTriesTXT.txt";
			const string STRING_TO_FILE = "Text from test " +
				"Negative Tries Class TXT";

			bool expected = FileWorker.TryWrite(STRING_TO_FILE, FULL_PATH, -1);

			// Act
			bool actual = false;

			// Assert
			Assert.Equal(actual, expected);
		}

		#endregion TryWriteZeroTries

		#region TryWriteManyTries

		/// <summary>
		/// Test public method TryWrite using constructor
		/// Check if we can create txt file with Many tries
		/// </summary>
		[Fact]
		public void TryWriteTXTFromConstructorManyTries_None_ReturnsTrue()
		{
			// Arrange
			const string FULL_PATH = @"D:\ForStudy\Components-Of-" +
				@"Software-Engineering\Labs\Lab2\Lab2\TestFiles" +
				@"\TestWriteFileConstructorManyTriesTXT.txt";
			const string STRING_TO_FILE = "Text from test " +
				"Many Tries Constructor TXT";
			FileWorker worker = new(FULL_PATH);

			bool expected = worker.TryWrite(STRING_TO_FILE, 10);

			// Act
			bool actual = true;

			// Assert
			Assert.Equal(actual, expected);
		}

		/// <summary>
		/// Test public method TryWrite using class
		/// Check if we can create txt file with Many tries
		/// </summary>
		[Fact]
		public void TryWriteTXTFromClassManyTries_Path_ReturnsTrue()
		{
			// Arrange
			const string FULL_PATH = @"D:\ForStudy\Components-Of-" +
				@"Software-Engineering\Labs\Lab2\Lab2\TestFiles" +
				@"\TestWriteFileClassManyTriesTXT.txt";
			const string STRING_TO_FILE = "Text from test " +
				"Many Tries Class TXT";

			bool expected = FileWorker.TryWrite(STRING_TO_FILE, FULL_PATH, 10);

			// Act
			bool actual = true;

			// Assert
			Assert.Equal(actual, expected);
		}

		#endregion TryWriteManyTries

		#endregion TryWrite
	}
}