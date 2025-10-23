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

internal class Program {
   static void Main () {
      Write ("Enter a number: ");
      int.TryParse (ReadLine (), out int n);
      Write ("Enter 'r' for roman numeral and 'w' for word conversion: ");
      string? str = ReadLine ()?.Trim ().ToLower ();
      char choice = string.IsNullOrEmpty (str) ? '\0' : str[0];
      switch (choice) {
         case 'r':
            WriteLine ($"Roman numeral: {ConvertToRoman (n)}"); break;
         case 'w':
            WriteLine ($"Number in words: {ConvertToWord (n)}"); break;
         default:
            WriteLine ("Invalid choice"); break;
      }
   }

   //Converts the given input number into roman numeral and prints it to the console
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

   // Converts the given input number into words and prints it to the console
   static string ConvertToWord (int n) {
      List<string> parts = [];
      foreach (var kv in sPlaceByDivisor) {
         int divisor = kv.Key;
         string place = kv.Value;
         int value = n / divisor;
         if (value != 0) {
            switch (value) {
               case < 10:
                  parts.Add (sOnes[value]); break;
               case < 20:
                  parts.Add (sTeens[value - 10]); break;
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
      string word = string.Join (" ", parts).Trim ().ToUpper ();
      return word;
   }
   static Dictionary<int, string> sRomanMap = new () {
      [1000] = "M", [900] = "CM", [500] = "D", [400] = "CD", [100] = "C", [90] = "XC", [50] = "L", [40] = "XL", [10] = "X", [9] = "IX", [5] = "V", [4] = "IV", [1] = "I"
   };
   static Dictionary<int, string> sPlaceByDivisor = new () {
      [100000] = "lakh", [1000] = "thousand", [100] = "hundred", [1] = ""
   };
   static string[] sOnes = ["", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"];
   static string[] sTeens = ["ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen"];
   static string[] sTens = ["", "", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety"];
}

