using System;
using Xunit;
using IIG.FileWorker;
using IIG.DatabaseConnectionUtils;
using IIG.CoSFE.DatabaseUtils;
using IIG.PasswordHashingUtils;

namespace TestDatabaseAndLibrariesInteraction
{
	public class TestDatabaseAndLibrariesInteraction
	{
		private const string Server = @"DESKTOP-GSU5395\IHBATESTEXPRESS";
		private const string Database = @"IIG.CoSWE.AuthDB";
		private const bool IsTrusted = false;
		private const string Login = @"coswe";
		private const string Password = @"L}EjpfCgru9X@GLj";
		private const int ConnectionTimeout = 75;

		StorageDatabaseUtils storageDatabase = new(Server, Database,
			IsTrusted, Login, Password, ConnectionTimeout);

		AuthDatabaseUtils authDatabase = new(Server, Database,
			IsTrusted, Login, Password, ConnectionTimeout);


	}
}
