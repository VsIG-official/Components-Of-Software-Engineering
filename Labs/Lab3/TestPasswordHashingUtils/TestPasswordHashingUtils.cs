﻿// Licensed to the Mezidia Foundation under one or more agreements.
// The Mezidia Foundation licenses this file to you under the MIT license.

using System;
using IIG.PasswordHashingUtils;
using Xunit;

namespace TestPasswordHashingUtils
{
    /// <summary>
    /// Class for testing Password Hashing Utils
    /// </summary>
    public class TestPasswordHashingUtils
    {

        /// <summary>
        /// Sets the default values for PasswordHasher
        /// </summary>
        public static void SetDefaultValues()
        {
            const string DEFAULT_SALT = "put your soul(or salt) here";
            const uint DEFAULT_ADLER_MOD = 65521;

            PasswordHasher.Init(DEFAULT_SALT, DEFAULT_ADLER_MOD);
        }

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
            /// Should be  Equal
            /// </summary>
            [Fact]
            public void ExecRoute_0_1_6_IsNullAndZero_Equal()
            {
                // Arrange
                SetDefaultValues();

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
            /// Should be Equal
            /// </summary>
            [Fact]
            public void ExecRoute_0_1_6_EmptyAndZero_Equal()
            {
                // Arrange
                SetDefaultValues();

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

            /// <summary>
            /// Test Execution Route 0_1_5_6 with Empty and Positive
            /// Should  be not Equal
            /// </summary>
            [Fact]
            public void ExecRoute_0_1_5_6_EmptyAndPositive_NotEqual()
            {
                // Arrange
                SetDefaultValues();

                const string SALT = "";
                const uint ADLER_MOD = 1;
                const string PASSWORD = "Dominskyi";

                string expected = PasswordHasher.GetHash(PASSWORD);

                // Act
                PasswordHasher.Init(SALT, ADLER_MOD);

                string actual = PasswordHasher.GetHash(PASSWORD);

                // Assert
                Assert.NotEqual(actual, expected);
            }

            /// <summary>
            /// Test Execution Route 0_1_5_6 with null and Positive
            /// Should be not Equal
            /// </summary>
            [Fact]
            public void ExecRoute_0_1_5_6_NullAndPositive_NotEqual()
            {
                // Arrange
                SetDefaultValues();

                const string SALT = null;
                const uint ADLER_MOD = 1;
                const string PASSWORD = "Dominskyi";

                string expected = PasswordHasher.GetHash(PASSWORD);

                // Act
                PasswordHasher.Init(SALT, ADLER_MOD);

                string actual = PasswordHasher.GetHash(PASSWORD);

                // Assert
                Assert.NotEqual(actual, expected);
            }

            #endregion 0_1_5_6

            #region 0_1_2_4_6

            /// <summary>
            /// Test Execution Route 0_1_2_4_6 with not Empty and Zero
            /// Should be Not Equal
            /// </summary>
            [Fact]
            public void ExecRoute_0_1_2_4_6_NotEmptyAndZero_NotEqual()
            {
                SetDefaultValues();

                const string SALT = "Some cool salt";
                const uint ADLER_MOD = 0;

                try
                {
                    // Arrange
                    const string PASSWORD = "Dominskyi";

                    string expected = PasswordHasher.GetHash(PASSWORD);

                    // Act
                    PasswordHasher.Init(SALT, ADLER_MOD);

                    string actual = PasswordHasher.GetHash(PASSWORD);

                    // Assert
                    Assert.NotEqual(actual, expected);
                }
                catch (OverflowException)
                {
                    Assert.False(true);
                }
            }

            #endregion 0_1_2_4_6

            #region 0_1_2_3_4_6

            /// <summary>
            /// Test Execution Route 0_1_2_3_4_6 with not Empty and Zero
            /// Should be Not Equal
            /// </summary>
            [Fact]
            public void ExecRoute_0_1_2_3_4_6_NotEmptyAndZero_OverflowExceptionAndNotEqual()
            {
                // Arrange
                SetDefaultValues();

                const string SALT = "汉字汉字汉字";
                const uint ADLER_MOD = 0;
                const string PASSWORD = "Dominskyi";

                string expected = PasswordHasher.GetHash(PASSWORD);

                // Act
                PasswordHasher.Init(SALT, ADLER_MOD);

                string actual = PasswordHasher.GetHash(PASSWORD);

                // Assert
                Assert.NotEqual(actual, expected);
            }

            #endregion 0_1_2_3_4_6

            #region 0_1_2_3_4_5_6

            /// <summary>
            /// Test Execution Route 0_1_2_3_4_5_6 with not Empty and Not Zero
            /// Should be Not Equal
            /// </summary>
            [Fact]
            public void ExecRoute_0_1_2_3_4_5_6_NotEmptyAndNotZero_OverflowExceptionAndNotEqual()
            {
                // Arrange
                SetDefaultValues();

                const string SALT = "汉字汉字汉字";
                const uint ADLER_MOD = 1;
                const string PASSWORD = "Dominskyi";

                string expected = PasswordHasher.GetHash(PASSWORD);

                // Act
                PasswordHasher.Init(SALT, ADLER_MOD);

                string actual = PasswordHasher.GetHash(PASSWORD);

                // Assert
                Assert.NotEqual(actual, expected);
            }

            #endregion 0_1_2_3_4_5_6

            #region 0_1_2_4_5_6

            /// <summary>
            /// Test Execution Route 0_1_2_4_5_6 with not Empty and Not Zero
            /// Should be Not Equal
            /// </summary>
            [Fact]
            public void ExecRoute_0_1_2_4_5_6_NotEmptyAndNotZero_NotEqual()
            {
                // Arrange
                SetDefaultValues();

                const string SALT = "Some cool salt";
                const uint ADLER_MOD = 1;
                const string PASSWORD = "Dominskyi";

                string expected = PasswordHasher.GetHash(PASSWORD);

                // Act
                PasswordHasher.Init(SALT, ADLER_MOD);

                string actual = PasswordHasher.GetHash(PASSWORD);

                // Assert
                Assert.NotEqual(actual, expected);
            }

            #endregion 0_1_2_4_5_6

        }

        #endregion Init

        #region GetHash

        /// <summary>
        /// Class for testing GetHash method
        /// </summary>
        public class TestGetHash
        {

            #region 0_1_6

            /// <summary>
            /// Test Execution Route 0_1_6 with null, null and zero
            /// Should be Null
            /// </summary>
            [Fact]
            public void ExecRoute_0_1_6_NullNullAndZero_Null()
            {
                // Arrange
                SetDefaultValues();

                const string SALT = null;
                const uint ADLER_MOD = 0;
                const string PASSWORD = null;

                // Act
                string actual = PasswordHasher.GetHash(PASSWORD, SALT, ADLER_MOD);

                // Assert
                Assert.Null(actual);
            }

            #endregion 0_1_6

            #region 0_1_2_3_6_7

            /// <summary>
            /// Test Execution Route 0_1_2_3_6_7 with not null, not null and positive
            /// Should be not Null
            /// </summary>
            [Fact]
            public void ExecRoute_0_1_2_3_6_7_NotNullNotNullAndPositive_NotNull()
            {
                // Arrange
                SetDefaultValues();

                const string SALT = "Some new cool salt";
                const uint ADLER_MOD = 3;
                const string PASSWORD = "Dominskyi";

                // Act
                string actual = PasswordHasher.GetHash(PASSWORD, SALT, ADLER_MOD);

                // Assert
                Assert.NotNull(actual);
            }

            #endregion 0_1_2_3_6_7

            #region 0_1_2_3_5_6_7

            /// <summary>
            /// Test Execution Route 0_1_2_3_5_6_7 with not null, not null and positive
            /// Should be not Null
            /// </summary>
            [Fact]
            public void ExecRoute_0_1_2_3_5_6_7_NotNullNotNullAndPositive_OverflowExceptionAndNotNull()
            {
                // Arrange
                SetDefaultValues();

                const string SALT = "汉字汉字汉字";
                const uint ADLER_MOD = 3;
                const string PASSWORD = "Dominskyi";

                // Act
                string actual = PasswordHasher.GetHash(PASSWORD, SALT, ADLER_MOD);

                // Assert
                Assert.NotNull(actual);
            }

            #endregion 0_1_2_3_5_6_7

        }

        #endregion GetHash

        #endregion ExecutionRoutes
    }
}
