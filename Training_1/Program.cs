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
      var roman = new StringBuilder ();
      foreach (var kvp in sRomanMap) {
         while (n >= kvp.Key) {
            roman.Append (kvp.Value);
            n -= kvp.Key;
         }
      }
      return roman.ToString ();
   }

   // Converts the given number into words
   static string ConvertToWord (int n) {
      List<string> parts = [];
      foreach (int divisor in sdivisors) {
         int value = n / divisor;
         if (value == 0) continue;
         parts.Add (Convert1To99 (value));
         if (sPlaceByDivisor.TryGetValue (divisor, out var place)) parts.Add (place);
         n %= divisor;
      }
      string result = string.Join (" ", parts).Trim ().ToUpper ();
      return result;
   }

   // Converts numbers from 1 to 99 into words
   static string Convert1To99 (int n) {
      return n switch {
         < 10 => sOnes[n],
         < 20 => sTeens[n - 10],
         // n = 35 => sTens[3] + " " + sOnes[5] => "thirty five"
         _ => sTens[n / 10] + (n % 10 != 0 ? " " + sOnes[n % 10] : "")
      };
   }
   #endregion

   #region Fields ---------------------------------------------------
   static Dictionary<int, string> sPlaceByDivisor = new () {
      [(int)1E5] = "lakh", [(int)1E3] = "thousand", [100] = "hundred", [1] = ""
   };
   static int[] sdivisors = [100000, 1000, 100, 1];
   static string[] sOnes = ["", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"];
   static string[] sTeens = ["ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen"];
   static string[] sTens = ["", "", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety"];
   static Dictionary<int, string> sRomanMap = new () { { 1000,"M"},{ 900,"CM"},{ 500,"D"},{ 400,"CD"},
                                                               { 100,"C"},{ 90,"XC"},{ 50,"L"},{ 40,"XL"},{ 10,"X"},{ 9,"IX"},{ 5,"V"},{ 4,"IV"},{ 1,"I"}};
   #endregion
}
#endregion