using System;
using IIG.FileWorker;
using IIG.DatabaseConnectionUtils;
using IIG.CoSFE.DatabaseUtils;
using IIG.PasswordHashingUtils;
using System.Text;

namespace Lab4
{
	class Program
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

		static void Main()
		{
			string expectedText = "Some String";
			byte[] expectedTextInBytes = Encoding.UTF8.GetBytes(expectedText);

			string expectedName = "SomeCoolName.txt";

			// Act
			storageDatabase.AddFile(expectedName, expectedTextInBytes);

			int? fileID = storageDatabase.GetIntBySql
				("SELECT MAX(FileID) FROM Files");

			storageDatabase.GetFile((int)fileID, out string actualName,
				out byte[] actualTextInBytes);

			string actualText = Encoding.UTF8.GetString(actualTextInBytes);

			storageDatabase.DeleteFile((int)fileID);

			if (actualName == expectedName)
			{
				Console.WriteLine("TrueName");
			}
			if (actualText == expectedText)
			{
				Console.WriteLine("TrueText");
			}
			if (actualTextInBytes == expectedTextInBytes)
			{
				Console.WriteLine("TrueBytes");
			}
		}
	}
}
