// ------------------------------------------------------------------------------------------------
// Training ~ A training program for new joinees at Metamation, Batch- July 2025.
// Copyright (c) Metamation India.
// ------------------------------------------------------------------
// Program.cs
// Program on T02 branch.
// ------------------------------------------------------------------------------------------------
using static System.Console;
using System.Text;
namespace Training_1;

#region class Program -----------------------------------------------------------------------------
internal class Program {
   static void Main () {
      Write ("Enter a number: ");
      int.TryParse (ReadLine (), out int n);
      Write ("Enter 'r' for roman numeral and 'w' for word conversion: ");
      var choice = ReadKey ().Key;
      if (choice == ConsoleKey.R) WriteLine ($"\nRoman numeral: {ConvertToRoman (n)}");
      else if (choice == ConsoleKey.W) WriteLine ($"\nNumber in words: {ConvertToWord (n)}");
      else WriteLine ("Invalid choice");
   }

   #region Implementation -------------------------------------------
   //Converts the given input number into roman numeral
   static string ConvertToRoman (int n) {
      if (n <= 0) return string.Empty;
      var roman = new StringBuilder ();
      for (int i = 0; i < values.Length; i++) {
         while (n >= values[i]) {
            roman.Append (symbols[i]);
            n -= values[i];
         }
      }
      return roman.ToString ();
   }

   // Converts the given input number into words
   static string ConvertToWord (int n) {
      List<string> parts = [];
      foreach (int divisor in sdivisors) {
         int value = n / divisor;
         if (value == 0) continue;
         string two = Convert0To99 (value);
         if (!string.IsNullOrEmpty (two)) parts.Add (two);
         if (sPlaceByDivisor.TryGetValue (divisor, out var place)) parts.Add (place);
         n %= divisor;
      }
      string result = string.Join (" ", parts).Trim ().ToUpper ();
      return result;
   }

   // Converts a two digit number into words
   static string Convert0To99 (int n) {
      return n switch {
         0 => string.Empty,
         < 10 => sOnes[n],
         < 20 => sTeens[n - 10],
         _ => sTens[n / 10] + (n % 10 != 0 ? " " + sOnes[n % 10] : "")
      };
   }
   #endregion

   #region Fields ---------------------------------------------------
   static Dictionary<int, string> sPlaceByDivisor = new () {
      [(int)1E5] = "lakh", [(int)1E3] = "thousand", [100] = "hundred", [1] = ""
   };
   static int[] sdivisors = { 100000, 1000, 100, 1 };
   static string[] sOnes = ["", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"];
   static string[] sTeens = ["ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen"];
   static string[] sTens = ["", "", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety"];
   static int[] values = { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };
   static string[] symbols = { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };
   #endregion
}
#endregion