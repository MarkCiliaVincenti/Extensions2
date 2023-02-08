﻿#pragma warning disable CS1587, CS1998, IDE0059, IDE0028

/// <summary>
/// Author: Cornelius J. van Dyk blog.cjvandyk.com @cjvandyk
/// This code is provided under GNU GPL 3.0 and is a copyrighted work of the
/// author and contributors.  Please see:
/// https://github.com/cjvandyk/Extensions/blob/main/LICENSE
/// </summary>

using System;
using static Extensions.Universal;

namespace Extensions
{
    /// <summary>
    /// Extensions to the long class.
    /// </summary>
    [Serializable]
    public static partial class LongExtensions
    {
        #region IsEven()
        /// <summary>
        /// Checks if the given number is even.
        /// </summary>
        /// <param name="number">The given number to check.</param>
        /// <returns>True if the number is even, else False.</returns>
        public static bool IsEven(this long number)
        {
            ValidateNoNulls(number);
            return (number % 2 == 0);
        }
        #endregion IsEven()

        #region IsOdd()
        /// <summary>
        /// Checks if the given number is odd.
        /// </summary>
        /// <param name="number">The given number to check.</param>
        /// <returns>True if the number is odd, else False.</returns>
        public static bool IsOdd(this long number)
        {
            ValidateNoNulls(number);
            return (number % 2 != 0);
        }
        #endregion IsOdd()

        #region IsPrime()
        /// <summary>
        /// Checks if the given number is a prime number.
        /// </summary>
        /// <param name="number">The given number to evaluate as a prime.</param>
        /// <returns>True if the given number is prime, else False.</returns>
        public static bool IsPrime(this long number)
        {
            return UInt64Extensions.IsPrime((System.UInt64)number, true);
        }
        #endregion IsPrime()
    }
}
#pragma warning restore CS1587, CS1998, IDE0059, IDE0028
