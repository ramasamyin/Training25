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
      int.TryParse (ReadLine (), out int input);
      Write ("Enter 'r' for roman numeral and 'w' for word conversion: ");
      string? choiceStr = ReadLine ()?.Trim ().ToLower ();
      char choice = string.IsNullOrEmpty (choiceStr) ? '\0' : choiceStr[0];
      switch (choice) {
         case 'r':
            WriteLine ($"Roman numeral: {ConvertToRoman (input)}");
            break;
         case 'w':
            WriteLine ($"Number in words: {ConvertToWord (input)}");
            break;
         default:
            WriteLine ("Invalid choice");
            break;
      }
   }

   //Converts the given input number into roman numeral and prints it to the console
   static string ConvertToRoman (int input) {
      var roman = new StringBuilder ();
      string romanNum = string.Empty;
      foreach (var kv in romanMap) {
         int value = kv.Key;
         string symbol = kv.Value;
         while (input >= value) {
            input -= value;
            roman.Append (symbol);
            romanNum = roman.ToString ();
         }
      }
      return romanNum;
   }

   // Converts the given input number into words and prints it to the console
   static string ConvertToWord (int input) {
      List<string> parts = [];
      foreach (var kv in placeByDivisor) {
         int divisor = kv.Key;
         string place = kv.Value;
         int value = input / divisor;
         if (value != 0) {
            switch (value) {
               case < 10:
                  parts.Add (Ones[value]);
                  break;
               case < 20:
                  parts.Add (Teens[value - 10]);
                  break;
               case < 100: {
                     string t = Tens[value / 10];
                     if (!string.IsNullOrEmpty (t)) parts.Add (t);
                     if (value % 10 != 0) parts.Add (Ones[value % 10]);
                     break;
                  }
               default: {
                     int hundreds = value / 100;
                     if (hundreds != 0) {
                        parts.Add (Ones[hundreds]);
                        parts.Add ("hundred");
                     }
                     int rem = value % 100;
                     if (rem != 0) {
                        switch (rem) {
                           case < 10:
                              parts.Add (Ones[rem]);
                              break;
                           case < 20:
                              parts.Add (Teens[rem - 10]);
                              break;
                           default: {
                                 string t = Tens[rem / 10];
                                 if (!string.IsNullOrEmpty (t)) parts.Add (t);
                                 if (rem % 10 != 0) parts.Add (Ones[rem % 10]);
                                 break;
                              }
                        }
                     }
                     break;
                  }
            }

            if (!string.IsNullOrEmpty (place)) parts.Add (place);
         }
         input %= divisor;
      }
      string word = string.Join (" ", parts).Trim ().ToUpper ();
      return word;
   }
   static Dictionary<int, string> romanMap = new () {
      [1000] = "M", [900] = "CM", [500] = "D", [400] = "CD", [100] = "C", [90] = "XC", [50] = "L", [40] = "XL", [10] = "X", [9] = "IX", [5] = "V", [4] = "IV", [1] = "I"
   };
   static Dictionary<int, string> placeByDivisor = new () {
      [10000000] = "crore", [100000] = "lakh", [1000] = "thousand", [100] = "hundred", [1] = ""
   };
   static string[] Ones = ["", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"];
   static string[] Teens = ["ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen"];
   static string[] Tens = ["", "", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety"];
}

