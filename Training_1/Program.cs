// ------------------------------------------------------------------------------------------------
// Training ~ A training program for new joinees at Metamation, Batch- July 2025.
// Copyright (c) Metamation India.
// ------------------------------------------------------------------
// Program.cs
// Program on T02 branch.
// ------------------------------------------------------------------------------------------------
using static System.Console;
namespace Training_1;

internal class Program {
   private static readonly int[] RomanValues = [1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1];
   private static readonly string[] RomanSymbols = ["M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I"];
   private static readonly string[] Ones = ["", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"];
   private static readonly string[] Teens = ["ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen"];
   private static readonly string[] Tens = ["", "", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety"];
   private static readonly string[] Places = ["crore", "lakh", "thousand", "hundred", ""];
   private static readonly int[] Divisors = [10000000, 100000, 1000, 100, 1];

   static void Main () {
      Write ("Enter a number: ");
      int.TryParse (ReadLine (), out int input);
      Write ("Enter 'r' for roman numeral and 'w' for word conversion: ");
      char.TryParse (ReadLine (), out char choice);
      if (choice == 'r') ConvertToRoman (input);
      else if (choice == 'w') ConvertToWord (input);
      else WriteLine ("Invalid choice");
   }

   //Converts the given input number into roman numeral and prints it to the console
   static void ConvertToRoman (int input) {
      string roman = "";
      for (int i = 0, len = RomanValues.Length; i < len; i++) {
         int value = RomanValues[i];
         while (input >= value) {
            input -= value;
            roman += RomanSymbols[i];
         }
      }
      WriteLine ($"Roman numeral: {roman}");
   }

   // Converts the given input number into words and prints it to the console
   static void ConvertToWord (int input) {
      string word = "";
      for (int i = 0, len = Divisors.Length; i < len; i++) {
         int value = input / Divisors[i];
         if (value != 0) {
            if (value < 10) word += Ones[value] + " ";
            else if (value < 20) word += Teens[value - 10] + " ";
            else if (value < 100) {
               word += Tens[value / 10] + " ";
               if (value % 10 != 0) word += Ones[value % 10] + " ";
            }
            string place = Places[i];
            if (place != "") word += place + " ";
         }
         input %= Divisors[i];
      }
      WriteLine ($"Number (in words): {word.Trim ().ToUpper ()}");
   }
}


