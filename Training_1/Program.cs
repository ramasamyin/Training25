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
      string? str = ReadLine ()?.Trim ().ToLower ();
      char choice = string.IsNullOrEmpty (str) ? '\0' : str[0];
      if (choice == 'r') WriteLine ($"Roman numeral: {ConvertToRoman (n)}");
      else if (choice == 'w') WriteLine ($"Number in words: {ConvertToWord (n)}");
      else WriteLine ("Invalid choice");
   }

   #region implementation -------------------------------------------
   //Converts the given input number into roman numeral and returns it as string
   static string ConvertToRoman (int n) {
      var roman = new StringBuilder ();
      foreach (var kv in sRomanMap) {
         int value = kv.Key;
         string symbol = kv.Value;
         while (n >= value) {
            n -= value;
            roman.Append (symbol);
         }
      }
      return roman.ToString ();
   }

   // Converts the given input number into words and returns it as string
   static string ConvertToWord (int n) {
      List<string> parts = [];
      foreach (var kv in sPlaceByDivisor) {
         int divisor = kv.Key;
         string place = kv.Value;
         int value = n / divisor;
         if (value != 0) {
            switch (value) {
               case < 10: parts.Add (sOnes[value]); break;
               case < 20: parts.Add (sTeens[value - 10]); break;
               case < 100: {
                     string t = sTens[value / 10];
                     if (!string.IsNullOrEmpty (t)) parts.Add (t);
                     if (value % 10 != 0) parts.Add (sOnes[value % 10]);
                     break;
                  }
            }
            if (!string.IsNullOrEmpty (place)) parts.Add (place);
         }
         n %= divisor;
      }
      return string.Join (" ", parts).Trim ().ToUpper (); ;
   }
   #endregion

   #region Fields ---------------------------------------------------
   static Dictionary<int, string> sRomanMap = new () {
      [1000] = "M", [900] = "CM", [500] = "D", [400] = "CD", [100] = "C", [90] = "XC", [50] = "L", [40] = "XL", [10] = "X", [9] = "IX", [5] = "V", [4] = "IV", [1] = "I"
   };
   static Dictionary<int, string> sPlaceByDivisor = new () {
      [(int)1E5] = "lakh", [(int)1E3] = "thousand", [100] = "hundred", [1] = ""
   };
   static string[] sOnes = ["", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"];
   static string[] sTeens = ["ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen"];
   static string[] sTens = ["", "", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety"];
   #endregion
}
#endregion

