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
		private const string Database = @"IIG.CoSWE.AuthDB";
		private const bool IsTrusted = false;
		private const string Login = @"coswe";
		private const string Password = @"L}EjpfCgru9X@GLj";
		private const int ConnectionTimeout = 75;

		static StorageDatabaseUtils storageDatabase = new(Server, Database,
			IsTrusted, Login, Password, ConnectionTimeout);

		static void Main()
		{
			byte[] array = new byte[100];
			try
			{
				Console.WriteLine(storageDatabase.AddFile("SomeCoolName.txt", array));
				// storageDatabase.ExecSql()
			}
			catch (Exception e)
			{
				Console.WriteLine(e.Message);
			}
		}
	}
}
