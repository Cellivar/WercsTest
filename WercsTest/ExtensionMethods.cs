using Microsoft.Ajax.Utilities;
using System;
using System.Text;

namespace WercsTest
{
	public static class ExtensionMethods
	{
		/// <summary>
		/// Fancypants custom string reversing method, as documents required
		/// no use of built in functions
		/// </summary>
		/// <param name="str"></param>
		/// <returns>Reversed string</returns>
		public static String FancyStringReverse(this String str)
		{
			/* Cheater method is using LINQ
			 * string reversed = new string(str.Reverse().ToArray());
			 * Linq would probably also use a much more optimized method of
			 * reversal, this is not particularly efficient but what works off
			 * the top of my head
			 */

			// Sanity check/efficiency 
			if (str.IsNullOrWhiteSpace())
			{
				return string.Empty;
			}

			var revStr = new StringBuilder();

			// Treat a string like an array, and just count backwards
			for (int index = str.Length - 1; index >= 0; index--)
			{
				revStr.Append(str[index]);
			}

			return revStr.ToString();
		}
	}
}