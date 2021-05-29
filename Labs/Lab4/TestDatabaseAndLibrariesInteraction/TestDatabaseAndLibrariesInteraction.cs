using System;
using Xunit;
using IIG.FileWorker;
using IIG.DatabaseConnectionUtils;
using IIG.CoSFE.DatabaseUtils;
using IIG.PasswordHashingUtils;
using System.Text;

namespace TestDatabaseAndLibrariesInteraction
{
	public class TestDatabaseAndLibrariesInteraction
	{
		private const string Server = @"VSIG-MACHINE";
		private const string AuthDatabase = @"IIG.CoSWE.AuthDB";
		private const string StorageDatabase = @"IIG.CoSWE.StorageDB";
		private const bool IsTrusted = true;
		private const string Login = @"coswe";
		private const string Password = @"L}EjpfCgru9X@GLj";
		private const int ConnectionTimeout = 75;

		static readonly StorageDatabaseUtils storageDatabase = new(Server, StorageDatabase,
			IsTrusted, Login, Password, ConnectionTimeout);

		static readonly AuthDatabaseUtils authDatabase = new(Server, AuthDatabase,
			IsTrusted, Login, Password, ConnectionTimeout);

		/*
		Naming:
		1. The name of the project being tested.
		2. The scenario under which it's being tested.
		3. The expected behavior when the scenario is invoked.
		*/

		#region Storage DB

		[Fact]
		public void FileWorker_CorrectValues_ReturnsSameStrings()
		{
			// Arrange
			string expectedText = "Some Text";
			byte[] expectedTextInBytes = Encoding.UTF8.GetBytes(expectedText);

			string expectedName = "SomeCoolName.txt";

			// Act
			storageDatabase.AddFile(expectedName, expectedTextInBytes);

			int? fileID = storageDatabase.GetIntBySql("SELECT MAX(FileID) FROM Files");

			storageDatabase.GetFile((int)fileID, out string actualName,
				out byte[] actualTextInBytes);

			string actualText = Encoding.UTF8.GetString(actualTextInBytes);

			storageDatabase.DeleteFile((int)fileID);

			// Assert
			Assert.Equal(actualName, expectedName);
			Assert.Equal(actualText, expectedText);
			Assert.Equal(actualTextInBytes, expectedTextInBytes);
		}

		[Fact]
		public void FileWorker_EmptyText_ReturnsSameStrings()
		{
			// Arrange
			string expectedText = "";
			byte[] expectedTextInBytes = Encoding.UTF8.GetBytes(expectedText);

			string expectedName = "SomeCoolName.txt";

			// Act
			storageDatabase.AddFile(expectedName, expectedTextInBytes);

			int? fileID = storageDatabase.GetIntBySql("SELECT MAX(FileID) FROM Files");

			storageDatabase.GetFile((int)fileID, out string actualName,
				out byte[] actualTextInBytes);

			string actualText = Encoding.UTF8.GetString(actualTextInBytes);

			storageDatabase.DeleteFile((int)fileID);

			// Assert
			Assert.Equal(actualName, expectedName);
			Assert.Equal(actualText, expectedText);
			Assert.Equal(actualTextInBytes, expectedTextInBytes);
		}

		[Fact]
		public void FileWorker_EmptyStrings_ReturnsException()
		{
			// Arrange
			string expectedText = "";
			byte[] expectedTextInBytes = Encoding.UTF8.GetBytes(expectedText);

			string expectedName = "";

			// Act
			storageDatabase.AddFile(expectedName, expectedTextInBytes);

			int? fileID = storageDatabase.GetIntBySql
				("SELECT MAX(FileID) FROM Files");

			// Assert
			Assert.Throws<InvalidOperationException>(() =>
			storageDatabase.GetFile((int)fileID, out string actualName,
				out byte[] actualTextInBytes));
		}

		[Fact]
		public void FileWorker_EmptyName_ReturnsException()
		{
			// Arrange
			string expectedText = "Some Text";
			byte[] expectedTextInBytes = Encoding.UTF8.GetBytes(expectedText);

			string expectedName = "";

			// Act
			storageDatabase.AddFile(expectedName, expectedTextInBytes);

			int? fileID = storageDatabase.GetIntBySql
				("SELECT MAX(FileID) FROM Files");

			// Assert
			Assert.Throws<InvalidOperationException>(() =>
			storageDatabase.GetFile((int)fileID, out string actualName,
				out byte[] actualTextInBytes));
		}

		#endregion Storage DB
	}
}
