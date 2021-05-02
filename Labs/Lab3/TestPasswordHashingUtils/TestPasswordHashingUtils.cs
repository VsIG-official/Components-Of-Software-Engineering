using System;
using Xunit;
using IIG.PasswordHashingUtils;

namespace TestPasswordHashingUtils
{
	/// <summary>
	/// Class for testing Password Hashing Utils
	/// </summary>
	public class TestPasswordHashingUtils
	{

		/*
		Naming:
		1. Execution Route being tested.
		2. The scenario under which it's being tested.
		3. The expected behavior when the scenario is invoked.
		*/

		#region ExecutionRoutes

		#region Init

		/// <summary>
		/// Class for testing Init method
		/// </summary>
		public class TestInit
		{
			#region 0_1_6

			/// <summary>
			/// Test Execution Route 0_1_6 with null and zero
			/// Should return true
			/// </summary>
			[Fact]
			public void ExecRoute_0_1_6_NullAndZero_True()
			{
				// Arrange
				const string SALT = null;
				const uint ADLER_MOD = 0;
				const string PASSWORD = "Dominskyi";

				string expected = PasswordHasher.GetHash(PASSWORD);

				// Act
				PasswordHasher.Init(SALT, ADLER_MOD);

				string actual = PasswordHasher.GetHash(PASSWORD);

				// Assert
				Assert.Equal(actual, expected);
			}

			/// <summary>
			/// Test Execution Route 0_1_6 with Empty and zero
			/// Should return true
			/// </summary>
			[Fact]
			public void ExecRoute_0_1_6_EmptyAndZero_True()
			{
				// Arrange
				const string SALT = "";
				const uint ADLER_MOD = 0;
				const string PASSWORD = "Dominskyi";

				string expected = PasswordHasher.GetHash(PASSWORD);

				// Act
				PasswordHasher.Init(SALT, ADLER_MOD);

				string actual = PasswordHasher.GetHash(PASSWORD);

				// Assert
				Assert.Equal(actual, expected);
			}

			#endregion 0_1_6

			#region 0_1_5_6



			#endregion 0_1_5_6

		}

		#endregion Init

		#region GetHash

		/// <summary>
		/// Class for testing GetHash method
		/// </summary>
		public class TestGetHash
		{
			[Fact]
			public void Test1()
			{

			}
		}

		#endregion GetHash

		#endregion ExecutionRoutes
	}
}
