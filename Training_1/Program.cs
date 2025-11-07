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
      char choice = char.ToLower(ReadKey().KeyChar);
      if (choice == 'r') WriteLine ($"\nRoman numeral: {ConvertToRoman (n)}");
      else if (choice == 'w') WriteLine ($"\nNumber in words: {ConvertToWord (n)}");
      else WriteLine ("Invalid choice");
      WriteLine ("\nPress any key to exit...");
      ReadKey ();
   }

   #region implementation -------------------------------------------
   //Converts the given input number into roman numeral and returns it as string
   static string ConvertToRoman (int n) {
      if (n <= 0) return string.Empty;
      var roman = new StringBuilder ();
      int[] digits = { n / 1000, (n % 1000) / 100, (n % 100) / 10, n % 10 };
      string[][] arrays = { sRomanThousands, sRomanHundreds, sRomanTens, sRomanOnes };
      for (int i = 0; i < digits.Length; i++) roman.Append (arrays[i][digits[i]]);
      return roman.ToString ();
   }

   // Converts the given input number into words and returns it as string
   static string ConvertToWord (int n) {
      if (n == 0) return "ZERO";
      int input = Math.Abs (n);
      List<string> parts = [];
      // helper for values 0..99
      static string TwoDigit (int val) {
         if (val == 0) return string.Empty;
         if (val < 10) return sOnes[val];
         if (val < 20) return sTeens[val - 10];
         int tensVal = val / 10;
         int onesVal = val % 10;
         return string.IsNullOrEmpty (sTens[tensVal]) ? sOnes[onesVal] : (sTens[tensVal] + (onesVal != 0 ? " " + sOnes[onesVal] : ""));
      }
      foreach (int divisor in sdivisors) {
         int value = input / divisor;
         if (value != 0) {
            if (divisor == 100) {
               parts.Add (sOnes[value]);
               parts.Add ("hundred");
            } else if (divisor == 1) {
               string two = TwoDigit (value);
               if (!string.IsNullOrEmpty (two)) parts.Add (two);
            } else {
               string two = TwoDigit (value);
               if (!string.IsNullOrEmpty (two)) parts.Add (two);
               string place = sPlaceByDivisor.TryGetValue (divisor, out string? places) ? places : string.Empty;
               if (!string.IsNullOrEmpty (place)) parts.Add (place);
            }
         }
         input %= divisor;
      }
      string result = string.Join (" ", parts).Trim ().ToUpper ();
      return result;
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
   static string[] sRomanThousands = { "", "M", "MM", "MMM" };
   static string[] sRomanHundreds = { "", "C", "CC", "CCC", "CD", "D", "DC", "DCC", "DCCC", "CM" };
   static string[] sRomanTens = { "", "X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC" };
   static string[] sRomanOnes = { "", "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX" };
   #endregion
}
#endregion

