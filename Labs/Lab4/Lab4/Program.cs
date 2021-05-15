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
			storageDatabase.DeleteFile(1);
			storageDatabase.DeleteFile(2);
			storageDatabase.DeleteFile(3);
			storageDatabase.DeleteFile(4);
			storageDatabase.DeleteFile(5);
			storageDatabase.DeleteFile(6);
			storageDatabase.DeleteFile(7);
			storageDatabase.DeleteFile(8);
			storageDatabase.DeleteFile(9);
			storageDatabase.DeleteFile(10);
			storageDatabase.DeleteFile(11);
			storageDatabase.DeleteFile(12);
			storageDatabase.DeleteFile(13);
			storageDatabase.DeleteFile(14);
			storageDatabase.DeleteFile(15);
			storageDatabase.DeleteFile(16);
			storageDatabase.DeleteFile(17);
			storageDatabase.DeleteFile(18);
			storageDatabase.DeleteFile(19);
			storageDatabase.DeleteFile(20);

			string array = "Some String";

			byte[] bytes = Encoding.UTF8.GetBytes(array);

			Console.WriteLine(storageDatabase.AddFile("SomeCoolName.txt", bytes));

			string newName = "NewFile.txt";
			string newArray = "";

			//storageDatabase.

			Console.WriteLine(storageDatabase.GetFiles(newName));

			//newArray = Encoding.UTF8.GetString(newBytes);
			Console.WriteLine(newArray);

			//storageDatabase.DeleteFile(17);
		}
	}
}
