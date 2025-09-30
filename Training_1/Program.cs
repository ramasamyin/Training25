// ------------------------------------------------------------------------------------------------
// Training ~ A training program for new joinees at Metamation, Batch- July 2025.
// Copyright (c) Metamation India.
// ------------------------------------------------------------------
// Program.cs
// Program on main branch.
// ------------------------------------------------------------------------------------------------
namespace Training_1 {
   internal class Program {
      static void Main (string[] args) {
         int[] values = [1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1];
         string[] symbols = ["M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I"];
         int input = 9;
         string roman = "";
         for (int i = 0; i < values.Length; i++) {
            while (input >= values[i]) { input -= values[i]; roman += symbols[i]; }

         }
         Console.WriteLine (roman);

         //words
         string[] ones = { "", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
         string[] teens = { "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
         string[] tens = { "", "", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };
         string[] places = { "crore", "lakh", "thousand", "hundred", "" };

         int[] divisors = { 10000000, 100000, 1000, 100, 1 };

         int number = 200000000;
         string word = "";

         for (int i = 0; i < divisors.Length; i++) {
            int value = number / divisors[i];
            if (value != 0) {
               if (value < 10) word += ones[value] + " ";
               else if (value < 20) word += teens[value - 10] + " ";
               else if (value < 100) {
                  word += tens[value / 10] + " ";
                  if (value % 10 != 0) word += ones[value % 10] + " ";
               }
               if (places[i] != "") { word += places[i] + " "; }
            }
            number %= divisors[i];

         }
         Console.WriteLine (word.Trim ());
      }
   }
}
