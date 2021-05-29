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

		static StorageDatabaseUtils storageDatabase = new(Server, StorageDatabase,
			IsTrusted, Login, Password, ConnectionTimeout);

		static AuthDatabaseUtils authDatabase = new(Server, AuthDatabase,
			IsTrusted, Login, Password, ConnectionTimeout);

		/*
		Naming:
		1. The name of the method being tested.
		2. The scenario under which it's being tested.
		3. The expected behavior when the scenario is invoked.
		*/

		#region Storage DB

		[Fact]
		public void FilePath_None_ReturnsSameString()
		{
			// Arrange
			string expectedText = "Some String";
			byte[] expectedTextInBytes = Encoding.UTF8.GetBytes(expectedText);

			string expectedName = "SomeCoolName.txt";

			// Act
			storageDatabase.AddFile(expectedName, expectedTextInBytes);

			int? fileID = storageDatabase.GetIntBySql("SELECT MAX(FileID) FROM Files");

			Console.WriteLine(fileID);

			storageDatabase.GetFile((int)fileID, out string actualName,
				out byte[] actualTextInBytes);

			string actualText = Encoding.UTF8.GetString(actualTextInBytes);

			storageDatabase.DeleteFile((int)fileID);

			// Assert
			Assert.Equal(actualName, expectedName);
			Assert.Equal(actualText, expectedText);
			// Assert.Equal(actualTextInBytes, expectedTextInBytes);
		}

		#endregion Storage DB
	}
}
