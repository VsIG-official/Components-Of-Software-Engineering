using System;
using IIG.FileWorker;
using IIG.DatabaseConnectionUtils;
using IIG.CoSFE.DatabaseUtils;
using IIG.PasswordHashingUtils;

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
		private const int ConnectionTimeout = 20;

		static StorageDatabaseUtils storageDatabase = new(Server, StorageDatabase,
			IsTrusted, Login, Password, ConnectionTimeout);

		static AuthDatabaseUtils authDatabase = new(Server, AuthDatabase,
			IsTrusted, Login, Password, ConnectionTimeout);

		static void Main()
		{
			Console.WriteLine(authDatabase.AddCredentials("Login", "123"));
			//Console.WriteLine(authDatabase.UpdateCredentials("TestLogin", "TestPass", "NewTestLogin", "NewTestPass"));
			//byte[] array = new byte[99];
			//try
			//{
			//Console.WriteLine(storageDatabase.AddFile("SomeCoolName3.txt", array));
			//	// storageDatabase.ExecSql()
			//}
			//catch (Exception e)
			//{
			//	Console.WriteLine(e.Message);
			//}
		}
	}
}
