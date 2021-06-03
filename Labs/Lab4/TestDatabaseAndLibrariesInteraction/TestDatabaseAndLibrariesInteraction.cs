using System;
using Xunit;
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

		static readonly StorageDatabaseUtils storageDatabase =
			new(Server, StorageDatabase, IsTrusted,
				Login, Password, ConnectionTimeout);

		static readonly AuthDatabaseUtils authDatabase =
			new(Server, AuthDatabase,IsTrusted,
				Login, Password, ConnectionTimeout);

		/*
		Naming:
		1. The name of the project being tested.
		(optional) 2. The name of the method being tested
		3. The scenario under which it's being tested.
		4. The expected behavior when the scenario is invoked.
		*/

		#region Storage DB

		/// <summary>
		/// Test FileWorker with regular values
		/// Should return same strings
		/// </summary>
		[Fact]
		public void FileWorker_RegularLetters_ReturnsSameStrings()
		{
			// Arrange
			string expectedText = "Some Text";
			byte[] expectedTextInBytes = Encoding.UTF8.GetBytes(expectedText);

			string expectedName = "SomeCoolName.txt";

			// Act
			Assert.True(storageDatabase.AddFile(expectedName, expectedTextInBytes));

			int? fileID = storageDatabase.GetIntBySql
				("SELECT MAX(FileID) FROM Files");

			Assert.True(storageDatabase.GetFile((int)fileID, out string actualName,
				out byte[] actualTextInBytes));

			string actualText = Encoding.UTF8.GetString(actualTextInBytes);

			Assert.True(storageDatabase.DeleteFile((int)fileID));

			// Assert
			Assert.Equal(actualName, expectedName);
			Assert.Equal(actualText, expectedText);
			Assert.Equal(actualTextInBytes, expectedTextInBytes);
		}

		/// <summary>
		/// Test FileWorker with empty values
		/// Should return same strings
		/// </summary>
		[Fact]
		public void FileWorker_EmptyText_ReturnsSameStrings()
		{
			// Arrange
			string expectedText = "";
			byte[] expectedTextInBytes = Encoding.UTF8.GetBytes(expectedText);

			string expectedName = "SomeCoolName.txt";

			// Act
			Assert.True(storageDatabase.AddFile(expectedName, expectedTextInBytes));

			int? fileID = storageDatabase.GetIntBySql
				("SELECT MAX(FileID) FROM Files");

			Assert.True(storageDatabase.GetFile((int)fileID, out string actualName, out byte[] actualTextInBytes));

			string actualText = Encoding.UTF8.GetString(actualTextInBytes);

			Assert.True(storageDatabase.DeleteFile((int)fileID));

			// Assert
			Assert.Equal(actualName, expectedName);
			Assert.Equal(actualText, expectedText);
			Assert.Equal(actualTextInBytes, expectedTextInBytes);
		}

		/// <summary>
		/// Test FileWorker with emojis
		/// Should return same strings
		/// </summary>
		[Fact]
		public void FileWorker_Emojis_ReturnsSameStrings()
		{
			// Arrange
			string expectedText = "🎨🎨🎨";
			byte[] expectedTextInBytes = Encoding.UTF8.GetBytes(expectedText);

			string expectedName = "⚡️⚡️⚡️.txt";

			// Act
			Assert.True(storageDatabase.AddFile(expectedName, expectedTextInBytes));

			int? fileID = storageDatabase.GetIntBySql("SELECT MAX(FileID) FROM Files");

			Assert.True(storageDatabase.GetFile((int)fileID, out string actualName, out byte[] actualTextInBytes));

			string actualText = Encoding.UTF8.GetString(actualTextInBytes);

			Assert.True(storageDatabase.DeleteFile((int)fileID));

			// Assert
			Assert.Equal(actualName, expectedName);
			Assert.Equal(actualText, expectedText);
			Assert.Equal(actualTextInBytes, expectedTextInBytes);
		}

		/// <summary>
		/// Test FileWorker with hieroglyphs
		/// Should return same strings
		/// </summary>
		[Fact]
		public void FileWorker_Hieroglyphs_ReturnsSameStrings()
		{
			// Arrange
			string expectedText = "汉字";
			byte[] expectedTextInBytes = Encoding.UTF8.GetBytes(expectedText);

			string expectedName = "漢字.txt";

			// Act
			Assert.True(storageDatabase.AddFile(expectedName, expectedTextInBytes));

			int? fileID = storageDatabase.GetIntBySql
				("SELECT MAX(FileID) FROM Files");

			Assert.True(storageDatabase.GetFile((int)fileID, out string actualName, out byte[] actualTextInBytes));

			string actualText = Encoding.UTF8.GetString(actualTextInBytes);

			Assert.True(storageDatabase.DeleteFile((int)fileID));

			// Assert
			Assert.Equal(actualName, expectedName);
			Assert.Equal(actualText, expectedText);
			Assert.Equal(actualTextInBytes, expectedTextInBytes);
		}

		/// <summary>
		/// Test FileWorker with empty strings
		/// Should return exception
		/// </summary>
		[Fact]
		public void FileWorker_EmptyStrings_ReturnsException()
		{
			// Arrange
			string expectedText = "";
			byte[] expectedTextInBytes = Encoding.UTF8.GetBytes(expectedText);

			string expectedName = "";

			// Act
			Assert.True(storageDatabase.AddFile(expectedName, expectedTextInBytes));

			int? fileID = storageDatabase.GetIntBySql
				("SELECT MAX(FileID) FROM Files");

			// Assert
			Assert.Throws<InvalidOperationException>(() =>
			storageDatabase.GetFile((int)fileID, out string actualName,
				out byte[] actualTextInBytes));
		}

		/// <summary>
		/// Test FileWorker with empty name
		/// Should return exception
		/// </summary>
		[Fact]
		public void FileWorker_EmptyName_ReturnsException()
		{
			// Arrange
			string expectedText = "Some Text";
			byte[] expectedTextInBytes = Encoding.UTF8.GetBytes(expectedText);

			string expectedName = "";

			// Act
			Assert.True(storageDatabase.AddFile(expectedName, expectedTextInBytes));

			int? fileID = storageDatabase.GetIntBySql
				("SELECT MAX(FileID) FROM Files");

			// Assert
			Assert.Throws<InvalidOperationException>(() =>
			storageDatabase.GetFile((int)fileID, out string actualName,
				out byte[] actualTextInBytes));
		}

		/// <summary>
		/// Test FileWorker with null name
		/// Should return exception
		/// </summary>
		[Fact]
		public void FileWorker_NullName_ReturnsException()
		{
			// Arrange
			string expectedText = "Some Text";
			byte[] expectedTextInBytes = Encoding.UTF8.GetBytes(expectedText);

			string expectedName = null;

			// Act
			Assert.True(storageDatabase.AddFile(expectedName, expectedTextInBytes));

			int? fileID = storageDatabase.GetIntBySql
				("SELECT MAX(FileID) FROM Files");

			// Assert
			Assert.Throws<InvalidOperationException>(() =>
			storageDatabase.GetFile((int)fileID, out string actualName,
				out byte[] actualTextInBytes));
		}

		/// <summary>
		/// Test FileWorker with null bytes
		/// Should return exception
		/// </summary>
		[Fact]
		public void FileWorker_NullTextInBytes_ReturnsException()
		{
			// Arrange
			byte[] expectedTextInBytes = null;

			string expectedName = "SomeCoolName.txt";

			// Act
			Assert.True(storageDatabase.AddFile(expectedName, expectedTextInBytes));

			int? fileID = storageDatabase.GetIntBySql
				("SELECT MAX(FileID) FROM Files");

			// Assert
			Assert.Throws<InvalidOperationException>(() =>
			storageDatabase.GetFile((int)fileID, out string actualName,
				out byte[] actualTextInBytes));
		}

		#endregion Storage DB

		#region Auth DB

		#region AddCredentials

		/// <summary>
		/// Test PasswordHasher AddCredentials with regular values
		/// Should return same strings
		/// </summary>
		[Fact]
		public void PassHasher_AddCredentials_RegularLetters_ReturnsSameStrings()
		{
			// Arrange
			string expectedLogin = "SomeCoolLogin";
			string expectedPassword = "SomeCoolPassword";

			// Act
			string expectedHashPassword = PasswordHasher.
				GetHash(expectedPassword);

			authDatabase.AddCredentials(expectedLogin, expectedHashPassword);

			bool areCredentialsTheSame = authDatabase.
				CheckCredentials(expectedLogin, expectedHashPassword);

			authDatabase.DeleteCredentials(expectedLogin, expectedHashPassword);

			// Assert
			Assert.True(areCredentialsTheSame);
		}

		/// <summary>
		/// Test PasswordHasher AddCredentials with empty password
		/// Should return same strings
		/// </summary>
		[Fact]
		public void PassHasher_AddCredentials_EmptyPassword_ReturnsSameStrings()
		{
			// Arrange
			string expectedLogin = "SomeCoolLogin";
			string expectedPassword = "";

			// Act
			string expectedHashPassword = PasswordHasher.
				GetHash(expectedPassword);

			authDatabase.AddCredentials(expectedLogin, expectedHashPassword);

			bool areCredentialsTheSame = authDatabase.
				CheckCredentials(expectedLogin, expectedHashPassword);

			authDatabase.DeleteCredentials(expectedLogin, expectedHashPassword);

			// Assert
			Assert.True(areCredentialsTheSame);
		}

		/// <summary>
		/// Test PasswordHasher AddCredentials with empty password
		/// and one letter in a login
		/// Should return same strings
		/// </summary>
		[Fact]
		public void PassHasher_AddCredentials_EmptyPasswordAndOneLetterlogin_ReturnsSameStrings()
		{
			// Arrange
			string expectedLogin = "S";
			string expectedPassword = "";

			// Act
			string expectedHashPassword = PasswordHasher.
				GetHash(expectedPassword);

			authDatabase.AddCredentials(expectedLogin, expectedHashPassword);

			bool areCredentialsTheSame = authDatabase.
				CheckCredentials(expectedLogin, expectedHashPassword);

			authDatabase.DeleteCredentials(expectedLogin, expectedHashPassword);

			// Assert
			Assert.True(areCredentialsTheSame);
		}

		/// <summary>
		/// Test PasswordHasher AddCredentials with emojis
		/// Should return same strings
		/// </summary>
		[Fact]
		public void PassHasher_AddCredentials_Emojis_ReturnsSameStrings()
		{
			// Arrange
			string expectedLogin = "🎨🎨🎨";
			string expectedPassword = "⚡️⚡️⚡️";

			// Act
			string expectedHashPassword = PasswordHasher.
				GetHash(expectedPassword);

			authDatabase.AddCredentials(expectedLogin, expectedHashPassword);

			bool areCredentialsTheSame = authDatabase.
				CheckCredentials(expectedLogin, expectedHashPassword);

			authDatabase.DeleteCredentials(expectedLogin, expectedHashPassword);

			// Assert
			Assert.True(areCredentialsTheSame);
		}

		/// <summary>
		/// Test PasswordHasher AddCredentials with hieroglyphs
		/// Should return same strings
		/// </summary>
		[Fact]
		public void PassHasher_AddCredentials_Hieroglyphs_ReturnsSameStrings()
		{
			// Arrange
			string expectedLogin = "汉字";
			string expectedPassword = "漢字";

			// Act
			string expectedHashPassword = PasswordHasher.GetHash(expectedPassword);

			authDatabase.AddCredentials(expectedLogin, expectedHashPassword);

			bool areCredentialsTheSame = authDatabase.CheckCredentials(expectedLogin, expectedHashPassword);

			authDatabase.DeleteCredentials(expectedLogin, expectedHashPassword);

			// Assert
			Assert.True(areCredentialsTheSame);
		}

		#endregion AddCredentials

		#region UpdateCredentials

		/// <summary>
		/// Test PasswordHasher UpdateCredentials with regular values
		/// Should return same strings
		/// </summary>
		[Fact]
		public void PassHasher_UpdateCredentials_RegularLetters_ReturnsSameStrings()
		{
			// Arrange
			string firstLogin = "SomeCoolLogin";
			string firstPassword = "SomeCoolPassword";

			string newLogin = "NewSomeCoolLogin";
			string newPassword = "NewSomeCoolPassword";

			// Act
			string firstHashPassword = PasswordHasher.
				GetHash(firstPassword);

			string newHashPassword = PasswordHasher.
				GetHash(newPassword);

			authDatabase.AddCredentials(firstLogin, firstHashPassword);

			authDatabase.UpdateCredentials(firstLogin, firstHashPassword,
				newLogin, newHashPassword);

			bool areCredentialsTheSame = authDatabase.
				CheckCredentials(newLogin, newHashPassword);

			authDatabase.DeleteCredentials(newLogin, newHashPassword);

			// Assert
			Assert.True(areCredentialsTheSame);
		}

		/// <summary>
		/// Test PasswordHasher UpdateCredentials with empty password
		/// Should return same strings
		/// </summary>
		[Fact]
		public void PassHasher_UpdateCredentials_EmptyPassword_ReturnsSameStrings()
		{
			// Arrange
			string firstLogin = "SomeCoolLogin";
			string firstPassword = "";

			string newLogin = "NewSomeCoolLogin";
			string newPassword = "";

			// Act
			string firstHashPassword = PasswordHasher.
				GetHash(firstPassword);

			string newHashPassword = PasswordHasher.
				GetHash(newPassword);

			authDatabase.AddCredentials(firstLogin, firstHashPassword);

			authDatabase.UpdateCredentials(firstLogin, firstHashPassword,
				newLogin, newHashPassword);

			bool areCredentialsTheSame = authDatabase.
				CheckCredentials(newLogin, newHashPassword);

			authDatabase.DeleteCredentials(newLogin, newHashPassword);

			// Assert
			Assert.True(areCredentialsTheSame);
		}

		/// <summary>
		/// Test PasswordHasher UpdateCredentials
		/// with empty password and one letter login
		/// Should return same strings
		/// </summary>
		[Fact]
		public void PassHasher_UpdateCredentials_EmptyPasswordAndOneLetterLogin_ReturnsSameStrings()
		{
			// Arrange
			string firstLogin = "S";
			string firstPassword = "";

			string newLogin = "N";
			string newPassword = "";

			// Act
			string firstHashPassword = PasswordHasher.
				GetHash(firstPassword);

			string newHashPassword = PasswordHasher.
				GetHash(newPassword);

			authDatabase.AddCredentials(firstLogin, firstHashPassword);

			authDatabase.UpdateCredentials(firstLogin, firstHashPassword,
				newLogin, newHashPassword);

			bool areCredentialsTheSame = authDatabase.
				CheckCredentials(newLogin, newHashPassword);

			authDatabase.DeleteCredentials(newLogin, newHashPassword);

			// Assert
			Assert.True(areCredentialsTheSame);
		}

		/// <summary>
		/// Test PasswordHasher UpdateCredentials with emojis
		/// Should return same strings
		/// </summary>
		[Fact]
		public void PassHasher_UpdateCredentials_Emojis_ReturnsSameStrings()
		{
			// Arrange
			string firstLogin = "🎨🎨🎨";
			string firstPassword = "⚡️⚡️⚡️";

			string newLogin = "🔥🔥🔥";
			string newPassword = "🐛🐛🐛";

			// Act
			string firstHashPassword = PasswordHasher.
				GetHash(firstPassword);

			string newHashPassword = PasswordHasher.
				GetHash(newPassword);

			authDatabase.AddCredentials(firstLogin, firstHashPassword);

			authDatabase.UpdateCredentials(firstLogin, firstHashPassword,
				newLogin, newHashPassword);

			bool areCredentialsTheSame = authDatabase.
				CheckCredentials(newLogin, newHashPassword);

			authDatabase.DeleteCredentials(newLogin, newHashPassword);

			// Assert
			Assert.True(areCredentialsTheSame);
		}

		/// <summary>
		/// Test PasswordHasher UpdateCredentials with hieroglyphs
		/// Should return same strings
		/// </summary>
		[Fact]
		public void PassHasher_UpdateCredentials_Hieroglyphs_ReturnsSameStrings()
		{
			// Arrange
			string firstLogin = "汉字";
			string firstPassword = "漢字";

			string newLogin = "한자";
			string newPassword = "漢字";

			// Act
			string firstHashPassword = PasswordHasher.
				GetHash(firstPassword);

			string newHashPassword = PasswordHasher.
				GetHash(newPassword);

			authDatabase.AddCredentials(firstLogin, firstHashPassword);

			authDatabase.UpdateCredentials(firstLogin, firstHashPassword,
				newLogin, newHashPassword);

			bool areCredentialsTheSame = authDatabase.
				CheckCredentials(newLogin, newHashPassword);

			authDatabase.DeleteCredentials(newLogin, newHashPassword);

			// Assert
			Assert.True(areCredentialsTheSame);
		}

		#endregion UpdateCredentials

		#endregion Auth DB
	}
}
